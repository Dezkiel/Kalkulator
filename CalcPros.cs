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
        double firstInput = 0, secondInput = 0; 
        enum dzialania {add = 0, substract = 1, multiply = 2, divide = 3}
        int dzialanie;
        double memory;

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
            if (textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                textBox1.AppendText(",");
            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox1.Text);
            dzialanie = (int)dzialania.add;
            textBox1.Clear();
        }

        private void Button_substract_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox1.Text);
            dzialanie = (int)dzialania.substract;
            textBox1.Clear();
        }

        private void Button_multiply_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox1.Text);
            dzialanie = (int)dzialania.multiply;
            textBox1.Clear();
        }

        private void Button_divide_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox1.Text);
            dzialanie = (int)dzialania.divide;
            textBox1.Clear();
        }

        private void Button_root_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Sqrt(firstInput));
        }

        private void Button_equals_Click(object sender, EventArgs e)
        {
            switch (dzialanie)
            {
                case 0:
                    {
                        secondInput = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = Convert.ToString(firstInput + secondInput);
                    }
                    break;
                case 1:
                    {
                        secondInput = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = Convert.ToString(firstInput - secondInput);
                    }
                    break;
                case 2:
                    {
                        secondInput = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = Convert.ToString(firstInput * secondInput);
                    }
                    break;
                case 3:
                    {
                        secondInput = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = Convert.ToString(firstInput / secondInput);
                    }
                    break;
            }            
            
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            firstInput = 0;
            secondInput = 0;
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
            firstInput = Convert.ToDouble(textBox1.Text);
            wynik = firstInput + memory;
            textBox1.Text = Convert.ToString(wynik);
        }       

        private void Button_Mminus_Click(object sender, EventArgs e)
        {
            double wynik;
            firstInput = Convert.ToDouble(textBox1.Text);
            wynik = firstInput - memory;
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
