using System;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// NcHitTestCmd
    /// </summary>
    public class NcHitTestCmd
    {
        /// <summary>
        /// 在屏幕背景或窗口之间的分隔线上（与HTNOWHERE相同，除了Windows的DefWndProc函数产生一个系统响声以指明错误）
        /// </summary>
        public const int HTERROR = -2;

        /// <summary>
        /// 在一个被其它窗口覆盖的窗口中
        /// </summary>
        public const int HTTRANSPARENT = -1;

        /// <summary>
        /// 在屏幕背景或窗口之间的分隔线上
        /// </summary>
        public const int HTNOWHERE = 0;

        /// <summary>
        /// 在客户区中
        /// </summary>
        public const int HTCLIENT = 1;

        /// <summary>
        ///  在标题条中
        /// </summary>
        public const int HTCAPTION = 2;

        /// <summary>
        ///  在控制菜单或子窗口的关闭按钮上
        /// </summary>
        public const int HTSYSMENU = 3;

        /// <summary>
        ///  在尺寸框中
        /// </summary>
        public const int HTGROWBOX = 4;

        /// <summary>
        ///  在尺寸框中
        /// </summary>
        public const int HTSIZE = 4;

        /// <summary>
        ///  在菜单区域
        /// </summary>
        public const int HTMENU = 5;

        /// <summary>
        ///  在水平滚动条上
        /// </summary>
        public const int HTHSCROLL = 6;

        /// <summary>
        ///  在垂直滚动条中
        /// </summary>
        public const int HTVSCROLL = 7;

        /// <summary>
        ///  在最小化按钮上
        /// </summary>
        public const int HTMINBUTTON = 8;

        /// <summary>
        ///  在最大化按钮上
        /// </summary>
        public const int HTMAXBUTTON = 9;

        /// <summary>
        ///  在窗口的左边框上
        /// </summary>
        public const int HTLEFT = 10;

        /// <summary>
        ///  在窗口的右边框上
        /// </summary>
        public const int HTRIGHT = 11;

        /// <summary>
        ///  在窗口水平边框的上方
        /// </summary>
        public const int HTTOP = 12;

        /// <summary>
        ///  在窗口边框的左上角
        /// </summary>
        public const int HTTOPLEFT = 13;

        /// <summary>
        ///  在窗口边框的右上角
        /// </summary>
        public const int HTTOPRIGHT = 14;

        /// <summary>
        ///  在窗口的水平边框的底部
        /// </summary>
        public const int HTBOTTOM = 15;

        /// <summary>
        ///  在窗口边框的左下角
        /// </summary>
        public const int HTBOTTOMLEFT = 16;

        /// <summary>
        ///  在窗口边框的右下角
        /// </summary>
        public const int HTBOTTOMRIGHT = 17;

        /// <summary>
        ///  在不具有可变大小边框的窗口的边框上
        /// </summary>
        public const int HTBORDER = 18;

        /// <summary>
        ///  在最小化按钮上
        /// </summary>
        public const int HTREDUCE = 8;

        /// <summary>
        ///  在最大化按钮上
        /// </summary>
        public const int HTZOOM = 9;

        /// <summary>
        ///  在窗口的左边框上
        /// </summary>
        public const int HTSIZEFIRST = 10;

        /// <summary>
        ///  在窗口边框的右下角
        /// </summary>
        public const int HTSIZELAST = 17;

        /// <summary>
        ///  HTOBJECT            
        /// </summary>
        public const int HTOBJECT = 19;

        /// <summary>
        ///  在关闭按钮上            
        /// </summary>
        public const int HTCLOSE = 20;

        /// <summary>
        ///  帮助            
        /// </summary>
        public const int HTHELP = 21;
    }
}
