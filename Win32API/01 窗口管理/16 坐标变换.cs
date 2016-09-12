using System;
using System.Runtime.InteropServices;
using Mqd.Win32.DataDef;

namespace Mqd.Win32.API
{
    /// <summary>
    /// Win32API
    /// </summary>
    public partial class Win32API
    {
        /// <summary>
        /// 客户区坐标转换成屏幕坐标
        /// </summary>
        /// <param name="hwnd">窗口句柄</param>
        /// <param name="lpPoint">坐标点</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ClientToScreen(IntPtr hwnd, ref Point lpPoint);

        /// <summary>
        /// 屏幕坐标转换成客户区坐标
        /// </summary>
        /// <param name="hwnd">窗口句柄</param>
        /// <param name="lpPoint">坐标点</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ScreenToClient(IntPtr hwnd, ref Point lpPoint);
    }
}
