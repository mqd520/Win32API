using System;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// WindowPlacement参数
    /// </summary>
    public class WndPlacementCmd
    {
        /// <summary>
        /// 隐藏窗口并激活其他窗口
        /// </summary>
        public const int SW_HIDE = 0;

        /// <summary>
        /// 最小化指定的窗口并且激活在Z序中的下一个顶层窗口
        /// </summary>
        public const int SW_MINIMIZE = 6;

        /// <summary>
        /// 激活并显示窗口。如果窗口最小化或最大化，则系统将窗口恢复到原来的尺寸和位置。
        /// 在恢复最小化窗口时，应用程序应该指定这个标志
        /// </summary>
        public const int SW_RESTORE = 9;

        /// <summary>
        /// 在窗口原来的位置以原来的尺寸激活和显示窗口
        /// </summary>
        public const int SW_SHOW = 5;

        /// <summary>
        /// 激活窗口并将其最大化
        /// </summary>
        public const int SW_SHOWMAXIMIZED = 3;

        /// <summary>
        /// 激活窗口并将其最小化
        /// </summary>
        public const int SW_SHOWMINIMIZED = 2;

        /// <summary>
        /// 窗口最小化，激活窗口仍然维持激活状态
        /// </summary>
        public const int SW_SHOWMINNOACTIVE = 7;

        /// <summary>
        /// 以窗口原来的状态显示窗口。激活窗口仍然维持激活状态
        /// </summary>
        public const int SW_SHOWNA = 8;

        /// <summary>
        /// 以窗口最近一次的大小和状态显示窗口。激活窗口仍然维持激活状态
        /// </summary>
        public const int SW_SHOWNOACTIVATE = 4;

        /// <summary>
        /// 激活并显示一个窗口。如果窗口被最小化或最大化，系统将其恢复到原来的尺寸和大小。
        /// 应用程序在第一次显示窗口的时候应该指定此标志
        /// </summary>
        public const int SW_SHOWNORMAL = 1;
    }
}
