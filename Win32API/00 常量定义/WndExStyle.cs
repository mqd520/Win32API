using System;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// 窗口扩展样式
    /// </summary>
    public class WndExStyle
    {
        /// <summary>
        /// 防止窗口被移动
        /// </summary>
        public const uint WS_EX_NODRAG = 0x40000000;

        /// <summary>
        /// 指定以该风格创建的窗口接受一个拖拽文件
        /// </summary>
        public const uint WS_EX_ACCEPTFILES = 0x00000010;

        /// <summary>
        /// 当窗口可见时，将一个顶层窗口放置到任务条上
        /// </summary>
        public const uint WS_EX_APPWINDOW = 0x00040000;

        /// <summary>
        /// 指定窗口有一个带阴影的边界
        /// </summary>
        public const uint WS_EX_CLIENTEDGE = 0x00000200;

        /// <summary>
        /// 在窗口的标题条包含一个问号标志。当用户点击了问号时，鼠标光标变为一个问号的指针、
        /// 如果点击了一个子窗口，则子窗口接收到WM_HELP消息。子窗口应该将这个消息传递给父窗口过程，
        /// 父窗口再通过HELP_WM_HELP命令调用WinHelp函数。这个Help应用程序显示一个包含子窗口帮助信息的弹出式窗口。 
        /// WS_EX_CONTEXTHELP不能与WS_MAXIMIZEBOX和WS_MINIMIZEBOX同时使用
        /// </summary>
        public const uint WS_EX_CONTEXTHELP = 0x00000400;

        /// <summary>
        /// 允许用户使用Tab键在窗口的子窗口间搜索
        /// </summary>
        public const uint WS_EX_CONTROLPARENT = 0x00010000;

        /// <summary>
        /// 创建一个带双边的窗口；该窗口可以在dwStyle中指定WS_CAPTION风格来创建一个标题栏
        /// </summary>
        public const uint WS_EX_DLGMODALFRAME = 0x00000001;

        /// <summary>
        /// 创建一个分层窗口
        /// </summary>
        public const uint WS_EX_LAYERED = 0x00080000;

        /// <summary>
        /// 窗口具有左对齐属性，这是缺省设置的
        /// </summary>
        public const uint WS_EX_LEFT = 0x00000000;

        /// <summary>
        /// 如果外壳语言是如Hebrew，Arabic，或其他支持reading order alignment的语言，
        /// 则标题条（如果存在）则在客户区的左部分。若是其他语言，在该风格被忽略并且不作为错误处理
        /// </summary>
        public const uint WS_EX_LEFTSCROLLBAR = 0x00004000;

        /// <summary>
        /// 窗口文本以LEFT到RIGHT（自左向右）属性的顺序显示。这是缺省设置的
        /// </summary>
        public const uint WS_EX_LTRREADING = 0x00000000;

        /// <summary>
        /// 创建一个MDI子窗口
        /// </summary>
        public const uint WS_EX_MDICHILD = 0x00000040;

        /// <summary>
        /// 指明以这个风格创建的窗口在被创建和销毁时不向父窗口发送WM_PARENTNOTFY消息
        /// </summary>
        public const uint WS_EX_NOPATARENTNOTIFY = 0;

        /// <summary>
        /// WS_EX_CLIENTEDGE和WS_EX_WINDOWEDGE的组合
        /// </summary>
        public const uint WS_EX_OVERLAPPEDWINDOW = 0x00000300;

        /// <summary>
        /// WS_EX_WINDOWEDGE, WS_EX_TOOLWINDOW和WS_WX_TOPMOST风格的组合
        /// </summary>
        public const uint WS_EX_PALETTEWINDOW = 0x00000188;

        /// <summary>
        /// 窗口具有普通的右对齐属性，这依赖于窗口类。只有在外壳语言是如Hebrew,
        /// Arabic或其他支持读顺序对齐（reading order alignment）的语言时该风格才有效，否则，忽略该标志并且不作为错误处理
        /// </summary>
        public const uint WS_EX_RIGHT = 0x00001000;

        /// <summary>
        /// 垂直滚动条在窗口的右边界。这是缺省设置的
        /// </summary>
        public const uint WS_EX_RIGHTSCROLLBAR = 0x00000000;

        /// <summary>
        /// 如果外壳语言是如Hebrew，Arabic，或其他支持读顺序对齐（reading order alignment）的语言，
        /// 则窗口文本是一自左向右）RIGHT到LEFT顺序的读出顺序。若是其他语言，在该风格被忽略并且不作为错误处理
        /// </summary>
        public const uint WS_EX_RTLREADING = 0x00002000;

        /// <summary>
        /// 为不接受用户输入的项创建一个3一维边界风格
        /// </summary>
        public const uint WS_EX_STATICEDGE = 0x00020000;

        /// <summary>
        /// 创建工具窗口，即窗口是一个游动的工具条。工具窗口的标题条比一般窗口的标题条短，
        /// 并且窗口标题以小字体显示。工具窗口不在任务栏里显示，当用户按下alt+Tab键时工具窗口不在对话框里显示。
        /// 如果工具窗口有一个系统菜单，它的图标也不会显示在标题栏里，但是，可以通过点击鼠标右键或Alt+Space来显示菜单
        /// </summary>
        public const uint WS_EX_TOOLWINDOW = 0x00000080;

        /// <summary>
        /// 指明以该风格创建的窗口应放置在所有非最高层窗口的上面并且停留在其L，
        /// 即使窗口未被激活。使用函数SetWindowPos来设置和移去这个风格
        /// </summary>
        public const uint WS_EX_TOPMOST = 0x00000008;

        /// <summary>
        /// 指定以这个风格创建的窗口在窗口下的同属窗口已重画时，该窗口才可以重画。
        /// 由于其下的同属窗口已被重画，该窗口是透明的
        /// </summary>
        public const uint WS_EX_TRANSPARENT = 0x00000020;
    }
}
