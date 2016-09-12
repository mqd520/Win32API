using System;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// DCExFlag
    /// </summary>
    public class DCExFlag
    {
        /// <summary>
        /// 返回与窗口矩形而不是与客户矩形相对应的设备上下文环境
        /// </summary>
        public const int DCX_WINDOW = 0x00000001;

        /// <summary>
        /// 从高速缓存而不是从OWNDC或CLASSDC窗口中返回设备上下文环境
        /// </summary>
        public const int DCX_CACHE = 0x00000002;

        /// <summary>
        /// 使用父窗口的可见区域，父窗口的WS_CIPCHILDREN和CS_PARENTDC风格被忽略，
        /// 并把设备上下文环境的原点，设在由hWnd所标识的窗口的左上角
        /// </summary>
        public const int DCX_PARENTCLIP = 0x00000020;

        /// <summary>
        /// 排除hWnd参数所标识窗口上的所有兄弟窗口的可见区域
        /// </summary>
        public const int DCX_CLIPSIBLINGS = 0x00000010;

        /// <summary>
        /// 排除hWnd参数所标识窗口上的所有子窗口的可见区域
        /// </summary>
        public const int DCX_CLIPCHILDREN = 0x00000008;

        /// <summary>
        /// 当设备上下文环境被释放时，并不重置该设备上下文环境的特性为缺省特性
        /// </summary>
        public const int DCX_NORESETATTRS = 0x00000004;

        /// <summary>
        /// 即使在排除指定窗口的LockWindowUpdate函数调用有效的情况下也许会绘制，该参数用于在跟踪期间进行绘制
        /// </summary>
        public const int DCX_LOCKWINDOWUPDATE = 0x00000400;

        /// <summary>
        /// 从返回设备上下文环境的可见区域中排除由hrgnClip指定的剪切区域
        /// </summary>
        public const int DCX_EXCLUDERGN = 0x00000040;

        /// <summary>
        /// 对hrgnClip指定的剪切区域与返回设备描述的可见区域作交运算
        /// </summary>
        public const int DCX_INTERSECTRGN = 0x00000080;

        /// <summary>
        /// 当与DCX_INTERSECTUPDATE一起指定时，致使设备上下文环境完全有效，
        /// 该函数与DCX_INTERSECTUPDATE和DCX_VALIDATE一起使用时与使用BeginPaint函数相同
        /// </summary>
        public const int DCX_VALIDATE = 0x00200000;
    }
}
