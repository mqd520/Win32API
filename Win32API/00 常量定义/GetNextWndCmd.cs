using System;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// GetWindow参数
    /// </summary>
    public class GetWindowCmd
    {
        /// <summary>
        /// 返回在给定窗口的下面窗口的句柄
        /// </summary>
        public const int GW_HWNDNEXT = 2;

        /// <summary>
        /// 返回在给定窗口的上面窗口的句柄
        /// </summary>
        public const int GW_HWNDPREV = 3;

        /// <summary>
        /// 返回的句柄标识了在Z序最高端的相同类型的窗口。如果指定窗口是最高端窗口，
        /// 则该句柄标识了在Z序最高端的最高端窗口；如果指定窗口是顶层窗口，则该句柄标识了在z序最高端的顶层窗口：
        /// 如果指定窗口是子窗口，则句柄标识了在Z序最高端的同属窗口
        /// </summary>
        public const int GW_HWNDFIRST = 0;

        /// <summary>
        /// 返回的句柄标识了在z序最低端的相同类型的窗口。如果指定窗口是最高端窗口，
        /// 则该柄标识了在z序最低端的最高端窗口：如果指定窗口是顶层窗口，则该句柄标识了在z序最低端的顶层窗口；
        /// 如果指定窗口是子窗口，则句柄标识了在Z序最低端的同属窗口
        /// </summary>
        public const int GW_HWNDLAST = 1;

        /// <summary>
        /// 返回的句柄标识了指定窗口的所有者窗口（如果存在）。GW_OWNER与GW_CHILD不是相对的参数，
        /// 没有父窗口的含义，如果想得到父窗口请使用GetParent()。例如：例如有时对话框的控件的GW_OWNER，是不存在的
        /// </summary>
        public const int GW_OWNER = 4;

        /// <summary>
        /// 如果指定窗口是父窗口，则获得的是在Tab序顶端的子窗口的句柄，否则为NULL。
        /// 函数仅检查指定父窗口的子窗口，不检查继承窗口
        /// </summary>
        public const int GW_CHILD = 5;

        /// <summary>
        /// 返回的句柄标识了属于指定窗口的处于使能状态弹出式窗口（检索使用第一个由GW_HWNDNEXT 查找到的满足前述条件的窗口）；
        /// 如果无使能窗口，则获得的句柄与指定窗口相同
        /// </summary>
        public const int GW_ENABLEDPOPUP = 6;
    }
}
