using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Prosty_2
{
    public partial class CalcPros : Form
    {
        double zm1 = 0, zm2 = 0;        
        double memory;
        string dzialanie;

        public CalcPros()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            
            textBox1.AppendText("0");
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.AppendText("1");
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.AppendText("2");
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.AppendText("3");
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.AppendText("4");
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.AppendText("5");
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.AppendText("6");
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.AppendText("7");
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.AppendText("8");
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.AppendText("9");
        }

        private void Button_coma_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(",");
        }

        private void Button_add_Click(object sender, EventArgs e)
        {             
            dzialanie = "add";
            textBox1.Clear();
        }

        private void Button_substract_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox1.Text);
            dzialanie = "subs";
            textBox1.Clear();
        }

        private void Button_multiply_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox1.Text);
            dzialanie = "mult";
            textBox1.Clear();
        }

        private void Button_divide_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox1.Text);
            dzialanie = "div";
            textBox1.Clear();
        }

        private void Button_root_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Sqrt(zm1));
        }

        private void Button_equals_Click(object sender, EventArgs e)
        {            

            if (dzialanie == "add")
            {
                zm2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(zm1 + zm2);                
            }
            else if (dzialanie == "subs")
            {
                zm2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(zm1 - zm2);
            }
            else if (dzialanie == "mult")
            {
                zm2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(zm1 * zm2);
            }
            else if (dzialanie == "div")
            {
                zm2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(zm1 / zm2);
            }
            /*else if (dzialanie == "root")
            {
                double sqrt = Math.Sqrt(zm1);
                textBox1.Text = Convert.ToString(sqrt);
            }*/
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            zm1 = 0;
            zm2 = 0;
            textBox1.Clear();
            textBox1.Text = "0";
        }

        private void Button_MC_Click(object sender, EventArgs e)
        {
            memory = 0;            
        }

        private void Button_MR_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(memory);            
        }

        private void Button_MS_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void Button_Mplus_Click(object sender, EventArgs e)
        {
            double wynik;
            zm1 = Convert.ToDouble(textBox1.Text);
            wynik = zm1 + memory;
            textBox1.Text = Convert.ToString(wynik);
        }       

        private void Button_Mminus_Click(object sender, EventArgs e)
        {
            double wynik;
            zm1 = Convert.ToDouble(textBox1.Text);
            wynik = zm1 - memory;
            textBox1.Text = Convert.ToString(wynik);
        }

        private void KalkulatorZłożonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcZloz Zloz = new CalcZloz();
            Zloz.ShowDialog();
        }        

        private void KalkulatorProstyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcPros Pros = new CalcPros();
            Pros.ShowDialog();
        }

        private void CalcPros_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
