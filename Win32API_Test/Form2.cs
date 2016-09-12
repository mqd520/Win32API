using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using Mqd.Win32.API;
using Mqd.Win32.Tool;
using Mqd.Win32.DataDef;
using System.Drawing.Drawing2D;
using Point = Mqd.Win32.DataDef.Point;

namespace Win32API_Test
{
    public partial class Form2 : Form
    {
        private IntPtr _hMouseHook = IntPtr.Zero;

        public Form2()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == (int)WindowsMsg.WM_NCLBUTTONDOWN)
            {
                int y = Win32Tool.GetHighByte((int)m.LParam);
                int x = Win32Tool.GetLowByte((int)m.LParam);
                Console.WriteLine("WM_NCLBUTTONDOWN = " + m.Msg + ", x = " + x + " y = " + y);
                //return;
            }
            else if (m.Msg == (int)WindowsMsg.WM_NCLBUTTONUP)
            {
                int y = Win32Tool.GetHighByte((int)m.LParam);
                int x = Win32Tool.GetLowByte((int)m.LParam);
                Console.WriteLine("WM_NCLBUTTONUP = " + m.Msg + ", x = " + x + " y = " + y);
                int wndTitleHeight = Win32API.GetSystemMetrics(SysMetericsIndex.SM_CYCAPTION);
                int wndBorderWidth = Win32API.GetSystemMetrics(SysMetericsIndex.SM_CXBORDER);
                int wndBorderHeight = Win32API.GetSystemMetrics(SysMetericsIndex.SM_CYBORDER);
                wndTitleHeight = 30;
                wndBorderWidth = 8;
                wndBorderHeight = 8;
                Rect closeRect = new Rect();
                closeRect.left = this.Left + (this.Width - wndBorderWidth - Win32API_Test.Properties.Resources.close.Width);
                closeRect.top = this.Top + (wndTitleHeight - Win32API_Test.Properties.Resources.close.Height) / 2;
                closeRect.right = closeRect.left + Win32API_Test.Properties.Resources.close.Width;
                closeRect.bottom = closeRect.top + Win32API_Test.Properties.Resources.close.Height;
                Point p = new Point
                {
                    x = x,
                    y = y
                };
                bool result = Win32API.PtInRect(ref closeRect, p);
                if (result)
                {
                    Win32API.PostMessage(m.HWnd, (uint)WindowsMsg.WM_SYSCOMMAND, (IntPtr)SysCmd.SC_CLOSE, IntPtr.Zero);
                }
            }
            else if (m.Msg == (int)WindowsMsg.WM_SYSCOMMAND)
            {
                //int y = Win32Tool.GetHighByte((int)m.LParam);
                //int x = Win32Tool.GetLowByte((int)m.LParam);
                //Console.WriteLine("WM_SYSCOMMAND = " + m.Msg + ", x = " + x + ", y = " + y + ", wParam = " + m.WParam);
                //if ((m.WParam.ToInt32() & 0xFFF0) == SysCmd.SC_MOVE)
                //{
                //    Win32API.PostMessage(m.HWnd, (uint)WndMsg.WM_NCLBUTTONUP,(IntPtr) NcHitTestCmd.HTCAPTION, m.LParam);
                //}
            }
            //else if (m.Msg == (int)WndMsg.WM_LBUTTONDOWN)
            //{
            //    int y = Win32Tool.GetHighByte((int)m.LParam);
            //    int x = Win32Tool.GetLowByte((int)m.LParam);
            //    Console.WriteLine("WM_LBUTTONDOWN = " + m.Msg + ", x = " + x + " y = " + y);
            //}
            //else if (m.Msg == (int)WndMsg.WM_LBUTTONUP)
            //{
            //    int y = Win32Tool.GetHighByte((int)m.LParam);
            //    int x = Win32Tool.GetLowByte((int)m.LParam);
            //    Console.WriteLine("WM_LBUTTONUP = " + m.Msg + ", x = " + x + " y = " + y);
            //}
            //else if (m.Msg == (int)WndMsg.WM_CAPTURECHANGED)
            //{
            //    Console.WriteLine("WM_CAPTURECHANGED");
            //}
            //else if (m.Msg == (int)WndMsg.WM_NCRBUTTONDOWN)
            //{
            //    int high = Win32Tool.GetHighByte((int)m.LParam);
            //    int low = Win32Tool.GetLowByte((int)m.LParam);
            //    Console.WriteLine("WM_NCRBUTTONDOWN = " + m.Msg + ", x = " + low + " y = " + high);
            //}
            //else if (m.Msg == (int)WndMsg.WM_NCHITTEST)
            //{
            //    int y = Win32Tool.GetHighByte((int)m.LParam);
            //    int x = Win32Tool.GetLowByte((int)m.LParam);
            //    Console.WriteLine("WM_NCHITTEST = " + m.Msg + ", x = " + x + " y = " + y);
            //    return;
            //    //if (x > 260 && x < 290 && y > 0 && y < 20)
            //    //{
            //    //    Console.WriteLine("WM_NCHITTEST: 鼠标单击了关闭按钮!");
            //    //    return;
            //    //}
            //}
            //else if (m.Msg == (int)WndMsg.WM_CLOSE)
            //{
            //    Console.WriteLine("WM_CLOSE");
            //}
            //else if (m.Msg == WndMsg.WM_SYSCOMMAND)
            //{
            //    int high = Win32Tool.GetHighByte((int)m.LParam);
            //    int low = Win32Tool.GetLowByte((int)m.LParam);
            //    Console.WriteLine("WM_SYSCOMMAND = " + m.Msg + ", x = " + low + " y = " + high);
            //    //if (m.WParam.ToInt32() == SysCmd.SC_CLOSE)
            //    //{
            //    //    return;
            //    //}
            //}
            //else if (m.Msg == (int)WndMsg.WM_PAINT)
            //{
            //    return;
            //}
            else if (m.Msg == (int)WindowsMsg.WM_NCPAINT)
            {
                Console.WriteLine("WM_NCPAINT");
                Win32API.DefWindowProc(m.HWnd, (uint)m.Msg, m.WParam, m.LParam);
                int wndTitleHeight = Win32API.GetSystemMetrics(SysMetericsIndex.SM_CYCAPTION);
                int wndBorderWidth = Win32API.GetSystemMetrics(SysMetericsIndex.SM_CXBORDER);
                int wndBorderHeight = Win32API.GetSystemMetrics(SysMetericsIndex.SM_CYBORDER);
                wndTitleHeight = 30;
                wndBorderWidth = 8;
                wndBorderHeight = 8;
                //IntPtr hdc = Win32API.GetWindowDC(this.Handle);
                IntPtr hdc = Win32API.GetDCEx(this.Handle, (IntPtr)1, DCExFlag.DCX_WINDOW | DCExFlag.DCX_INTERSECTRGN | DCExFlag.DCX_CACHE);
                Graphics g = Graphics.FromHdc(hdc);
                g.DrawString("Form21111111111111111111111111111111111", new Font("宋体", 10), new SolidBrush(Color.Black), new PointF(30, 12));
                //Region region = new System.Drawing.Region(new Rectangle
                //{
                //    Width = this.Width,
                //    Height = this.Height
                //});
                //Region region1 = new System.Drawing.Region(new Rectangle
                //{
                //    X = 8,
                //    Y = 30,
                //    Width = this.ClientSize.Width,
                //    Height = this.ClientSize.Height
                //});
                //region.Xor(region1);
                //TextureBrush tb = new TextureBrush(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "11.jpg"));
                //g.FillRegion(tb, region);
                //Image imgClose = Win32API_Test.Properties.Resources.close;
                //g.DrawImage(imgClose, new Rectangle
                //{
                //    X = this.Width - (wndBorderWidth - 2) - imgClose.Width,
                //    Y = (wndTitleHeight - imgClose.Height) / 2,
                //    Width = imgClose.Width,
                //    Height = imgClose.Height
                //});
                //Image imgMax = Win32API_Test.Properties.Resources.max;
                //g.DrawImage(imgMax, new Rectangle
                //{
                //    X = this.Width - wndBorderWidth - imgClose.Width - 100 - imgMax.Width,
                //    Y = (wndTitleHeight - imgMax.Height) / 2,
                //    Width = imgMax.Width,
                //    Height = imgMax.Height
                //});
                //DrawRoundRectangle(g, new Pen(Color.FromArgb(6, 17, 30)), new Rectangle
                //{
                //    X = 0,
                //    Y = 0,
                //    Width = this.Width - 1,
                //    Height = this.Height - 1
                //}, 4);
                //DrawRoundRectangle(g, new Pen(Color.FromArgb(226, 233, 241)), new Rectangle
                //{
                //    X = 1,
                //    Y = 1,
                //    Width = this.Width - 1 - 2,
                //    Height = this.Height - 1 - 2
                //}, 4);
                //g.DrawRectangle(new Pen(Color.FromArgb(26, 50, 76)), new Rectangle
                //{
                //    X = 8 - 1,
                //    Y = 30 - 1,
                //    Width = this.ClientSize.Width + 1,
                //    Height = this.ClientSize.Height + 1
                //});
                //g.DrawRectangle(new Pen(Color.FromArgb(192, 208, 224)), new Rectangle
                //{
                //    X = 8 - 1 - 1,
                //    Y = 30 - 1 - 1,
                //    Width = this.ClientSize.Width + 1 + 2,
                //    Height = this.ClientSize.Height + 1 + 2
                //});
                //g.DrawIcon(this.Icon, new Rectangle
                //{
                //    X = wndBorderWidth - 2,
                //    Y = (wndTitleHeight - this.Icon.Height) / 2,
                //    Width = this.Icon.Width,
                //    Height = this.Icon.Height
                //});
                //g.DrawString("Form2", new Font("宋体", 10), new SolidBrush(Color.Black), new PointF(30, 12));
                g.Dispose();
                m.Result = IntPtr.Zero;
                return;
            }
            else if (m.Msg == WindowsMsg.WM_NCHITTEST)
            {
                int result = (int)Win32API.DefWindowProc(m.HWnd, (uint)m.Msg, m.WParam, m.LParam);
                if (result == NcHitTestCmd.HTMINBUTTON || result == NcHitTestCmd.HTMAXBUTTON || result == NcHitTestCmd.HTCLOSE)
                {
                    m.Result = (IntPtr)NcHitTestCmd.HTCAPTION;
                }
                //else if (result == NcHitTestCmd.HTLEFT || result == NcHitTestCmd.HTRIGHT || result == NcHitTestCmd.HTTOP ||
                //    result == NcHitTestCmd.HTBOTTOM || result == NcHitTestCmd.HTTOPLEFT || result == NcHitTestCmd.HTTOPRIGHT ||
                //    result == NcHitTestCmd.HTBOTTOMLEFT || result == NcHitTestCmd.HTBOTTOMRIGHT)
                //{
                //    m.Result = (IntPtr)NcHitTestCmd.HTCAPTION;
                //}
                else
                {
                    m.Result = (IntPtr)result;
                }

                int wndTitleHeight = Win32API.GetSystemMetrics(SysMetericsIndex.SM_CYCAPTION);
                int wndBorderWidth = Win32API.GetSystemMetrics(SysMetericsIndex.SM_CXBORDER);
                int wndBorderHeight = Win32API.GetSystemMetrics(SysMetericsIndex.SM_CYBORDER);
                wndTitleHeight = 30;
                wndBorderWidth = 8;
                wndBorderHeight = 8;
                int y = Win32Tool.GetHighByte((int)m.LParam);
                int x = Win32Tool.GetLowByte((int)m.LParam);
                Point p = new Point
                {
                    x = x,
                    y = y
                };
                Rect closeRect = new Rect();
                closeRect.left = this.Left + (this.Width - wndBorderWidth - Win32API_Test.Properties.Resources.close.Width);
                closeRect.top = this.Top + (wndTitleHeight - Win32API_Test.Properties.Resources.close.Height) / 2;
                closeRect.right = closeRect.left + Win32API_Test.Properties.Resources.close.Width;
                closeRect.bottom = closeRect.top + Win32API_Test.Properties.Resources.close.Height;
                if (Win32API.PtInRect(ref closeRect, p))
                {
                    m.Result = (IntPtr)NcHitTestCmd.HTCAPTION;
                }
                return;
            }
            //else if (m.Msg == WndMsg.WM_NCCALCSIZE)
            //{
            //    Console.WriteLine("WM_NCCALCSIZE");
            //    return;
            //}
            else if (m.Msg == WindowsMsg.WM_ACTIVATE)
            {

            }
            else if (m.Msg == WindowsMsg.WM_NCACTIVATE)
            {
                //Console.WriteLine("WM_NCACTIVATE");
                m.WParam = IntPtr.Zero;
                return;
            }
            //else if (m.Msg == (int)WindowsMsg.WM_PAINT)
            //{
            //}
            base.WndProc(ref m);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
            //Image bg = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "bg.gif");
            //this.BackgroundImage = bg;
            //this.BackgroundImageLayout = ImageLayout.Center;

