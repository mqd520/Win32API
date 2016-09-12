using System;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// SCMonitorPowerCmd
    /// </summary>
    public class SCMonitorPowerCmd
    {
        /// <summary>
        /// 显示设备打开
        /// </summary>
        public const int open = -1;

        /// <summary>
        /// 显示设备将要进入节电模式
        /// </summary>
        public const int powerSaving = 1;

        /// <summary>
        /// 显示设备将要被关闭
        /// </summary>
        public const int close = 2;
    }
}
