using System;

namespace Mqd.Win32.DataDef
{
    /// <summary>
    /// 按钮状态
    /// </summary>
    public class BtnState
    {
        /// <summary>
        /// 设置按钮状态为己选中
        /// </summary>
        public const int BST_CHECKED = 0x0001;

        /// <summary>
        /// 设置按钮状态变灰，表示不确定状态
        /// </summary>
        public const int BST_INDETERMINATE = 0x0002;

        /// <summary>
        /// 设置按钮为未选中状态
        /// </summary>
        public const int BST_UNCHECKED = 0x0000;
    }
}
