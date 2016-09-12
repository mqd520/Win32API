using System;
using System.Runtime.InteropServices;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// FUFlags
    /// </summary>
    public class FUFlags
    {
        /// <summary>
        /// 如果接收进程处于“hung”状态，不等待超时周期结束就返回
        /// </summary>
        public const uint SMTO_ABORTIFHUNG = 0x0002;

        /// <summary>
        /// 阻止调用线程处理其他任何请求，直到函数返回
        /// </summary>
        public const uint SMTO_BLOCK = 0x0001;

        /// <summary>
        /// 调用线程等待函数返回时，不被阻止处理其他请求
        /// </summary>
        public const uint SMTO_NORMAL = 0x0000;

        /// <summary>
        /// Windows 95及更高版本：如果接收线程没被挂起，当超时周期结束时不返回
        /// </summary>
        public const uint SMTO_NOTIMEOUTIFNOTHUNG = 0x0008;
    }
}
