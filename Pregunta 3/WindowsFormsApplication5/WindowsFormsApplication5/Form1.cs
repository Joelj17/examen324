using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        int pr, pg, pb;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void carga_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.jpg|*.png";

            openFileDialog1.ShowDialog();
            
            bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = bmp;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            c = bmp.GetPixel(15,15);
            textBox1.Text = c.R.ToString();

            textBox2.Text = c.G.ToString();
            textBox3.Text = c.B.ToString();

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Color c = new Color();
            c=bmp.GetPixel(e.X,e.Y);
            textBox1.Text = c.R.ToString();
            pr = c.R;
            pg = c.G;
            pb = c.B;

            textBox2.Text = c.G.ToString();
            textBox3.Text = c.B.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width,bmp.Height);
            for(int i=0;i<bmp.Width;i++)
            {
                for (int j = 0; j < bmp.Height; j++) {
                    c = bmp.GetPixel(i, j);
                    bmpR.SetPixel(i, j, Color.FromArgb(c.R, 0, 0));

                
                }
            }
            pictureBox2.Image = bmpR;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmpR.SetPixel(i, j, Color.FromArgb(0, c.G, 0));


                }
            }
            pictureBox2.Image = bmpR;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmpR.SetPixel(i, j, Color.FromArgb(0, 0, c.B));


                }
            }
            pictureBox2.Image = bmpR;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            int mr = 0, mb = 0, mg = 0;
            for(int i=15;i<25;i++)
                for (int j = 15; j < 25; j++) {

                    c = bmp.GetPixel(i, j);
                    mr = mr + c.R;
                    mg = mg + c.G;
                    mb = mb + c.B;

                }
            mr = mr / 100;
            mb = mb / 100;
            mg = mg / 100;
            textBox1.Text = mr.ToString();
            textBox2.Text = mg.ToString();
            textBox3.Text = mb.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if ((c.R - 10 <= pr && pr <= c.R + 10) && (c.G - 10 <= pg && pg <= c.G + 10) && (c.B - 10 <= pb && pb <= c.B + 10))
                    {
                        bmpR.SetPixel(i, j, Color.Fuchsia);
                    }
                    else {
                        bmpR.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                    
                    }

                }
            }
            pictureBox2.Image = bmpR;
        }
    }
}
