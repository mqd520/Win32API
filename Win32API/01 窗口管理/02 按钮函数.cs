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
        /// 改变按钮控制的选中状态
        /// </summary>
        /// <param name="hDlg">指向含有该按钮的对话框的句柄</param>
        /// <param name="nIDButton">标识要修改的按钮</param>
        /// <param name="uCheck">BtnState值之一,给定该按钮的选中状态</param>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CheckDlgButton(IntPtr hDlg, int nIDButton, uint uCheck);
    }
}
