using System;
using System.Runtime.InteropServices;
using System.Text;
using Mqd.Win32.DataDef;

namespace Mqd.Win32.API
{
    /// <summary>
    /// Win32API
    /// </summary>
    public partial class Win32API
    {
        #region 窗口创建和销毁
        /// <summary>
        /// 创建窗口
        /// </summary>
        /// <param name="dwExStyle">窗口扩展风格</param>
        /// <param name="lpClassName">窗口类名</param>
        /// <param name="lpWindowName">窗口标题</param>
        /// <param name="dwStyle">窗口样式</param>
        /// <param name="x">X坐标</param>
        /// <param name="y">Y坐标</param>
        /// <param name="nWidth">宽度</param>
        /// <param name="nHeight">高度</param>
        /// <param name="hWndParent">父窗口句柄</param>
        /// <param name="hMenu">菜单句柄</param>
        /// <param name="hInstance">模块实例句柄</param>
        /// <param name="lpParam">附加数据指针</param>
        /// <returns>如果函数成功，返回值为新窗口的句柄：如果函数失败，返回值为NULL</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CreateWindowEx(uint dwExStyle, string lpClassName, string lpWindowName, uint dwStyle,
            int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);

        /// <summary>
        /// 创建窗口
        /// </summary>
        /// <param name="lpClassName">窗口类名</param>
        /// <param name="lpWindowName">窗口标题</param>
        /// <param name="dwStyle">窗口样式</param>
        /// <param name="x">X坐标</param>
        /// <param name="y">Y坐标</param>
        /// <param name="nWidth">宽度</param>
        /// <param name="nHeight">高度</param>
        /// <param name="hWndParent">父窗口句柄</param>
        /// <param name="hMenu">菜单句柄</param>
        /// <param name="hInstance">模块实例句柄</param>
        /// <param name="lpParam">附加数据指针</param>
        /// <returns>如果函数成功，返回值为新窗口的句柄：如果函数失败，返回值为NULL</returns>
        public static IntPtr CreateWindow(string lpClassName, string lpWindowName, uint dwStyle,
            int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam)
        {
            return Win32API.CreateWindowEx(0, lpClassName, lpWindowName, dwStyle, x, y, nWidth, nHeight, hWndParent, hMenu, hInstance, lpParam);
        }

        /// <summary>
        /// 该函数最小化指定的窗口，但并不销毁该窗口
        /// </summary>
        /// <param name="hWnd">将要最小化的窗口的句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CloseWindow(IntPtr hWnd);

        /// <summary>
        /// 销毁指定的窗口。这个函数通过发送WM_DESTROY 消息和 WM_NCDESTROY 消息使窗口无效并移除其键盘焦点。
        /// 这个函数还销毁窗口的菜单，清空线程的消息队列，销毁与窗口过程相关的定时器，解除窗口对剪贴板的拥有权，
        /// 打断剪贴板器的查看链
        /// </summary>
        /// <param name="hWnd">将被销毁的窗口的句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DestroyWindow(IntPtr hWnd);

        /// <summary>
        /// 摧毁一个模态窗口
        /// </summary>
        /// <param name="hDlg">窗口句柄</param>
        /// <param name="nResult">关闭原因</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EndDialog(IntPtr hDlg, IntPtr nResult);
        #endregion

        #region 窗口显示
        /// <summary>
        /// 设置指定窗口的显示状态
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="nCmdShow">指定窗口如何显示,ShowWindowDef常量之一</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        /// <summary>
        /// 设置由不同线程产生的窗口的显示状态
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="nCmdShow">指定窗口如何显示,ShowWindowDef常量之一</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        /// <summary>
        /// 更新指定窗口的客户区
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <returns>如果函数调用成功，返回值为非零值</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UpdateWindow(IntPtr hWnd);
        #endregion

