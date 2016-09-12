using System;
using System.Runtime.InteropServices;
using Mqd.Win32.DataDef;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// MouseHook
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MouseHook
    {
        /// <summary>
        /// 鼠标位置
        /// </summary>
        public Point pt;

        /// <summary>
        /// 窗口句柄
        /// </summary>
        public int hwnd;

        /// <summary>
        /// NcHitTestCmd值之一
        /// </summary>
        public int wHitTestCode;

        /// <summary>
        /// 附加信息
        /// </summary>
        public int dwExtraInfo;
    }
}
