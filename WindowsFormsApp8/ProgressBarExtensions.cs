using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

    public static class ProgressBarExtensions 
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        private const int PBM_SETSTATE = 0x0410;

        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, PBM_SETSTATE, (IntPtr)state, IntPtr.Zero);
        }
}
