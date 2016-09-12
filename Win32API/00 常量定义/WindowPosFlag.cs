using System;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// WindowPosFlag
    /// </summary>
    public class WindowPosFlag
    {
        /// <summary>
        /// 如果调用进程不拥有窗口，系统会向拥有窗口的线程发出需求
        /// </summary>
        public const uint SWP_ASYNCWINDOWPOS = 0x4000;

        /// <summary>
        /// 防止产生WM_SYNCPAINT消息
        /// </summary>
        public const uint SWP_DEFERERASE = 0x2000;

        /// <summary>
        /// 在窗口周围画一个边框（定义在窗口类描述中）
        /// </summary>
        public const uint SWP_DRAWFRAME = 0x0020;

        /// <summary>
        /// 给窗口发送WM_NCCALCSIZE消息，即使窗口尺寸没有改变也会发送该消息。
        /// 如果未指定这个标志，只有在改变了窗口尺寸时才发送WM_NCCALCSIZE
        /// </summary>
        public const uint SWP_FRAMECHANGED = 0x0020;

        /// <summary>
        /// 隐藏窗口
        /// </summary>
        public const uint SWP_HIDEWINDOW = 0x0080;

        /// <summary>
        /// 不激活窗口。如果未设置标志，则窗口被激活，
        /// 并被设置到其他最高级窗口或非最高级组的顶部（根据参数hWndlnsertAfter设置）
        /// </summary>
        public const uint SWP_NOACTIVATE = 0x0010;

        /// <summary>
        /// 清除客户区的所有内容。如果未设置该标志，客户区的有效内容被保存并且在窗口尺寸更新和重定位后拷贝回客户区
        /// </summary>
        public const uint SWP_NOCOPYBITS = 0x0100;

        /// <summary>
        /// 维持当前位置（忽略X和Y参数）
        /// </summary>
        public const uint SWP_NOMOVE = 0x0002;

        /// <summary>
        /// 不改变z序中的所有者窗口的位置
        /// </summary>
        public const uint SWP_NOOWNERZORDER = 0x0200;

        /// <summary>
        /// 不重画改变的内容
        /// </summary>
        public const uint SWP_NOREDRAW = 0x0008;

        /// <summary>
        /// 与SWP_NOOWNERZORDER标志相同
        /// </summary>
        public const uint SWP_NOREPOSITION = 0x0200;

        /// <summary>
        /// 防止窗口接收WM_WINDOWPOSCHANGING消息
        /// </summary>
        public const uint SWP_NOSENDCHANGING = 0x0400;

        /// <summary>
        /// 维持当前尺寸（忽略cx和Cy参数）
        /// </summary>
        public const uint SWP_NOSIZE = 0x0001;

        /// <summary>
        /// 维持当前Z序（忽略hWndlnsertAfter参数）
        /// </summary>
        public const uint SWP_NOZORDER = 0x0004;

        /// <summary>
        /// 显示窗口
        /// </summary>
        public const uint SWP_SHOWWINDOW = 0x0040;
    }
}
