using System;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// 窗口过程
    /// </summary>
    /// <param name="hwnd">窗口句柄</param>
    /// <param name="uMsg">消息号</param>
    /// <param name="wParam">参数1</param>
    /// <param name="lParam">参数2</param>
    /// <returns></returns>
    public delegate IntPtr WndProc(IntPtr hwnd, uint uMsg, IntPtr wParam, IntPtr lParam);

    /// <summary>
    /// 枚举子窗口函数回调
    /// </summary>
    /// <param name="hwnd">指向在EnumChildWindows中指定的父窗口的子窗口句柄</param>
    /// <param name="lParam">指定在EnumChildWindows函数给出的应用程序定义值</param>
    /// <returns></returns>
    public delegate bool WndEnumProc(IntPtr hwnd, int lParam);

    /// <summary>
    /// EnumThreadWindows函数回调
    /// </summary>
    /// <param name="hwnd">窗口句柄</param>
    /// <param name="lParam">应用程序定义值</param>
    /// <returns></returns>
    public delegate bool EnumThreadWndProc(IntPtr hwnd, int lParam);

    /// <summary>
    /// EnumWindows函数回调
    /// </summary>
    /// <param name="hwnd">窗口句柄</param>
    /// <param name="lParam">应用程序定义值</param>
    /// <returns></returns>
    public delegate bool EnumWindowsProc(IntPtr hwnd, int lParam);

    /// <summary>
    /// SendMessageCallback参数回调函数
    /// </summary>
    /// <param name="hwnd">其窗口程序接收消息的窗口的句柄</param>
    /// <param name="uMsg">指定消息</param>
    /// <param name="dwData">指定从函数SendMessageCallback发送来的应用程序定义的值</param>
    /// <param name="lResult">指定消息处理的结果与消息</param>
    public delegate void SendAsyncProc(IntPtr hwnd, uint uMsg, uint dwData, int lResult);

    /// <summary>
    /// SetWindowsHookEx参数回调函数
    /// </summary>
    /// <param name="code"></param>
    /// <param name="wParam"></param>
    /// <param name="lParam"></param>
    /// <returns></returns>
    public delegate IntPtr HookProc(int code, IntPtr wParam, IntPtr lParam);
}
