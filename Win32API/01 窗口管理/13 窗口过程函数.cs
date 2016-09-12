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
        /// 默认窗口过程
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="Msg">消息号</param>
        /// <param name="wParam">参数1</param>
        /// <param name="lParam">参数2</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr DefWindowProc(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 将消息信息传送给指定的窗口过程的函数
        /// </summary>
        /// <param name="lpPrevWndFunc">指向前一个窗口过程的指针</param>
        /// <param name="hWnd">指向接收消息的窗口过程的句柄</param>
        /// <param name="Msg">指定消息类型</param>
        /// <param name="wParam">消息特定的信息</param>
        /// <param name="lParam">消息特定的信息</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CallWindowProc(WndProc lpPrevWndFunc, IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
    }
}
