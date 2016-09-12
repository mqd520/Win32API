using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Win32API_Test
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            Bitmap bg = Win32API_Test.Properties.Resources.bg;
            this.ClientSize = new Size
            {
                Width = bg.Width,
                Height = bg.Height
            };
            this.Location = new Point
            {
                X = 0,
                Y = 0
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            Bitmap bg = Win32API_Test.Properties.Resources.bg;
            for (int i = 0; i < bg.Width; i++)
            {
                for (int j = 0; j < bg.Height; j++)
                {
                    Color color = bg.GetPixel(i, j);
                    if (color.A == 255)
                    {
                        path.AddRectangle(new Rectangle
                        {
                            X = i,
                            Y = j,
                            Width = 1,
                            Height = 1
                        });
                    }
                }
            }
            Region rgn = new Region(path);
            this.Region = rgn;
            this.BackgroundImage = bg;
            this.BackgroundImageLayout = ImageLayout.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("width = {0},height = {1}", this.Width, this.Height));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bg = Win32API_Test.Properties.Resources.btn;
            GraphicsPath path = new GraphicsPath();
            for (int i = 0; i < bg.Width; i++)
            {
                for (int j = 0; j < bg.Height; j++)
                {
                    Color color = bg.GetPixel(i, j);
                    if (color.A == 255)
                    {
                        path.AddRectangle(new Rectangle
                        {
                            X = i,
                            Y = j,
                            Width = 1,
                            Height = 1
                        });
                    }
                }
            }
            Region rgn = new Region(path);
            button3.Size = new System.Drawing.Size
            {
                Width = bg.Width,
                Height = bg.Height
            };
            button3.Text = "";
            button3.Region = rgn;
            button3.BackgroundImage = bg;
            button3.BackgroundImageLayout = ImageLayout.None;

            //button5.Size = new System.Drawing.Size
            //{
            //    Width = bg.Width,
            //    Height = bg.Height
            //};
            //button5.Text = "";
            //button5.Region = rgn;
            //button5.BackgroundImage = bg;
            //button5.BackgroundImageLayout = ImageLayout.None;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是不规则窗口");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap bg = Win32API_Test.Properties.Resources.btn1;
            GraphicsPath path = new GraphicsPath();
            for (int i = 0; i < bg.Width; i++)
            {
                for (int j = 0; j < bg.Height; j++)
                {
                    Color color = bg.GetPixel(i, j);
                    if (color.A == 255)
                    {
                        path.AddRectangle(new Rectangle
                        {
                            X = i,
                            Y = j,
                            Width = 1,
                            Height = 1
                        });
                    }
                }
            }
            Region rgn = new Region(path);
            button3.ClientSize = new System.Drawing.Size
            {
                Width = bg.Width,
                Height = bg.Height
            };
            button3.Text = "";
            button3.Region = rgn;
            button3.BackgroundImage = bg;
            button3.BackgroundImageLayout = ImageLayout.None;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
