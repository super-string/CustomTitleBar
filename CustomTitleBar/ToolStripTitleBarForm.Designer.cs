namespace CustomTitleBar
{
    partial class ToolStripTitleBarForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolStripTitleBarForm));
            this._toolStripTitleBar = new System.Windows.Forms.ToolStrip();
            this._toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this._toolStripButtonMaximize = new System.Windows.Forms.ToolStripButton();
            this._toolStripButtonMinimize = new System.Windows.Forms.ToolStripButton();
            this._toolStripLabelTitle = new System.Windows.Forms.ToolStripLabel();
            this._toolStripTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _toolStripTitleBar
            // 
            this._toolStripTitleBar.AutoSize = false;
            this._toolStripTitleBar.BackColor = System.Drawing.SystemColors.Desktop;
            this._toolStripTitleBar.CanOverflow = false;
            this._toolStripTitleBar.GripMargin = new System.Windows.Forms.Padding(0);
            this._toolStripTitleBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._toolStripTitleBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this._toolStripTitleBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripButtonClose,
            this._toolStripButtonMaximize,
            this._toolStripButtonMinimize,
            this._toolStripLabelTitle});
            this._toolStripTitleBar.Location = new System.Drawing.Point(0, 0);
            this._toolStripTitleBar.Name = "_toolStripTitleBar";
            this._toolStripTitleBar.Padding = new System.Windows.Forms.Padding(0);
            this._toolStripTitleBar.Size = new System.Drawing.Size(800, 50);
            this._toolStripTitleBar.Stretch = true;
            this._toolStripTitleBar.TabIndex = 0;
            this._toolStripTitleBar.Text = "toolStrip1";
            // 
            // _toolStripButtonClose
            // 
            this._toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._toolStripButtonClose.AutoToolTip = false;
            this._toolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._toolStripButtonClose.ForeColor = System.Drawing.SystemColors.Window;
            this._toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("_toolStripButtonClose.Image")));
            this._toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripButtonClose.Name = "_toolStripButtonClose";
            this._toolStripButtonClose.Size = new System.Drawing.Size(46, 44);
            this._toolStripButtonClose.Text = "×";
            this._toolStripButtonClose.ToolTipText = "閉じる";
            this._toolStripButtonClose.Click += new System.EventHandler(this._toolStripButtonClose_Click);
            // 
            // _toolStripButtonMaximize
            // 
            this._toolStripButtonMaximize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._toolStripButtonMaximize.AutoToolTip = false;
            this._toolStripButtonMaximize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._toolStripButtonMaximize.ForeColor = System.Drawing.SystemColors.Window;
            this._toolStripButtonMaximize.Image = ((System.Drawing.Image)(resources.GetObject("_toolStripButtonMaximize.Image")));
            this._toolStripButtonMaximize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripButtonMaximize.Name = "_toolStripButtonMaximize";
            this._toolStripButtonMaximize.Size = new System.Drawing.Size(46, 44);
            this._toolStripButtonMaximize.Text = "□";
            this._toolStripButtonMaximize.ToolTipText = "最大化";
            this._toolStripButtonMaximize.Click += new System.EventHandler(this._toolStripButtonMaximize_Click);
            // 
            // _toolStripButtonMinimize
            // 
            this._toolStripButtonMinimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._toolStripButtonMinimize.AutoToolTip = false;
            this._toolStripButtonMinimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._toolStripButtonMinimize.ForeColor = System.Drawing.SystemColors.Window;
            this._toolStripButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("_toolStripButtonMinimize.Image")));
            this._toolStripButtonMinimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripButtonMinimize.Name = "_toolStripButtonMinimize";
            this._toolStripButtonMinimize.Size = new System.Drawing.Size(46, 44);
            this._toolStripButtonMinimize.Text = "_";
            this._toolStripButtonMinimize.ToolTipText = "最小化";
            this._toolStripButtonMinimize.Click += new System.EventHandler(this._toolStripButtonMinimize_Click);
            // 
            // _toolStripLabelTitle
            // 
            this._toolStripLabelTitle.DoubleClickEnabled = true;
            this._toolStripLabelTitle.ForeColor = System.Drawing.SystemColors.Window;
            this._toolStripLabelTitle.Name = "_toolStripLabelTitle";
            this._toolStripLabelTitle.Size = new System.Drawing.Size(213, 44);
            this._toolStripLabelTitle.Text = "Customize TitleBar";
            // 
            // ToolStripTitleBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._toolStripTitleBar);
            this.Name = "ToolStripTitleBarForm";
            this.Text = "Customize TitleBar";
            this._toolStripTitleBar.ResumeLayout(false);
            this._toolStripTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStrip _toolStripTitleBar;
        private ToolStripButton _toolStripButtonClose;
        private ToolStripButton _toolStripButtonMaximize;
        private ToolStripButton _toolStripButtonMinimize;
        private ToolStripLabel _toolStripLabelTitle;
    }
}