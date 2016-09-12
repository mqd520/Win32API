using System;
using System.Runtime.InteropServices;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// 表示一个坐标点
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct Point
    {
        /// <summary>
        /// x坐标
        /// </summary>
        public int x;

        /// <summary>
        /// y坐标
        /// </summary>
        public int y;
    }
}
