using System;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// AnimateWindow标志
    /// </summary>
    public class AnimateWndFlags
    {
        /// <summary>
        /// 使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略
        /// </summary>
        public const uint AW_SLIDE = 0x00040000;

        /// <summary>
        /// 激活窗口。在使用了AW_HIDE标志后不要使用这个标志
        /// </summary>
        public const uint AW_ACTIVATE = 0x00020000;

        /// <summary>
        /// 使用淡出效果。只有当hWnd为顶层窗口的时候才可以使用此标志
        /// </summary>
        public const uint AW_BLEND = 0x00080000;

        /// <summary>
        /// 隐藏窗口，缺省则显示窗口
        /// </summary>
        public const uint AW_HIDE = 0x00010000;

        /// <summary>
        /// 若使用了AW_HIDE标志，则使窗口向内重叠；若未使用AW_HIDE标志，则使窗口向外扩展
        /// </summary>
        public const uint AW_CENTER = 0x00000010;

        /// <summary>
        /// 自左向右显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略
        /// </summary>
        public const uint AW_HOR_POSITIVE = 0x00000001;

        /// <summary>
        /// 自顶向下显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略
        /// </summary>
        public const uint AW_VER_POSITIVE = 0x00000004;

        /// <summary>
        /// 自下向上显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略
        /// </summary>
        public const uint AW_VER_NEGATIVE = 0x00000008;
    }
}
