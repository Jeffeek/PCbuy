using System;
using System.Runtime.InteropServices;

namespace TRPO_Project
{
    public static class ScaleControls
    {
        public static double Scale = 1f;

        [DllImport("user32.dll")]
        static extern int GetDpiForWindow(IntPtr hWnd);

        public static void SetScalingFactor(IntPtr windowHandle)
        {
            try
            {
                Scale = GetDpiForWindow(windowHandle) / 96f;
            }
            catch(Exception ex)
            {
                Scale = 1f;
            }
        }

    }
}
