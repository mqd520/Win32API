using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// 窗口类数据结构
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct WndClass
    {
        /// <summary>
        /// 窗口类型
        /// </summary>
        public uint style;

        /// <summary>
        /// 窗口处理函数
        /// </summary>
        public WndProc lpfnWndProc;

        /// <summary>
        /// 窗口扩展
        /// </summary>
        public int cbClsExtra;

        /// <summary>
        /// 窗口实例扩展
        /// </summary>
        public int cbWndExtra;

        /// <summary>
        /// 实例句柄
        /// </summary>
        public IntPtr hInstance;

        /// <summary>
        /// 窗口的最小化图标
        /// </summary>
        public IntPtr hIcon;

        /// <summary>
        /// 窗口鼠标光标
        /// </summary>
        public IntPtr hCursor;

        /// <summary>
        /// 窗口背景色
        /// </summary>
        public IntPtr hbrBackground;

        /// <summary>
        /// 窗口菜单
        /// </summary>
        public string lpszMenuName;

        /// <summary>
        /// 窗口类名
        /// </summary>
        public string lpszClassName;
    }

    /// <summary>
    /// 窗口类数据结构
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct WndClassFromUnmanged
    {
        /// <summary>
        /// 窗口类型
        /// </summary>
        public uint style;

        /// <summary>
        /// 窗口处理函数指针
        /// </summary>
        public IntPtr lpfnWndProc;

        /// <summary>
        /// 窗口扩展
        /// </summary>
        public int cbClsExtra;

        /// <summary>
        /// 窗口实例扩展
        /// </summary>
        public int cbWndExtra;

        /// <summary>
        /// 实例句柄
        /// </summary>
        public IntPtr hInstance;

        /// <summary>
        /// 窗口的最小化图标
        /// </summary>
        public IntPtr hIcon;

        /// <summary>
        /// 窗口鼠标光标
        /// </summary>
        public IntPtr hCursor;

        /// <summary>
        /// 窗口背景色
        /// </summary>
        public IntPtr hbrBackground;

        /// <summary>
        /// 窗口菜单
        /// </summary>
        public IntPtr lpszMenuName;

        /// <summary>
        /// 窗口类名
        /// </summary>
        public IntPtr lpszClassName;
    }
}
