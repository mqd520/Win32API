using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mqd.Win32.API;
using Mqd.Win32.DataDef;
using System.Runtime.InteropServices;

namespace Win32API_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            //if (m.Msg == 0x00A)
            //{
            //    Console.WriteLine("0x00A");
            //    //Win32API.DefWindowProc((IntPtr)m.Msg, (uint)m.Msg, (int)m.WParam, (int)m.LParam);
            //    base.WndProc(ref m);
            //}
            //else if (m.Msg == WindowsMsg.WM_CLOSE)
            //{
            //    Console.WriteLine("WM_CLOSE = " + m.Msg);
            //    base.WndProc(ref m);
            //}
            //else
            //{
            //    base.WndProc(ref m);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b = Win32API.ShowWindow((IntPtr)0x00100A2, ShowWindowCmd.SW_SHOW);
            Console.WriteLine(b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WndClass wc = new WndClass();
            wc.style = 0x0001 | 0x0002;
            wc.lpfnWndProc = new WndProc(MyWndProc);
            wc.hInstance = Program.hInstance;
            wc.hbrBackground = (IntPtr)6;
            wc.cbClsExtra = 0;
            wc.cbWndExtra = 0;
            wc.hIcon = IntPtr.Zero;
            wc.hCursor = IntPtr.Zero;
            wc.lpszMenuName = null;
            wc.lpszClassName = "Mqd.WinForm.WndClassName3";
            ushort rc = Win32API.RegisterClass(ref wc);
            if (rc == 0)
            {
                uint n = Win32API.GetLastError();
                Console.WriteLine(n);
            }
            else
            {
                StringBuilder className = new StringBuilder(100);
                Win32API.GetClassName(this.Handle, className, 100);
                IntPtr hwnd = Win32API.CreateWindow(wc.lpszClassName, "WindowName",
                              WndStyle.WS_CAPTION | WndStyle.WS_VISIBLE | WndStyle.WS_BORDER | WndStyle.WS_OVERLAPPED | WndStyle.WS_SYSMENU,
                              10, 10, 500, 350, IntPtr.Zero, IntPtr.Zero, Program.hInstance, IntPtr.Zero);
                if (hwnd == IntPtr.Zero)
                {
                    uint n = Win32API.GetLastError();
                    Console.WriteLine(n);
                }
            }
        }

        private IntPtr MyWndProc(IntPtr hwnd, uint uMsg, IntPtr wParam, IntPtr lParam)
        {
            Console.WriteLine("MyWndProc    hwnd = " + hwnd + "    uMsg = " + uMsg);
            return Win32API.DefWindowProc(hwnd, uMsg, wParam, lParam);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder className = new StringBuilder(100);
            int count = Win32API.GetClassName(this.Handle, className, 100);
            Console.WriteLine(className.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rect rect = new Rect
            {
                left = 50,
                top = 50,
                right = 110,
                bottom = 110
            };
            bool result = Win32API.AdjustWindowRect(ref rect, WndStyle.WS_CAPTION | WndStyle.WS_BORDER | WndStyle.WS_SYSMENU, false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rect rect = new Rect
            {
                left = 50,
                top = 50,
                right = 110,
                bottom = 110
            };
            bool result = Win32API.AdjustWindowRectEx(ref rect, WndStyle.WS_CAPTION | WndStyle.WS_BORDER | WndStyle.WS_SYSMENU, false,
                          WndExStyle.WS_EX_CLIENTEDGE);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool result = Win32API.AnimateWindow(this.Handle, 2000, AnimateWndFlags.AW_BLEND | AnimateWndFlags.AW_HIDE);
            Console.WriteLine(result);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool result = Win32API.CloseWindow((IntPtr)0x00010166);
            Console.WriteLine(result);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool result = Win32API.DestroyWindow((IntPtr)0x00020576);
            Console.WriteLine(result);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Win32API.CloseWindow(button1.Handle);
            Win32API.CloseWindow(button2.Handle);
            Win32API.CloseWindow(button3.Handle);
            System.Threading.Thread.Sleep(3 * 1000);
            uint result = Win32API.ArrangeIconicWindows(this.Handle);
            Console.WriteLine(result);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Win32API.EnableWindow(this.Handle, false);
            //bool b = button1.Enabled;
            //bool result = Win32API.EnableWindow((IntPtr)0x00030768, false);
            //Console.WriteLine(result);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int count = 0;
            WndEnumProc proc = (IntPtr hwnd, int ItParam) =>
            {
                count++;
                Console.WriteLine(hwnd);
                return true;
            };
            bool result = Win32API.EnumChildWindows(this.Handle, proc, (IntPtr)1);
            Console.WriteLine(string.Format("共找到{0}个子窗口", count));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int result = Win32API.FlashWindow(this.Handle, true);
            Console.WriteLine(result);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            EnumThreadWndProc proc = (IntPtr hwnd, int ItParam) =>
            {
                Console.WriteLine(hwnd.ToString() + "  " + ItParam);
                return true;
            };
            bool result = Win32API.EnumThreadWindows(0x000AB0, proc, (IntPtr)1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int count = 0;
            EnumWindowsProc proc = (IntPtr hwnd, int ItParam) =>
            {
                count++;
                Console.WriteLine(hwnd.ToString() + "  " + ItParam);
                return true;
            };
            bool result = Win32API.EnumWindows(proc, (IntPtr)1);
            Console.WriteLine(count);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            IntPtr hwnd = Win32API.FindWindow(null, null);
            Console.WriteLine(hwnd);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            IntPtr hwnd = Win32API.FindWindowEx(this.Handle, IntPtr.Zero, null, null);
            Console.WriteLine(hwnd);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Rect rect = new Rect();
            bool result = Win32API.GetClientRect(this.Handle, ref rect);
            Console.WriteLine(result + "  " + rect.right + "  " + rect.bottom);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            IntPtr hwnd = Win32API.GetDesktopWindow();
            Console.WriteLine(hwnd);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            IntPtr hwnd = Win32API.GetForegroundWindow();
            Console.WriteLine(hwnd);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            IntPtr hwnd = Win32API.GetLastActivePopup(this.Handle);
            Console.WriteLine(hwnd);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            IntPtr hwnd = Win32API.GetWindow(this.Handle, GetWindowCmd.GW_HWNDNEXT);
            Console.WriteLine(hwnd);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            IntPtr hwnd = Win32API.GetParent(button1.Handle);
            Console.WriteLine(hwnd);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            bool result = Win32API.MoveWindow((IntPtr)0x00010162, 400, 400, 1200, 800, true);
            Console.WriteLine(result);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            IntPtr hwnd = Win32API.GetTopWindow(this.Handle);
            Console.WriteLine(hwnd);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            WindowPlacement wp = new WindowPlacement();
            bool result = Win32API.GetWindowPlacement(this.Handle, ref wp);
            Console.WriteLine(result);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Rect rect = new Rect();
            bool result = Win32API.GetWindowRect(this.Handle, ref rect);
            Console.WriteLine(result);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            const int max = 100;
            StringBuilder sb = new StringBuilder(max);
            int count = Win32API.GetWindowText(this.Handle, sb, max);
            Console.WriteLine(sb.ToString() + "   " + count);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            bool result = Win32API.IsChild(this.Handle, button1.Handle);
            Console.WriteLine(result);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int length = Win32API.GetWindowTextLength(this.Handle);
            Console.WriteLine(length);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            uint processID = 0;
            uint threadID = Win32API.GetWindowThreadProcessId(this.Handle, ref processID);
            Console.WriteLine(threadID + "  " + processID);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            bool result = Win32API.IsIconic((IntPtr)0x00050690);
            Console.WriteLine(result);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            bool result = Win32API.IsWindow(this.Handle);
            Console.WriteLine(result);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            bool result = Win32API.IsWindowUnicode(this.Handle);
            Console.WriteLine(result);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            bool result = Win32API.IsWindowVisible(this.Handle);
            Console.WriteLine(result);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            bool result = Win32API.IsZoomed(this.Handle);
            Console.WriteLine(result);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            bool result = Win32API.OpenIcon((IntPtr)0x000704D2);
            Console.WriteLine(result);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            bool result = Win32API.SetForegroundWindow((IntPtr)0x000704D2);
            Console.WriteLine(result);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            IntPtr hwnd = Win32API.SetParent(button1.Handle, Win32API.GetDesktopWindow());
            Console.WriteLine(hwnd + "  " + this.Handle);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            int style = Win32API.GetWindowLong((IntPtr)0x00030350, WindowLongIndex.GWL_STYLE);
            //style &= ~(int)WndStyle.WS_CAPTION;
            style |= (int)WndStyle.WS_BORDER | (int)WndStyle.WS_CAPTION;
            int result = Win32API.SetWindowLong((IntPtr)0x00030350, (int)WindowLongIndex.GWL_STYLE, style);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            int result = Win32API.GetWindowLong((IntPtr)0x000100A2, WindowLongIndex.GWL_STYLE);
            Console.WriteLine(result);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Win32API.SetClassLong(this.Handle, ClassLongIndex.GCL_STYLE, 00000188);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            WindowPlacement data = new WindowPlacement();
            data.length = 44;
            data.showCmd = WndPlacementCmd.SW_SHOWNORMAL;
            data.rcNormalPosition = new Rect
            {
                left = 0,
                top = 0,
                right = 500,
                bottom = 350
            };
            bool result = Win32API.SetWindowPlacement(this.Handle, ref data);
            Console.WriteLine(result);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Win32API.SetWindowPos(this.Handle, IntPtr.Zero, 0, 0, 0, 0, WindowPosFlag.SWP_NOSIZE);
            System.Threading.Thread.Sleep(2 * 1000);
            Win32API.SetWindowPos(this.Handle, IntPtr.Zero, 100, 100, 500, 350, WindowPosFlag.SWP_NOMOVE);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            bool result = Win32API.SetWindowText(this.Handle, "SetWindowText");
            Console.WriteLine(result);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            bool result = Win32API.ShowOwnedPopups(this.Handle, false);
            Console.WriteLine(result);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            bool result = Win32API.ShowWindowAsync((IntPtr)0x0006041E, ShowWindowCmd.SW_HIDE);
            Console.WriteLine(result);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Rect rect = new Rect();
            IntPtr kids = IntPtr.Zero;
            ushort result = Win32API.TileWindows(this.Handle, TileWindowsHow.MDITILE_HORIZONTAL, ref rect, 1, ref kids);
            Console.WriteLine(result);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Mqd.Win32.DataDef.Point p = new Mqd.Win32.DataDef.Point
            {
                x = 667,
                y = 403
            };
            IntPtr result = Win32API.WindowFromPoint(p);
            Console.WriteLine(result);
            Console.WriteLine(this.Handle);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            bool result = Win32API.AnyPopup();
            Console.WriteLine(result);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(100);
            int count = Win32API.GetClassName(this.Handle, sb, 100);
            WndClassExFromUnmanged wc = new WndClassExFromUnmanged();
            bool result = Win32API.GetClassInfoEx(Program.hInstance, sb.ToString(), ref wc);
            Delegate d = Marshal.GetDelegateForFunctionPointer(wc.lpfnWndProc, typeof(WndProc));
            string className = Marshal.PtrToStringAuto(wc.lpszClassName);
            string menuName = Marshal.PtrToStringAuto(wc.lpszMenuName);
            Console.WriteLine(result);
        }

        private unsafe void button51_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(100);
            int count = Win32API.GetClassName(this.Handle, sb, 100);
            WndClassFromUnmanged wc = new WndClassFromUnmanged();
            bool result = Win32API.GetClassInfo(Program.hInstance, sb.ToString(), ref wc);
            Delegate d = Marshal.GetDelegateForFunctionPointer(wc.lpfnWndProc, typeof(WndProc));
            string className = Marshal.PtrToStringAuto(wc.lpszClassName);
            string menuName = Marshal.PtrToStringAuto(wc.lpszMenuName);
            Console.WriteLine(result);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            uint result = Win32API.GetClassLong(this.Handle, ClassLongIndex.GCL_WNDPROC);
            Console.WriteLine(result);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            ushort result = Win32API.GetClassWord(this.Handle, ClassLongIndex.GCL_HICON);
            Console.Write(result);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            WndProc proc = MyWndProc;
            IntPtr result = Win32API.CallWindowProc(proc, this.Handle, WindowsMsg.WM_SIZE, (IntPtr)0, (IntPtr)0);
            Console.WriteLine(result);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            IntPtr result = Win32API.SendMessage(this.Handle, WindowsMsg.WM_DESTROY, (IntPtr)1, (IntPtr)0);
            Console.WriteLine(result);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            SendAsyncProc proc = (IntPtr hwnd, uint msg, uint data, int result) =>
            {
                Console.WriteLine(hwnd + "  " + msg + "  " + data + "  " + result);
            };
            bool result1 = Win32API.SendMessageCallback(this.Handle, WindowsMsg.WM_SIZE, (IntPtr)1, (IntPtr)0, proc, 100);
            Console.WriteLine(result1);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            bool result = Win32API.SendNotifyMessage(this.Handle, WindowsMsg.WM_DESTROY, (IntPtr)1, (IntPtr)0);
            Console.WriteLine(result);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            IntPtr result = Win32API.GetMessageExtraInfo();
            Console.WriteLine(result);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            uint lp = 0;
            IntPtr result = Win32API.SendMessageTimeout(this.Handle, WindowsMsg.WM_SIZE, IntPtr.Zero, IntPtr.Zero,
                FUFlags.SMTO_NORMAL, 1000, ref lp);
            Console.WriteLine(result);
        }

        private void button60_Click(object sender, EventArgs e)
        {

        }

        private void button61_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int ID = Win32API.GetDlgCtrlID(button1.Handle);
            bool result = Win32API.CheckDlgButton(this.Handle, ID, BtnState.BST_INDETERMINATE);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int ID = Win32API.GetDlgCtrlID(btn.Handle);
            Console.WriteLine(ID);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            int result = Win32API.GetSystemMetrics(SysMetericsIndex.SM_CYCAPTION);
            Console.WriteLine(result);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Rect rect = new Rect
            {
                left = btn.Left,
                top = btn.Top,
                bottom = btn.Bottom,
                right = btn.Right
            };
            bool result = Win32API.PtInRect(ref rect, new Mqd.Win32.DataDef.Point
            {
                x = btn.Left + 2,
                y = btn.Top + 2
            });
            Console.WriteLine(result);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            Mqd.Win32.DataDef.Point p = new Mqd.Win32.DataDef.Point();
            Win32API.ClientToScreen(this.Handle, ref p);
            Win32API.ScreenToClient(this.Handle, ref p);

            //int style = Win32API.GetWindowLong(this.Handle, WindowLongIndex.GWL_EXSTYLE);
            //style &= ~(int)WndExStyle.WS_EX_APPWINDOW;
            //Win32API.SetWindowLong(this.Handle,WindowLongIndex.GWL_EXSTYLE,style);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("sdjddjdj");
        }

        private void button66_Click(object sender, EventArgs e)
        {
            bool result = Win32API.EndDialog((IntPtr)0x00020576, (IntPtr)1);
            Console.WriteLine(result);
        }

        private void button67_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2 * 1000);
            Win32API.mouse_event(0x0001 | 0x8000, 1145, 376, 0, IntPtr.Zero);
            System.Threading.Thread.Sleep(1 * 1000);
            Win32API.mouse_event(0x0002 | 0x0004, 0, 0, 0, IntPtr.Zero);
        }
    }
}
