using System;
using System.Runtime.InteropServices;

namespace TRPO_Project
{
    public static class ScaleControls
    {
        public static double Scale = 1f;

        [DllImport("user32.dll")]
        private static extern int GetDpiForWindows(IntPtr hWnd);

        public static void SetScalingFactor(IntPtr windowHandle)
        {
            try
            {
                Scale = GetDpiForWindows(windowHandle) / 96f;
            }
            catch
            {
                Scale = 1f;
            }
        }

    }
}
