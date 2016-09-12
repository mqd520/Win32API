using System;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// SysCmd
    /// </summary>
    public class SysCmd
    {
        /// <summary>
        /// 改变窗口大小
        /// </summary>
        public const int SC_SIZE = 0xF000;

        /// <summary>
        /// 移动窗口
        /// </summary>
        public const int SC_MOVE = 0xF010;

        /// <summary>
        /// 最小化窗口
        /// </summary>
        public const int SC_MINIMIZE = 0xF020;

        /// <summary>
        /// 最大化窗口
        /// </summary>
        public const int SC_MAXIMIZE = 0xF030;

        /// <summary>
        /// 移到下一个窗口
        /// </summary>
        public const int SC_NEXTWINDOW = 0xF040;

        /// <summary>
        /// 移到前一个窗口
        /// </summary>
        public const int SC_PREVWINDOW = 0xF050;

        /// <summary>
        /// 关闭窗口
        /// </summary>
        public const int SC_CLOSE = 0xF060;

        /// <summary>
        /// 垂直滚动
        /// </summary>
        public const int SC_VSCROLL = 0xF070;

        /// <summary>
        /// 水平滚动
        /// </summary>
        public const int SC_HSCROLL = 0xF080;

        /// <summary>
        /// 鼠标单击返回窗口菜单
        /// </summary>
        public const int SC_MOUSEMENU = 0xF090;

        /// <summary>
        /// 键盘的敲击返回窗口菜单
        /// </summary>
        public const int SC_KEYMENU = 0xF100;

        /// <summary>
        /// SC_ARRANGE
        /// </summary>
        public const int SC_ARRANGE = 0xF110;

        /// <summary>
        /// 将窗口复原到原始的位置和大小
        /// </summary>
        public const int SC_RESTORE = 0xF120;

        /// <summary>
        /// 激活【开始】菜单
        /// </summary>
        public const int SC_TASKLIST = 0xF130;

        /// <summary>
        /// 执行System.ini文件里[boot]部分指定的屏幕保护程序
        /// </summary>
        public const int SC_SCREENSAVE = 0xF140;

        /// <summary>
        /// 以应用程序指定的热键激活窗口。lParam参数标识了所要激活的窗口
        /// </summary>
        public const int SC_HOTKEY = 0xF150;

        /// <summary>
        /// 当用户双击窗口菜单时，选择默认的条目
        /// </summary>
        public const int SC_DEFAULT = 0xF160;

        /// <summary>
        /// SCMonitorPowerCmd值之一,设置显示状态。该命令支持具有节电特性的设备，如电池供电的个人电脑
        /// </summary>
        public const int SC_MONITORPOWER = 0xF170;

        /// <summary>
        /// 用指针将光标更改为问号。如果用户点击一个控件在对话框中的控件接收到wm_help消息
        /// </summary>
        public const int SC_CONTEXTHELP = 0xF180;

        /// <summary>
        /// SC_SEPARATOR
        /// </summary>
        public const int SC_SEPARATOR = 0xF00F;

        /// <summary>
        /// 指示是否屏幕保护程序是安全的
        /// </summary>
        public const int SCF_ISSECURE = 0x00000001;
    }
}
