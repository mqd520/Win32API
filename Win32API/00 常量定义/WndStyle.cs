using System;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// 指定窗口风格
    /// </summary>
    public class WndStyle
    {
        /// <summary>
        /// 创建一个带边框的窗口
        /// </summary>
        public const uint WS_BORDER = 0x00800000;

        /// <summary>
        /// 创建一个有标题框的窗口（包括WS_BORDER风格）
        /// </summary>
        public const uint WS_CAPTION = 0x00C00000;

        /// <summary>
        /// 创建一个子窗口。这个风格不能与WS_POPUP风格合用
        /// </summary>
        public const uint WS_CHILD = 0x40000000;

        /// <summary>
        /// 与WS_CHILD相同
        /// </summary>
        public const uint WS_CHILDWINDOW = WS_CHILD;

        /// <summary>
        /// 当在父窗口内绘图时，排除子窗口区域。在创建父窗口时使用这个风格
        /// </summary>
        public const uint WS_CLIPCHILDREN = 0x02000000;

        /// <summary>
        /// 排除子窗口之间的相对区域，也就是，当一个特定的窗口接收到WM_PAint消息时，
        /// WS_CLIPSIBLINGS 风格将所有层叠窗口排除在绘图之外，只重绘指定的子窗口。
        /// 如果未指定WS_CLIPSIBLINGS风格，并且子窗口是层叠的，则在重绘子窗口的客户区时，就会重绘邻近的子窗口
        /// </summary>
        public const uint WS_CLIPSIBLINGS = 0x04000000;

        /// <summary>
        /// 创建一个初始状态为禁止的子窗口。一个禁止状态的窗口不能接受来自用户的输入信息
        /// </summary>
        public const uint WS_DISABLED = 0x08000000;

        /// <summary>
        /// 创建一个带对话框边框风格的窗口。这种风格的窗口不能带标题条
        /// </summary>
        public const uint WS_DLGFRAME = 0x00400000;

        /// <summary>
        /// 指定一组控制的第一个控制。这个控制组由第一个控制和随后定义的控制组成，
        /// 自第二个控制开始每个控制，具有WS_GROUP风格，每个组的第一个控制带有WS_TABSTOP风格，
        /// 从而使用户可以在组间移动。用户随后可以使用光标在组内的控制间改变键盘焦点
        /// </summary>
        public const uint WS_GROUP = 0x00020000;

        /// <summary>
        /// 创建一个有水平滚动条的窗口
        /// </summary>
        public const uint WS_HSCROLL = 0x00100000;

        /// <summary>
        /// 创建一个初始状态为最小化状态的窗口。与WS_MINIMIZE风格相同
        /// </summary>
        public const uint WS_ICONIC = 0x20000000;

        /// <summary>
        /// 创建一个初始状态为最大化状态的窗口
        /// </summary>
        public const uint WS_MAXIMIZE = 0x01000000;

        /// <summary>
        /// 产生一个层叠的窗口。一个层叠的窗口有一个标题条和一个边框。与WS_TILED风格相同
        /// </summary>
        public const uint WS_OVERLAPPED = 0x00000000;

        /// <summary>
        /// 创建一个具有WS_OVERLAPPED，WS_CAPTION，WS_SYSMENU WS_THICKFRAME，
        /// WS_MINIMIZEBOX，WS_MAXIMIZEBOX风格的层叠窗口，与WS_TILEDWINDOW风格相同
        /// </summary>
        public const uint WS_OVERLAPPEDWINDOW = 0xCF0000;

        /// <summary>
        /// 创建一个弹出式窗口。该风格不能与WS_CHILD风格同时使用
        /// </summary>
        public const uint WS_POPUP = 0x80000000;

        /// <summary>
        /// 创建一个具有WS_BORDER，WS_POPUP,WS_SYSMENU风格的窗口，WS_CAPTION和WS_POPUPWINDOW必须同时设定才能使窗口某单可见
        /// </summary>
        public const uint WS_POPUPWINDOW = 2;

        /// <summary>
        /// 创建一个可调边框的窗口，与WS_THICKFRAME风格相同
        /// </summary>
        public const uint WS_SIZEBOX = 0x00040000;

        /// <summary>
        /// 创建一个在标题条上带有窗口菜单的窗口，必须同时设定WS_CAPTION风格
        /// </summary>
        public const uint WS_SYSMENU = 0x00080000;

        /// <summary>
        /// 创建一个控制，这个控制在用户按下Tab键时可以获得键盘焦点。按下Tab键后使键盘焦点转移到下一具有WS_TABSTOP风格的控制
        /// </summary>
        public const uint WS_TABSTOP = 0x00010000;

        /// <summary>
        /// 创建一个具有可调边框的窗口，与WS_SIZEBOX风格相同
        /// </summary>
        public const uint WS_THICKFRAME = WS_SIZEBOX;

        /// <summary>
        /// 产生一个层叠的窗口。一个层叠的窗口有一个标题和一个边框。与WS_OVERLAPPED风格相同
        /// </summary>
        public const uint WS_TILED = WS_OVERLAPPED;

        /// <summary>
        /// 创建一个具有WS_OVERLAPPED，WS_CAPTION，WS_SYSMENU， WS_THICKFRAME，
        /// WS_MINIMIZEBOX，WS_MAXIMIZEBOX风格的层叠窗口。与WS_OVERLAPPEDWINDOW风格相同
        /// </summary>
        public const uint WS_TILEDWINDOW = 0xCF0000;

        /// <summary>
        /// 创建一个初始状态为可见的窗口
        /// </summary>
        public const uint WS_VISIBLE = 0x10000000;

        /// <summary>
        /// 创建一个有垂直滚动条的窗口
        /// </summary>
        public const uint WS_VSCROLL = 0x00200000;

        /// <summary>
        /// 创建一个具有最大化按钮测窗口
        /// </summary>
        public const uint WS_MINIMIZEBOX = 0x00020000;

        /// <summary>
        /// 创建一个具有最小化按钮测窗口
        /// </summary>
        public const uint WS_MAXIMIZEBOX = 0x00010000;
    }
}
