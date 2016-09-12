using System;
using System.Runtime.InteropServices;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// WindowPlacement
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct WindowPlacement
    {
        /// <summary>
        /// 指定了结构的长度，以字节为单位
        /// </summary>
        public uint length;

        /// <summary>
        /// WndPlacementFlag值之一或组合,指定了控制最小化窗口的位置的标志以及复原窗口的方法
        /// </summary>
        public uint flags;

        /// <summary>
        /// WndPlacementCmd值之一,指定了窗口的当前显示状态
        /// </summary>
        public uint showCmd;

        /// <summary>
        /// 指定了窗口被最小化时左上角的位置
        /// </summary>
        public Point ptMinPosition;

        /// <summary>
        /// 指定了窗口被最大化时左上角的位置
        /// </summary>
        public Point ptMaxPosition;

        /// <summary>
        /// 指定了窗口处于正常状态（复原）时的坐标
        /// </summary>
        public Rect rcNormalPosition;
    }
}
