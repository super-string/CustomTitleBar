using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CustomTitleBar
{
    public partial class ToolStripTitleBarForm : CustomTitleBarFormBase
    {
        public new string Text
        {
            get => _toolStripLabelTitle.Text;
            set => _toolStripLabelTitle.Text = value;
        }
        [Category("TitleBar")]
        public int TitleBarHeight
        {
            get => _toolStripTitleBar.Height;
            set => _toolStripTitleBar.Height = value;
        }
        [Category("TitleBar")]
        public ToolStripItemCollection TitleBarItems => _toolStripTitleBar.Items;
        [Category("TitleBar")]
        public bool TitleBarAutoSize
        {
            get => _toolStripTitleBar.AutoSize;
            set => _toolStripTitleBar.AutoSize = value;
        }

        public ToolStripTitleBarForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            foreach (ToolStripItem item in _toolStripTitleBar.Items)
            {
                if (item == null) continue;
                item.MouseDown += TitleBar_MouseDown;
                item.MouseMove += TitleBar_MouseMove;
            }
            _toolStripTitleBar.MouseMove += TitleBar_MouseMove;
            _toolStripTitleBar.MouseDown += TitleBar_MouseDown;
            _toolStripTitleBar.MouseDoubleClick += TitleBar_MouseDoubleClick;
            _toolStripTitleBar.Renderer = new DarkThemeRenderer();
        }

        private void TitleBar_MouseDown(object? sender, MouseEventArgs e)
        {
            NativeMethods.SetCapture(Handle);
            NativeMethods.ReleaseCapture();

            int flag = 0;
            if (e.Y < 5)
            {
                flag += 0x0003;
            }

            if (flag != 0)
            {
                NativeMethods.SendMessage(Handle, NativeMethods.WM_SYSCOMMAND, NativeMethods.SC_SIZE | flag, 0);
            }
            else
            {
                if (sender.Equals(_toolStripTitleBar))
                {
                    //ダブルクリックと相性悪い状態だが未調整
                    NativeMethods.SendMessage(Handle, NativeMethods.WM_SYSCOMMAND, NativeMethods.SC_MOVE | 2, 0);
                }
            }
        }

        private void TitleBar_MouseMove(object? sender, MouseEventArgs e)
        {
            int flag = 0;
            if (e.Y < 5)
            {
                flag += 0x0003;
            }
            switch (flag)
            {
                case 0:
                    Cursor = Cursors.Default;
                    break;
                case 3:
                    Cursor = Cursors.SizeNS;
                    break;
            }
        }

        private void TitleBar_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            ChangeWindowState();
        }

        private void ChangeWindowState()
        {
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private class DarkThemeRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
            {
                if (!e.Item.Selected)
                {
                    base.OnRenderButtonBackground(e);
                }
                else
                {
                    Rectangle rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
                    e.Graphics.FillRectangle(SystemBrushes.ControlDark, rectangle);
                    e.Graphics.DrawRectangle(SystemPens.ControlDark, rectangle);
                }
            }
        }

        private void _toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _toolStripButtonMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void _toolStripButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}