using System;
using System.Runtime.InteropServices;
using System.Text;
using Mqd.Win32.DataDef;
using Mqd.Win32.Tool;

namespace Mqd.Win32.API
{
    /// <summary>
    /// Win32API
    /// </summary>
    public partial class Win32API
    {
        /// <summary>
        /// 获得指定窗口所属的类的类名
        /// </summary>
        /// <param name="hwnd">窗口句柄</param>
        /// <param name="lpClassName">字符窜指针</param>
        /// <param name="nMaxCount">字符最大数</param>
        /// <returns>如果函数成功，返回值为拷贝到指定缓冲区的字符个数：如果函数失败，返回值为0</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetClassName(IntPtr hwnd, StringBuilder lpClassName, int nMaxCount);

        /// <summary>
        /// 注册窗口类
        /// </summary>
        /// <param name="lpWndClass">窗口类</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort RegisterClass(ref WndClass lpWndClass);

        /// <summary>
        /// 注册窗口类
        /// </summary>
        /// <param name="lpWndClass">窗口类</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort RegisterClassEx(ref WndClassEx lpWndClass);

        /// <summary>
        /// 该函数获得有关一个窗口类的信息
        /// </summary>
        /// <param name="hlnst">创建该类的应用程序的事例句柄</param>
        /// <param name="lpszClass">指向一个包含类名的空结束的字符串的指针</param>
        /// <param name="lpWndClass">指向一个接收类信息的一个WndClassFromUnmanged结构的指针</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetClassInfo(IntPtr hlnst, string lpszClass, ref WndClassFromUnmanged lpWndClass);

        /// <summary>
        /// 该函数获得有关一个窗口类的信息
        /// </summary>
        /// <param name="hlnst">创建该类的应用程序的事例句柄</param>
        /// <param name="lpszClass">指向一个包含类名的空结束的字符串的指针</param>
        /// <param name="lpWndClass">指向一个接收类信息的一个WndClassExFromUnmanged结构的指针</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetClassInfoEx(IntPtr hlnst, string lpszClass, ref WndClassExFromUnmanged lpWndClass);

        /// <summary>
        /// 返回与指定窗口相关的WNDCLASSEX结构的指定32位值
        /// </summary>
        /// <param name="hWnd">窗口句柄间接给出的窗口所属的类</param>
        /// <param name="nlndex">ClassLongIndex值之一,指定要恢复的32位值</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint GetClassLong(IntPtr hWnd, int nlndex);

        /// <summary>
        /// 该函数替换额外的类存储空间中指定偏移量处的32位长整型值，
        /// 或替换指定窗口所属类的WNDCLASSEX结构(应该是替换这个结构体中值
        /// </summary>
        /// <param name="hWnd">窗口句柄及间接给出的窗口所属的类</param>
        /// <param name="nIndex">指定将被替换的32位值</param>
        /// <param name="dwNewLong">新值</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint SetClassLong(IntPtr hWnd, int nIndex, int dwNewLong);

        /// <summary>
        /// 改变指定窗口的属性．函数也将指定的一个32位值设置在窗口的额外存储空间的指定偏移位置
        /// </summary>
        /// <param name="hWnd">指定将设定的大于等于0的偏移值</param>
        /// <param name="nIndex">WindowLongIndex值之一,给出了要设置的值的零起点的偏移地址</param>
        /// <param name="dwNewLong">指定的替换值</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        /// <summary>
        /// 获得指定窗口的有关信息，函数也获得在额外窗口内存中指定偏移位地址的32位度整型值
        /// </summary>
        /// <param name="hWnd">目标窗口的句柄</param>
        /// <param name="nIndex">WindowLongIndex值之一</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        /// <summary>
        /// 该函数在窗口类的额外存储空间中的指定偏移地址获取指定窗口所属窗口类的16位值
        /// </summary>
        /// <param name="hWnd">窗口句柄及间接给出的窗口所属的类</param>
        /// <param name="nIndex">ClassLongIndex值之一,指定要获得的值的大于等于0字节的偏移量</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort GetClassWord(IntPtr hWnd, int nIndex);
    }
}
