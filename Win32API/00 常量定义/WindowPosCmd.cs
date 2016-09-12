using System;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// WindowPosCmd
    /// </summary>
    public class WindowPosCmd
    {
        /// <summary>
        /// 将窗口置于Z序的底部
        /// </summary>
        public const int HWND_BOTTOM = 1;

        /// <summary>
        /// 将窗口置于所有非顶层窗口之上（即在所有顶层窗口之后）
        /// </summary>
        public const int HWND_NOTOPMOST = -2;

        /// <summary>
        /// 将窗口置于Z序的顶部
        /// </summary>
        public const int HWND_TOP = 0;

        /// <summary>
        /// 将窗口置于所有非顶层窗口之上。即使窗口未被激活窗口也将保持顶级位置
        /// </summary>
        public const int HWND_TOPMOST = -1;
    }
}