        #region 计算窗口区域
        /// <summary>
        /// 该函数依据所需客户矩形的大小，计算需要的窗日矩形的大小。
        /// 计算出的窗口矩形随后可以传递给CreateWindow函数，用于创建一个客户区所需大小的窗口
        /// </summary>
        /// <param name="lpRect">矩形区域</param>
        /// <param name="dwStyle">窗口样式</param>
        /// <param name="bMenu">指示窗口是否有菜单</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AdjustWindowRect(ref Rect lpRect, uint dwStyle, bool bMenu);

        /// <summary>
        /// 该函数依据所需客户矩形的大小，计算需要的窗日矩形的大小。
        /// 计算出的窗口矩形随后可以传递给CreateWindow函数，用于创建一个客户区所需大小的窗口
        /// </summary>
        /// <param name="lpRect">矩形区域</param>
        /// <param name="dwStyle">窗口样式</param>
        /// <param name="bMenu">指示窗口是否有菜单</param>
        /// <param name="dwExStyle">窗口扩展样式</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AdjustWindowRectEx(ref Rect lpRect, uint dwStyle, bool bMenu, uint dwExStyle);
        #endregion

        #region 窗口位置、大小、移动
        /// <summary>
        /// 获取窗口客户区的句柄
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="lpRect">客户区矩形</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetClientRect(IntPtr hWnd, ref Rect lpRect);

        /// <summary>
        /// 改变指定窗口的位置和大小
        /// </summary>
        /// <param name="hWnd">指定窗口的句柄</param>
        /// <param name="x">X坐标</param>
        /// <param name="y">Y坐标</param>
        /// <param name="nWidth">宽度</param>
        /// <param name="nHeight">高度</param>
        /// <param name="bRepaint">是否重绘</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int x, int y, int nWidth, int nHeight, bool bRepaint);

        /// <summary>
        /// 该函数返回指定窗口的边框矩形的尺寸
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="lpRect">指向一个RECT结构的指针</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetWindowRect(IntPtr hWnd, ref Rect lpRect);
        #endregion

        #region 窗口属性
        /// <summary>
        /// 返回指定窗口的显示状态以及被恢复的、最大化的和最小化的窗口位置
        /// </summary>
        /// <param name="hWnd">窗口句柄存贮显示状态和位置信息</param>
        /// <param name="lpwndpl"></param>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetWindowPlacement(IntPtr hWnd, ref WindowPlacement lpwndpl);

        /// <summary>
        /// 设置指定窗口的显示状态和恢复，最大化，最小化位置
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="lpwndpl">指向一个WINDOWPLACEMWNT结构的指针，该结构给出了新的显示状态和窗口位置</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowPlacement(IntPtr hWnd, ref WindowPlacement lpwndpl);

        /// <summary>
        /// 该函数将指定窗口的标题条文本（如果存在）拷贝到一个缓存区内
        /// </summary>
        /// <param name="hWnd">带文本的窗口或控制的句柄</param>
        /// <param name="lpString">指向接收文本的缓冲区的指针</param>
        /// <param name="nMaxCount">定要保存在缓冲区内的字符的最大个数，其中包含NULL字符</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        /// <summary>
        /// 该函数改变指定窗口的标题栏的文本内容（如果窗口有标题栏）
        /// </summary>
        /// <param name="hwnd">要改变文本内容的窗口或控制的句柄</param>
        /// <param name="lpString">指向一个空结束的字符串的指针</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowText(IntPtr hwnd, string lpString);

        /// <summary>
        /// 该函数返回指定窗口的标题文本（如果存在）的字符长度
        /// </summary>
        /// <param name="hWnd">窗口或控制的句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        /// <summary>
        /// 函数改变一个子窗口，弹出式窗口或顶层窗口的尺寸，位置和Z序
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="hWndlnsertAfter">WindowPosCmd值之一</param>
        /// <param name="x">以客户坐标指定窗口新位置的左边界</param>
        /// <param name="y">以客户坐标指定窗口新位置的顶边界</param>
        /// <param name="cx">以像素指定窗口的新的宽度</param>
        /// <param name="cy">以像素指定窗口的新的高度</param>
        /// <param name="uFlags">WindowPosFlag值之一或组合</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndlnsertAfter, int x, int y, int cx, int cy, uint uFlags);
        #endregion

