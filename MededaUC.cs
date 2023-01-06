using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntPg_UC
{
    public partial class MededaUC : UserControl
    {
        const int ShrinkSize = 10;
        int PanelCount = 0;
        public MededaUC()
        {
            InitializeComponent();
            button1.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            PanelCount -= 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            PanelCount += 1;

            button1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PanelCount == 1)
            {
                panel1.Width -= ShrinkSize;
                if (panel1.Width <= 0)
                {
                    timer1.Stop();
                }
            }
            else if (PanelCount == 2)
            {
                panel2.Width -= ShrinkSize;
                if (panel2.Width <= 0)
                {
                    timer1.Stop();
                }
            }
            else if (PanelCount == 3)
            {
                panel3.Width -= ShrinkSize;
                if (panel3.Width <= 0)
                {
                    timer1.Stop();
                }
            }
            else if (PanelCount == 4)
            {
                panel4.Width -= ShrinkSize;
                if (panel4.Width <= 0)
                {
                    timer1.Stop();
                }
            }
            else if (PanelCount == 5)
            {
                panel5.Width -= ShrinkSize;
                if (panel5.Width <= 0)
                {
                    timer1.Stop();
                }
            }
            else if (PanelCount == 6)
            {
                panel6.Width -= ShrinkSize;
                if (panel6.Width <= 0)
                {
                    timer1.Stop();
                }
            }
            else
            {
                panel7.Width -= ShrinkSize;
                if (panel7.Width <= 0)
                {
                    timer1.Stop();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (PanelCount == 6)
            {
                panel7.Width += ShrinkSize;
                if (panel7.Width >= 930)
                {
                    timer2.Stop();
                }
            }
            else if (PanelCount == 5)
            {
                panel6.Width += ShrinkSize;
                if (panel6.Width >= 930)
                {
                    timer2.Stop();
                }
            }
            else if (PanelCount == 4)
            {
                panel5.Width += ShrinkSize;
                if (panel5.Width >= 930)
                {
                    timer2.Stop();
                }
            }
            else if (PanelCount == 3)
            {
                panel4.Width += ShrinkSize;
                if (panel4.Width >= 930)
                {
                    timer2.Stop();
                }
            }
            else if (PanelCount == 2)
            {
                panel3.Width += ShrinkSize;
                if (panel3.Width >= 930)
                {
                    timer2.Stop();
                }
            }
            else if (PanelCount == 1)
            {
                panel2.Width += ShrinkSize;
                if (panel2.Width >= 930)
                {
                    timer2.Stop();
                }
            }
            else
            {
                panel1.Width += ShrinkSize;
                if (panel1.Width >= 930)
                {
                    timer2.Stop();
                }

                button1.Visible = false;
            }
        }
        private void MededaUC_Load(object sender, EventArgs e)
        {

        }
    }
}
