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
        /// 该函数返回调用线程最近的错误代码值
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint GetLastError();

        /// <summary>
        /// 获取一个应用程序或动态链接库的模块句柄
        /// </summary>
        /// <param name="lpModuleName">指定模块名</param>
        /// <returns></returns>
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long GetModuleHandle(string lpModuleName);

        /// <summary>
        /// 得到被定义的系统数据或者系统配置信息
        /// </summary>
        /// <param name="nIndex">SysMetericsIndex值之一</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetSystemMetrics(int nIndex);

        /// <summary>
        /// 设置钩子
        /// </summary>
        /// <param name="idHook">HookType值之一,钩子类型</param>
        /// <param name="lpfn"></param>
        /// <param name="hMod">实例句柄</param>
        /// <param name="dwThreadId">线程ID</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

        /// <summary>
        /// 释放钩子
        /// </summary>
        /// <param name="hhk">钩子句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);
    }
}
