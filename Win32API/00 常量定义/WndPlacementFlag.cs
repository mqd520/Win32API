using System;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// WindowPlacement参数
    /// </summary>
    public class WndPlacementFlag
    {
        /// <summary>
        /// 表明可以指定最小化窗口的x和y坐标。如果是在ptMinPosition成员中设置坐标，则必须指定这个标志
        /// </summary>
        public const int WPF_SETMINPOSITION = 0x0001;

        /// <summary>
        /// 表明复原后的窗口将会被最大化，而不管它在最小化之前是否是最大化的。这个设置仅在下一次复原窗口时有效。
        /// 它不改变缺省的复原操作。这个标志仅当showCmd成员中指定了SW_SHOWMINIMIZED时才有效
        /// </summary>
        public const int WPF_RESTORETOMAXIMIZED = 0x0002;
    }
}
