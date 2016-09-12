using System;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// WindowLongIndex
    /// </summary>
    public class WindowLongIndex
    {
        /// <summary>
        /// 设定一个新的扩展风格
        /// </summary>
        public const int GWL_EXSTYLE = -20;

        /// <summary>
        /// 设置一个新的应用程序实例句柄
        /// </summary>
        public const int GWL_HINSTANCE = -6;

        /// <summary>
        /// 设置一个新的窗口标识符
        /// </summary>
        public const int GWL_ID = -12;

        /// <summary>
        /// 设定一个新的窗口风格
        /// </summary>
        public const int GWL_STYLE = -16;

        /// <summary>
        /// 设置与窗口有关的32位值。每个窗口均有一个由创建该窗口的应用程序使用的32位值。
        /// </summary>
        public const int GWL_USERDATA = -21;

        /// <summary>
        /// 为窗口过程设定一个新的地址
        /// </summary>
        public const int GWL_WNDPROC = -4;

        /// <summary>
        /// 改变子窗口的父窗口,应使用SetParent函数
        /// </summary>
        public const int GWL_HWNDPARENT = -8;

        /// <summary>
        /// 设置对话框过程的新地址
        /// </summary>
        public const int DWL_DLGPROC = 4;

        /// <summary>
        /// 设置在对话框过程中处理的消息的返回值
        /// </summary>
        public const int DWL_MSGRESULT = 0;

        /// <summary>
        /// 设置的应用程序私有的新的额外信息，例如一个句柄或指针
        /// </summary>
        public const int DWL_USER = 8;
    }
}
