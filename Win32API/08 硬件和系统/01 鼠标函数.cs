using System;
using System.Runtime.InteropServices;

namespace Mqd.Win32.API
{
    /// <summary>
    /// Win32API
    /// </summary>
    public partial class Win32API
    {
        /// <summary>
        /// 模拟鼠标
        /// </summary>
        /// <param name="dwFlags"></param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        /// <param name="dwData"></param>
        /// <param name="dwExtraInfo"></param>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void mouse_event(uint dwFlags,uint dx,uint dy,uint dwData,IntPtr dwExtraInfo);
    }
}
