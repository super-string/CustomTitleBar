using System.Runtime.InteropServices;

namespace CustomTitleBar
{
    public class CustomTitleBarFormBase : Form
    {
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                // クライアント領域計算
                case NativeMethods.WM_NCCALCSIZE:
                    if (!DesignMode && m.WParam != IntPtr.Zero && m.Result == IntPtr.Zero)
                    {
                        NativeMethods.NCCALCSIZE_PARAMS nc = (NativeMethods.NCCALCSIZE_PARAMS)Marshal.PtrToStructure(m.LParam, typeof(NativeMethods.NCCALCSIZE_PARAMS));
                        nc.rcNewWindow.Top -= SystemInformation.CaptionHeight + SystemInformation.FrameBorderSize.Height + NativeMethods.GetPaddingBorder();
                        nc.rcOldWindow = nc.rcNewWindow;

                        Marshal.StructureToPtr(nc, m.LParam, false);
                        m.Result = (IntPtr)NativeMethods.WVR_VALIDRECTS;
                        base.WndProc(ref m);
                        return;
                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);
        }

        protected static class NativeMethods
        {
            public const int SM_CXPADDEDBORDER = 92;

            [DllImport("user32.dll")]
            public static extern int GetSystemMetrics(int nIndex);

            public static int GetPaddingBorder() => GetSystemMetrics(SM_CXPADDEDBORDER);
            public const int WM_NCCALCSIZE = 0x83;
            public const int WVR_VALIDRECTS = 0x0400;

            [StructLayout(LayoutKind.Sequential)]
            public struct NCCALCSIZE_PARAMS
            {
                public RECT rcNewWindow;
                public RECT rcOldWindow;
                public RECT rcClient;
                IntPtr lppos;
            }

            [StructLayout(LayoutKind.Sequential)]
            public struct RECT
            {
                public int Left;
                public int Top;
                public int Right;
                public int Bottom;
                public int Width() => Right - Left;
                public int Height() => Bottom - Top;
                public Size Size => new Size(Right - Left, Bottom - Top);
            }
            public const int WM_SYSCOMMAND = 0x0112;
            public const int SC_MOVE = 0xF010;
            public const int SC_SIZE = 0xF000;

            [DllImport("User32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, int lParam);

            [DllImport("User32.dll")]
            public static extern bool SetCapture(IntPtr hWnd);

            [DllImport("user32.dll")]
            public static extern bool ReleaseCapture();
        }
    }
}