            base.OnPaint(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            //g.DrawRectangle(new Pen(Color.Red, 3), new Rectangle
            //{
            //    X = 80,
            //    Y = 80,
            //    Width = 50,
            //    Height = 50
            //});
            //g.Dispose();
            //this.Width = 1000;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            //Win32API.SetWindowPos(this.Handle, IntPtr.Zero, 0, 0, 0, 0, WindowPosFlag.SWP_NOSIZE);
            //Win32API.PostMessage(this.Handle, WndMsg.WM_SYSCOMMAND, (IntPtr)SysCmd.SC_CLOSE, (IntPtr)Win32Tool.CombainHighLowByte(10, 269));
            //IntPtr result1 = Win32API.SendMessage(this.Handle, WndMsg.WM_NCHITTEST, IntPtr.Zero, (IntPtr)Win32Tool.CombainHighLowByte(10, 269));
            //Console.WriteLine(result1);
            //if (result1.ToInt32() == 20)
            //{
            //    Win32API.PostMessage(this.Handle, WndMsg.WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            //}

            ThreadStart ts = delegate
            {
                Thread.Sleep(2 * 1000);

                Point p = new Point
                {
                    x = 128,
                    y = 10
                };
                Win32API.PostMessage(handle, WindowsMsg.WM_NCRBUTTONDOWN, (IntPtr)2, (IntPtr)Win32Tool.CombainHighLowByte(p.y, p.x));
                IntPtr lpPoint = Marshal.AllocHGlobal(2);
                Marshal.StructureToPtr(p, lpPoint, false);
                IntPtr result = Win32API.SendMessage(handle, WindowsMsg.WM_NCRBUTTONUP, (IntPtr)2, lpPoint);
                Marshal.FreeHGlobal(lpPoint);
                Console.WriteLine(result);
            };
            Thread t = new Thread(ts);
            t.IsBackground = true;
            //t.Start();
        }

        private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int cornerRadius)
        {
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius * 2, rect.Y);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Y + rect.Height - cornerRadius * 2);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRect.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
            roundedRect.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.AddLine(rect.X, rect.Bottom - cornerRadius * 2, rect.X, rect.Y + cornerRadius * 2);
            roundedRect.CloseFigure();
            return roundedRect;
        }

        private void DrawRoundRectangle(Graphics g, Pen p, Rectangle rect, int cornerRadius)
        {
            using (GraphicsPath path = CreateRoundedRectanglePath(rect, cornerRadius))
            {
                g.DrawPath(p, path);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
