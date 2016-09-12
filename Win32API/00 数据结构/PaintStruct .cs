using System;
using System.Runtime.InteropServices;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// PaintStruct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct PaintStruct
    {
        /// <summary>
        /// 设备环境句柄
        /// </summary>
        public IntPtr hdc;

        /// <summary>
        /// 是否擦除背景
        /// </summary>
        public bool fErase;
        /// <summary>
        /// rcPaint_left
        /// </summary>
        public int rcPaint_left;
        /// <summary>
        /// rcPaint_top
        /// </summary>
        public int rcPaint_top;
        /// <summary>
        /// rcPaint_right
        /// </summary>
        public int rcPaint_right;
        /// <summary>
        /// rcPaint_bottom
        /// </summary>
        public int rcPaint_bottom;

        /// <summary>
        /// 
        /// </summary>
        public bool fRestore;

        /// <summary>
        /// 
        /// </summary>
        public bool fIncUpdate;

        /// <summary>
        /// reserved1
        /// </summary>
        public int reserved1;
        /// <summary>
        /// reserved2
        /// </summary>
        public int reserved2;
        /// <summary>
        /// reserved3
        /// </summary>
        public int reserved3;
        /// <summary>
        /// reserved4
        /// </summary>
        public int reserved4;
        /// <summary>
        /// reserved5
        /// </summary>
        public int reserved5;
        /// <summary>
        /// reserved6
        /// </summary>
        public int reserved6;
        /// <summary>
        /// reserved7
        /// </summary>
        public int reserved7;
        /// <summary>
        /// reserved8
        /// </summary>
        public int reserved8;
    }
}
