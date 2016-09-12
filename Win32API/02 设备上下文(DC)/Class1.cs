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
        /// 判断此点是否在指定矩形区域内
        /// </summary>
        /// <param name="rect">矩形</param>
        /// <param name="p">点</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PtInRect(ref Rect rect, Point p);

        /// <summary>
        /// 指定窗口进行绘图工作的准备，并用将和绘图有关的信息填充到一个PaintStruct结构中
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="ps">PaintStruct数据结构</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr BeginPaint(IntPtr hWnd, ref PaintStruct ps);

        /// <summary>
        /// 指定窗口的绘画过程结束
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="ps">PaintStruct数据结构</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EndPaint(IntPtr hWnd, ref PaintStruct ps);

        /// <summary>
        /// 更新指定窗口的无效矩形区域，使之有效
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="lpRect">无效区域</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ValidateRect(IntPtr hWnd, ref Rect lpRect);

        /// <summary>
        /// 检索指定窗口客户区域或整个屏幕的显示设备上下文环境的句柄
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="hrgnClip">指定一剪切区域</param>
        /// <param name="flags">DCExFlag值之一或组合</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetDCEx(IntPtr hWnd, IntPtr hrgnClip, int flags);
    }
}