        #region 查找窗口
        /// <summary>
        /// 该函数返回桌面窗口的句柄
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();

        /// <summary>
        /// 该函数是由应用程序定义的，与函数EnumChildWindows一起使用的回调函数。
        /// 它接收子窗口句柄。类型WNDENUMPROC定义了一个指向回调函数的指针。EnumChildProc是一个应用程序定义的函数名的位置标志符
        /// </summary>
        /// <param name="hwnd">指向在EnumChildWindows中指定的父窗口的子窗口句柄</param>
        /// <param name="lParam">指定在EnumChildWindows函数给出的应用程序定义值</param>
        /// <returns>为继续枚举，回调函数必须返回TRUE；为停止枚举，回调函数必须返回FALSE</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumChildProc(IntPtr hwnd, IntPtr lParam);


        /// <summary>
        /// 枚举一个父窗口的所有子窗口
        /// </summary>
        /// <param name="hWndParent">父窗口句柄</param>
        /// <param name="lpEnumFunc">WndEnumProc</param>
        /// <param name="lParam">自定义的参数</param>
        /// <returns>回调函数的返回值将会影响到这个API函数的行为。如果回调函数返回true，
        /// 则枚举继续直到枚举完成；如果返回false，则将会中止枚举。</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumChildWindows(IntPtr hWndParent, WndEnumProc lpEnumFunc, IntPtr lParam);

        /// <summary>
        /// 枚举所有与一个线程相关联的非子窗口
        /// </summary>
        /// <param name="dwThreadId">标识将被列举窗口的线程</param>
        /// <param name="lpfn">EnumThreadWndProc</param>
        /// <param name="lParam">指定一个传递给回调函数的应用程序定义值</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumThreadWindows(uint dwThreadId, EnumThreadWndProc lpfn, IntPtr lParam);

        /// <summary>
        /// 该函数枚举所有屏幕上的顶层窗口
        /// </summary>
        /// <param name="lpEnumFunc">EnumWindowsProc</param>
        /// <param name="lParam">指定一个传递给回调函数的应用程序定义值</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        /// <summary>
        /// 检索处理顶级窗口的类名和窗口名称匹配指定的字符串。这个函数不搜索子窗口
        /// </summary>
        /// <param name="lpClassName">窗口类名</param>
        /// <param name="lpWindowName">窗口标题</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// 在窗口列表中寻找与指定条件相符的第一个子窗口
        /// </summary>
        /// <param name="hWndParent">要查找的子窗口所在的父窗口的句柄,如果hwndParent为 0,
        /// 则函数以桌面窗口为父窗口，查找桌面窗口的所有子窗口</param>
        /// <param name="hWndChildAfter">子窗口句柄。查找从在Z序中的下一个子窗口开始。
        /// 子窗口必须为hwndParent窗口的直接子窗口而非后代窗口。如果HwndChildAfter为NULL，
        /// 查找从hwndParent的第一个子窗口开始。如果hwndParent 和 hwndChildAfter同时为NULL，
        /// 则函数查找所有的顶层窗口及消息窗口</param>
        /// <param name="lpszClass">窗口类名</param>
        /// <param name="lpszWindow">窗口标题</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr hWndParent, IntPtr hWndChildAfter, string lpszClass, string lpszWindow);

        /// <summary>
        /// 获取一个前台窗口的句柄
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetForegroundWindow();

        /// <summary>
        /// 函数确定指定窗口中的哪一个弹出式窗口是最近活动的窗口
        /// </summary>
        /// <param name="hWnd">所有者窗口句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetLastActivePopup(IntPtr hWnd);

