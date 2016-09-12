using System;
using System.Runtime.InteropServices;
using Mqd.Win32.DataDef;

namespace Mqd.Win32.API
{
    /// <summary>
    /// Win32API
    /// </summary>
    public partial class Win32API
    {
        /// <summary>
        /// 该函数将一个消息放入（寄送）到与指定窗口创建的线程相联系消息队列里，不等待线程处理消息就返回
        /// </summary>
        /// <param name="hWnd">其窗口程序接收消息的窗口的句柄</param>
        /// <param name="Msg">指定被寄送的消息</param>
        /// <param name="wParam">指定附加的消息特定的信息</param>
        /// <param name="lParam">指定附加的消息特定的信息</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 该函数将指定的消息发送到一个或多个窗口
        /// </summary>
        /// <param name="hWnd">其窗口程序将接收消息的窗口的句柄</param>
        /// <param name="Msg">指定被发送的消息</param>
        /// <param name="wParam">指定附加的消息特定信息</param>
        /// <param name="lParam">指定附加的消息特定信息</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 该函数将指定的消息发送到一个或多个窗口
        /// </summary>
        /// <param name="hWnd">其窗口程序将接收消息的窗口的句柄</param>
        /// <param name="Msg">指定被发送的消息</param>
        /// <param name="wParam">指定附加的消息特定信息</param>
        /// <param name="lParam">指定附加的消息特定信息</param>
        /// <param name="lpResultCallBack">回调函数</param>
        /// <param name="dwData">一个应用程序定义的值</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SendMessageCallback(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam,
            SendAsyncProc lpResultCallBack, uint dwData);

        /// <summary>
        /// 将指定的消息发送到一个窗口
        /// </summary>
        /// <param name="hWnd">其窗口程序将接收消息的窗口的句柄</param>
        /// <param name="Msg">指定被发送的消息</param>
        /// <param name="wParam">指定附加的消息特定信息</param>
        /// <param name="lParam">指定附加的消息特定信息</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SendNotifyMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 该函数将指定的消息发送到一个或多个窗口
        /// </summary>
        /// <param name="hWnd">其窗口程序将接收消息的窗口的句柄</param>
        /// <param name="Msg">指定被发送的消息</param>
        /// <param name="wParam">指定附加的消息指定信息</param>
        /// <param name="lParam">指定附加的消息指定信息</param>
        /// <param name="fuFlags">FUFlags值之一或组合,指定如何发送消息</param>
        /// <param name="uTimeout">为超时周期指定以毫秒为单位的持续时间</param>
        /// <param name="lpdwResultult">指定消息处理的结果</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SendMessageTimeout(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam, uint fuFlags,
            uint uTimeout, ref uint lpdwResultult);

        /// <summary>
        /// 将一个消息放入（寄送）到指定线程的消息队列里，不等待线程处理消息就返回
        /// </summary>
        /// <param name="idThread">其消息将被寄送的线程的线程标识符</param>
        /// <param name="Msg">指定将被寄送的消息的类型</param>
        /// <param name="wParam">指定附加的消息特定信息</param>
        /// <param name="lParam">指定附加的消息特定信息</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PostThreadMessage(uint idThread, uint Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 获取消息特定附加信息
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetMessageExtraInfo();
    }
}