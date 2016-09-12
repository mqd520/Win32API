using System;
using System.Runtime.InteropServices;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// 表示一个矩形区域
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct Rect
    {
        /// <summary>
        /// 
        /// </summary>
        public int left;
        /// <summary>
        /// 
        /// </summary>
        public int top;
        /// <summary>
        /// 
        /// </summary>
        public int right;
        /// <summary>
        /// 
        /// </summary>
        public int bottom;
    }
}