        /// <summary>
        /// 该函数返回与指定窗口有特定关系（如Z序或所有者）的窗口句柄
        /// </summary>
        /// <param name="hWnd">窗口的句柄</param>
        /// <param name="wCmd">说明指定窗口与要获得句柄的窗口之间的关系,GetWindowCmd值之一</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetWindow(IntPtr hWnd, uint wCmd);

        /// <summary>
        /// 该函数返回与指定窗口有特定关系（如Z序或所有者）的窗口句柄
        /// </summary>
        /// <param name="hWnd">窗口的句柄</param>
        /// <param name="wCmd">说明指定窗口与要获得句柄的窗口之间的关系,GetWindowCmd值之一</param>
        /// <returns></returns>
        public static IntPtr GetNextWindow(IntPtr hWnd, uint wCmd)
        {
            return GetWindow(hWnd, wCmd);
        }

        /// <summary>
        /// 该函数获得一个指定子窗口的父窗口句柄
        /// </summary>
        /// <param name="hWnd">子窗口句柄，函数要获得该子窗口的父窗口句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetParent(IntPtr hWnd);

        /// <summary>
        /// 检查与特定父窗口相联的子窗口z序，并返回在z序顶部的子窗口的句柄
        /// </summary>
        /// <param name="hWnd">被查序的父窗口的句柄。如果该参数为NULL，函数返回Z序顶部的窗口句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetTopWindow(IntPtr hWnd);

        /// <summary>
        /// 获得包含指定点的窗口的句柄
        /// </summary>
        /// <param name="point">指定一个被检测的点的POINT结构</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr WindowFromPoint(Point point);

        /// <summary>
        /// 该函数指出一个被属窗口，可见窗口，顶级弹出窗口，或层叠窗口是否在屏幕上存在。
        /// 这个函数搜索整个屏幕，而不仅仅搜索应用程序的客户区
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AnyPopup();
        #endregion

        #region 其它
        /// <summary>
        /// 该函数允许或禁止指定的窗口或控制接受鼠标输入或键盘输入。
        /// 当输入被禁止时窗口不能接收鼠标单击和按键等类输入；当输入允许时，窗口接受所有的输入
        /// </summary>
        /// <param name="hWnd">允许或禁止的窗口句柄</param>
        /// <param name="bEndble">指定是允许还是禁止窗口。如果这个参数为TRUE，窗口允许；如果参数为FALSE，则窗口被禁止</param>
        /// <returns>果窗口此前曾被禁止，则返回值为非零；如果窗口此前未被禁止，则返回值为零</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnableWindow(IntPtr hWnd, bool bEndble);

        /// <summary>
        /// 该函数能在显示与隐藏窗口时能产生特殊的效果。有两种类型的动画效果：滚动动画和滑动动画
        /// </summary>
        /// <param name="hWnd">指定产生动画的窗口的句柄</param>
        /// <param name="dwTime">指明动画持续的时间（以微秒计），完成一个动画的标准时间为200微秒</param>
        /// <param name="dwFlags">指定动画类型,这个参数可以是AnimateWndFlags一个或多个志的组合</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AnimateWindow(IntPtr hWnd, uint dwTime, uint dwFlags);

        /// <summary>
        /// 安排指定父窗口的各个最小化（图标化）子窗口
        /// </summary>
        /// <param name="hWnd">父窗口句柄</param>
        /// <returns>如果函数成功，返回值为一行图标的高度。如果函数失败，返回值为零</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint ArrangeIconicWindows(IntPtr hWnd);

        /// <summary>
        /// 该函数为一个多窗口位置结构分配内存并且返回该结构的句柄
        /// </summary>
        /// <param name="nNumWindows">指示存储位置信息的初始窗口数目。如有必要，DeferWindowPos函数可以增加该结构的大小</param>
        /// <returns>如果函数成功，返回多窗口位置结构。如果分配内存时内存不足，则返回值为NULL</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr BeginDeferWindowPos(int nNumWindows);

        /// <summary>
        /// 闪烁显示指定窗口
        /// </summary>
        /// <param name="hwnd">要闪烁显示的窗口的句柄</param>
        /// <param name="bInvert">TRUE（非零）表示切换窗口标题；FALSE返回最初状态</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashWindow(IntPtr hwnd, bool bInvert);

