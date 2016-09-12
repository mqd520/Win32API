using System;
using System.Runtime.InteropServices;

namespace Mqd.Win32.API
{
    /// <summary>
    /// Win32API
    /// </summary>
    public partial class Win32API
    {
        /// <summary>
        /// 获取指定控件的ID号
        /// </summary>
        /// <param name="hwndCtl">指定要获取其ID的控件句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetDlgCtrlID(IntPtr hwndCtl);
    }
}
