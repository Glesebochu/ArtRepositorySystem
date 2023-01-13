using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtRepositorySystem
{
    public partial class INTROPAGE_UC_LATEST : UserControl
    {
        const int ShrinkSize = 10;
        int PanelCount = 0;
        public INTROPAGE_UC_LATEST()
        {
            InitializeComponent();
            guna2Button1.Visible = false;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            PanelCount -= 1;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            PanelCount += 1;

            guna2Button1.Visible = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PanelCount == 1)
            {
                Panel1.Width -= ShrinkSize;
                if (Panel1.Width <= 0)
                {
                    timer1.Stop();
                }
            }
            else if (PanelCount == 2)
            {
                Panel2.Width -= ShrinkSize;
                if (Panel2.Width <= 0)
                {
                    timer1.Stop();
                }
            }
            else if (PanelCount == 3)
            {
                Panel3.Width -= ShrinkSize;
                if (Panel3.Width <= 0)
                {
                    timer1.Stop();
                }
            }
            else if (PanelCount == 4)
            {
                Panel4.Width -= ShrinkSize;
                if (Panel4.Width <= 0)
                {
                    timer1.Stop();
                }
            }
            else if (PanelCount == 5)
            {
                Panel5.Width -= ShrinkSize;
                if (Panel5.Width <= 0)
                {
                    timer1.Stop();
                }
            }
            else if (PanelCount == 6)
            {
                Panel6.Width -= ShrinkSize;
                if (Panel6.Width <= 0)
                {
                    timer1.Stop();
                }
            }
            else
            {
                Panel7.Width -= ShrinkSize;
                if (Panel7.Width <= 0)
                {
                    timer1.Stop();
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (PanelCount == 6)
            {
                Panel7.Width += ShrinkSize;
                if (Panel7.Width >= 930)
                {
                    timer2.Stop();
                }
            }
            else if (PanelCount == 5)
            {
                Panel6.Width += ShrinkSize;
                if (Panel6.Width >= 930)
                {
                    timer2.Stop();
                }
            }
            else if (PanelCount == 4)
            {
                Panel5.Width += ShrinkSize;
                if (Panel5.Width >= 930)
                {
                    timer2.Stop();
                }
            }
            else if (PanelCount == 3)
            {
                Panel4.Width += ShrinkSize;
                if (Panel4.Width >= 930)
                {
                    timer2.Stop();
                }
            }
            else if (PanelCount == 2)
            {
                Panel3.Width += ShrinkSize;
                if (Panel3.Width >= 930)
                {
                    timer2.Stop();
                }
            }
            else if (PanelCount == 1)
            {
                Panel2.Width += ShrinkSize;
                if (Panel2.Width >= 930)
                {
                    timer2.Stop();
                }
            }
            else
            {
                Panel1.Width += ShrinkSize;
                if (Panel1.Width >= 930)
                {
                    timer2.Stop();
                }

                guna2Button1.Visible = false;
            }
        }
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