        /// <summary>
        /// 该函数测试一个窗口是否是指定父窗口的子窗口或后代窗口
        /// </summary>
        /// <param name="hWndParant">父窗口句柄</param>
        /// <param name="hWnd">将被测试的窗口句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsChild(IntPtr hWndParant, IntPtr hWnd);

        /// <summary>
        /// 该函数返回创建指定窗口线程的标识和创建窗口的进程的标识符
        /// </summary>
        /// <param name="hwnd">窗口句柄</param>
        /// <param name="lpdwProcessld">接收进程标识的32位值的地址</param>
        /// <returns>返回值为创建窗口的线程标识</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hwnd, ref uint lpdwProcessld);

        /// <summary>
        /// 该函数确定给定窗口是否是最小化（图标化）的窗口
        /// </summary>
        /// <param name="hWnd">被测试窗口的句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsIconic(IntPtr hWnd);

        /// <summary>
        /// 该函数确定给定的窗口句柄是否标识一个已存在的窗口
        /// </summary>
        /// <param name="hWnd">被测试窗口的句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsWindow(IntPtr hWnd);

        /// <summary>
        /// 该函数确定指定的窗口是否是一个本地Unicode窗口
        /// </summary>
        /// <param name="hWnd">被测试窗口的句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsWindowUnicode(IntPtr hWnd);

        /// <summary>
        /// 获得指定窗口的可视状态，即显示或者隐藏
        /// </summary>
        /// <param name="hWnd">被测试窗口的句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        /// <summary>
        /// 该函数确定窗口是否是最大化的窗口
        /// </summary>
        /// <param name="hWnd">被测试窗口的句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsZoomed(IntPtr hWnd);

        /// <summary>
        /// 将一个最小化窗口恢复到原来的位置和尺寸并且激活该窗口
        /// </summary>
        /// <param name="hWnd">被恢复与激活的窗口的句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool OpenIcon(IntPtr hWnd);

        /// <summary>
        /// 该函数将创建指定窗口的线程设置到前台，并且激活该窗口
        /// </summary>
        /// <param name="hWnd">将被激活并被调入前台的窗口句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// 该函数改变指定子窗口的父窗口
        /// </summary>
        /// <param name="hWndChild">子窗口句柄</param>
        /// <param name="hWndNewParent">新的父窗口句柄</param>
        /// <returns>如果函数成功，返回值为子窗口的原父窗口句柄；如果函数失败，返回值为NULL</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        /// <summary>
        /// 显示或隐藏属于指定窗口的所有弹出式窗口
        /// </summary>
        /// <param name="hWnd">拥有弹出式窗口的窗口句柄</param>
        /// <param name="fshow">指明弹出式窗口是被显示还是隐藏</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShowOwnedPopups(IntPtr hWnd, bool fshow);

        /// <summary>
        /// 显示指定父窗口的各指定子窗口
        /// </summary>
        /// <param name="hWndParent">窗口句柄。如果该参数为NULL，则假定为桌面窗口</param>
        /// <param name="wHow"></param>
        /// <param name="lpRect"></param>
        /// <param name="cKidS">指出在lpKidS参数中给出的数组的成员个数。如果lpKids为NULL则该参数被忽略</param>
        /// <param name="lpKidS"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort TileWindows(IntPtr hWndParent, uint wHow, ref Rect lpRect, uint cKidS, ref IntPtr lpKidS);
        #endregion

        /// <summary>
        /// GetWindowDC
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        /// <summary>
        /// 释放DC
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="hDc">HDC</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDc);

        /// <summary>
        /// 设置窗口的区域
        /// </summary>
        /// <param name="hRgn">区域句柄</param>
        /// <param name="bRedraw">是否重绘</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SetWindowRgn(IntPtr hRgn, bool bRedraw);
    }
}
