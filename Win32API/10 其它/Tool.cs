using System;
using Mqd.Win32.DataDef;
using Mqd.Win32.API;

namespace Mqd.Win32.Tool
{
    /// <summary>
    /// Win32Tool
    /// </summary>
    public class Win32Tool
    {
        /// <summary>
        /// 获取当前系统是否为32位系统
        /// </summary>
        public static bool Is32bitSys
        {
            get
            {
                return IntPtr.Size == 4;
            }
        }

        /// <summary>
        /// 获取当前系统是否为64位系统
        /// </summary>
        public static bool Is64bitSys
        {
            get
            {
                return IntPtr.Size == 8;
            }
        }

        /// <summary>
        /// 获取高字节
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns></returns>
        public static int GetHighByte(int data)
        {
            return (data >> 16) & 0xFFFF;
        }

        /// <summary>
        /// 获取低字节
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns></returns>
        public static int GetLowByte(int data)
        {
            return ((data << 16) >> 16) & 0xFFFF;
        }

        /// <summary>
        /// 组合高低字节数据
        /// </summary>
        /// <param name="high">高字节</param>
        /// <param name="low">低字节</param>
        /// <returns></returns>
        public static int CombainHighLowByte(int high, int low)
        {
            return (high << 16) | low;
        }

        /// <summary>
        /// 获取指定窗口句柄的非客户区数据
        /// </summary>
        /// <param name="hwnd">窗口句柄</param>
        /// <returns></returns>
        public static NcClientData GetNcClientData(IntPtr hwnd)
        {
            NcClientData data = new NcClientData();
            if (hwnd != IntPtr.Zero)
            {
                int style = Win32API.GetWindowLong(hwnd, WindowLongIndex.GWL_STYLE);
                if ((style & (int)WndStyle.WS_BORDER) == (int)WndStyle.WS_BORDER)//是否包含边框
                {
                    Rect wndRect = new Rect();
                    Win32API.GetWindowRect(hwnd, ref wndRect);
                    Rect clientRect = new Rect();
                    Win32API.GetClientRect(hwnd, ref clientRect);
                    Point p = new Point();
                    Win32API.ClientToScreen(hwnd, ref p);
                    clientRect.left += p.x;
                    clientRect.right += p.x;
                    clientRect.top += p.y;
                    clientRect.bottom += p.y;
                    data.leftBorderWidth = (clientRect.right - wndRect.left) - (clientRect.right - clientRect.left);
                    data.rightBorderWidth = (wndRect.right - clientRect.left) - (clientRect.right - clientRect.left);
                    data.bottomBorderHeight = (wndRect.bottom - clientRect.top) - (clientRect.bottom - clientRect.top);
                    if ((style & (int)WndStyle.WS_CAPTION) == (int)WndStyle.WS_CAPTION)//是否包含标题栏
                    {
                        data.titleHeight = (clientRect.bottom - wndRect.top) - (clientRect.bottom - clientRect.top);
                    }
                    else
                    {
                        data.topBorderHeight = (clientRect.bottom - wndRect.top) - (clientRect.bottom - clientRect.top);
                    }
                }
            }
            return data;
        }
    }
}
