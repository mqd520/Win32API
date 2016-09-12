using System;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// ClassLongIndex
    /// </summary>
    public class ClassLongIndex
    {
        /// <summary>
        /// 设置与类相关的尺寸的字节大小。设定该值不改变己分配的额外字节数
        /// </summary>
        public const int GCL_CBCLSEXTRA = -20;

        /// <summary>
        /// 设置与类中的每一个窗口相关的尺寸的字节大小。设定该值不改变已分配额外字节数
        /// </summary>
        public const int GCL_CBWNDEXTRA = -18;

        /// <summary>
        /// 替换与类有关的背景刷子的句柄
        /// </summary>
        public const int GCL_HBRBACKGROUND = -10;

        /// <summary>
        /// 替换与类有关的光标的句柄
        /// </summary>
        public const int GCL_HCURSOR = -12;

        /// <summary>
        /// 替换与类有关的图标的句柄
        /// </summary>
        public const int GCL_HICON = -14;

        /// <summary>
        /// 替换注册类的模块的句柄
        /// </summary>
        public const int GCL_HMODULE = -16;

        /// <summary>
        /// 替换窗口类的风格位
        /// </summary>
        public const int GCL_STYLE = -26;

        /// <summary>
        /// 替换菜单名字符串的地址。该字符串标识与类有关的菜单资源
        /// </summary>
        public const int GCL_MENUNAME = -8;

        /// <summary>
        /// 替换与窗口类有关的窗口过程的地址
        /// </summary>
        public const int GCL_WNDPROC = -24;
    }
}
