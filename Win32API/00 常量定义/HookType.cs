using System;
using System.Runtime.InteropServices;
using Mqd.Win32.DataDef;

namespace Mqd.Win32.API
{
    /// <summary>
    /// 钩子类型
    /// </summary>
    public class HookType
    {
        /// <summary>
        /// 
        /// </summary>
        public const int WH_CALLWNDPROC = 4;

        /// <summary>
        /// 
        /// </summary>
        public const int WH_CALLWNDPROCRET = 12;

        /// <summary>
        /// 
        /// </summary>
        public const int WH_CBT = 5;

        /// <summary>
        /// 
        /// </summary>
        public const int WH_DEBUG = 9;

        /// <summary>
        /// 
        /// </summary>
        public const int WH_FOREGROUNDIDLE = 11;

        /// <summary>
        /// 
        /// </summary>
        public const int WH_GETMESSAGE = 3;

        /// <summary>
        /// 
        /// </summary>
        public const int WH_JOURNALPLAYBACK = 1;

        /// <summary>
        /// 
        /// </summary>
        public const int WH_JOURNALRECORD = 0;

        /// <summary>
        /// 
        /// </summary>
        public const int WH_KEYBOARD = 2;

        /// <summary>
        /// 
        /// </summary>
        public const int WH_KEYBOARD_LL = 13;

        /// <summary>
        /// 
        /// </summary>
        public const int WH_MOUSE = 7;

        /// <summary>
        /// 
        /// </summary>
        public const int WH_MOUSE_LL = 14;

        /// <summary>
        /// 
        /// </summary>
        public const int WH_MSGFILTER = -1;

        /// <summary>
        /// 
        /// </summary>
        public const int WH_SHELL = 10;

        /// <summary>
        /// 
        /// </summary>
        public const int WH_SYSMSGFILTER = 6;
    }
}
