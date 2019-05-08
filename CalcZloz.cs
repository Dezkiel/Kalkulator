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
    public partial class CalcZloz : Form
    {
        private static int OblczanieSilni(double zm1)
        {
            int result = 1;
            for (int i = 1; i <= zm1; i++)
            {
                result *= i;
            }
            return result;
        }

        private static double Exp (double zm2)
        {
            double wynik = 1;
            for (int i =  1; i <= zm2; i++)
            {
                wynik = 10 * zm2;
            }
            return wynik;
        }
       
           
        /*private static double PowX(double zm1, double zm2)
        {
            if (zm2 < 1)
            {

                return 0;
            }
            else
            {
                double result = 1;
                for (double i = 1; i <= zm2; i++)
                {
                    result = zm1 * zm1;
                }
                return result;
            }

        }*/          

        double zm1 = 0, zm2 = 0, zm3 = 0;
        
        int zm4;
        double memory;
        string wybor;
        string dzialanie;

        public CalcZloz()
        {
            InitializeComponent();
            textBox2.Text = "0";
            RadioButton_Degrees_CheckedChanged(this, null);
        }

        private void CalcZloz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void KalkulatorProstyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcPros Pros = new CalcPros();
            Pros.ShowDialog();
        }        

        private void Button_0_Click(object sender, EventArgs e)
        {
           if (textBox2.Text == "0")
            {
                textBox2.Clear();                
            }
            textBox2.AppendText("0");
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "0")
            {
                textBox2.Clear();               
            }
            textBox2.AppendText("1");
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            textBox2.AppendText("2");
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            textBox2.AppendText("3");
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            textBox2.AppendText("4");
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            textBox2.AppendText("5");
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            textBox2.AppendText("6");
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            textBox2.AppendText("7");
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            textBox2.AppendText("8");
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            textBox2.AppendText("9");
        }

        private void Button_coma_Click(object sender, EventArgs e)
        {
            
            if(textBox2.Text.Contains(","))
            {
                textBox2.Text = textBox2.Text;
            }
            else
            {
                textBox2.AppendText(",");
            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);
            dzialanie = "add";
            textBox2.Clear();            
        }

        private void Button_substract_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);
            dzialanie = "sub";
            textBox2.Clear();
        }

        private void Button_multiply_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);
            dzialanie = "mult";
            textBox2.Clear();
        }

        private void Button_divide_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);
            dzialanie = "div";
            textBox2.Clear();
        }

        private void Button_Reciprocal_Click(object sender, EventArgs e)
        {            
            zm1 = Convert.ToDouble(textBox2.Text);
            double wynik = 1 / zm1;
            textBox2.Text = Convert.ToString(wynik);
        }

        private void Button_root_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(Math.Sqrt(zm1));
        }

        private void Button_PlusMinus_Click(object sender, EventArgs e)
        {            
            double zmienna = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(-zmienna);
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            zm1 = 0;
            zm2 = 0;
            zm3 = 0;
            textBox2.Text = Convert.ToString(0);
        }

        private void Button_Backspace_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_Factorial_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);

            if (zm1 == 0)
            {
                textBox2.Text = Convert.ToString(1);
            }
            else
            {                
                textBox2.Text = Convert.ToString(OblczanieSilni(zm1));
            }
        }

        private void Button_Pi_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(Math.PI);
        }

        private void Button_Sin_Click(object sender, EventArgs e)
        {
            if (wybor == "Degrees")
            {
                zm1 = Convert.ToDouble(textBox2.Text);
                double wynik = (zm1 * (Math.PI)) / 180;
                textBox2.Text = Convert.ToString("Degrees: " +(Math.Sin(wynik)));
            }
            else if(wybor == "Radians")
            {
                zm1 = Convert.ToDouble(textBox2.Text);
                textBox2.Text = Convert.ToString("Radians: " + Math.Sin(zm1));
            }
            else if(wybor == "Grads")
            {

            }
        }

        private void RadioButton_Degrees_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_Degrees.Checked == true)
            {
                wybor = "Degrees";
            }            
        }

        private void RadioButton_Radians_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Radians.Checked == true)
            {
                wybor = "Radians";
            }
        }

        private void RadioButton_Grads_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Grads.Checked == true)
            {
                wybor = "Grads";
            }
        }

        private void Button2_Cos_Click(object sender, EventArgs e)
        {
            if (wybor == "Degrees")
            {
                zm1 = Convert.ToDouble(textBox2.Text);
                double wynik = (zm1 * (Math.PI)) / 180;
                textBox2.Text = Convert.ToString("Degrees: " + (Math.Cos(wynik)));
            }
            else if (wybor == "Radians")
            {
                zm1 = Convert.ToDouble(textBox2.Text);
                textBox2.Text = Convert.ToString("Radians: " + Math.Cos(zm1));
            }
        }

        private void Button_Tan_Click(object sender, EventArgs e)
        {
            if (wybor == "Degrees")
            {
                zm1 = Convert.ToDouble(textBox2.Text);
                double wynik = (zm1 * (Math.PI)) / 180;
                textBox2.Text = Convert.ToString("Degrees: " + (Math.Tan(wynik)));
            }
            else if (wybor == "Radians")
            {
                zm1 = Convert.ToDouble(textBox2.Text);
                textBox2.Text = Convert.ToString("Radians: " + Math.Tan(zm1));
            }
        }

        private void Button_Sinh_Click(object sender, EventArgs e)
        {
            if (wybor == "Degrees")
            {
                zm1 = Convert.ToDouble(textBox2.Text);
                double wynik = (zm1 * (Math.PI)) / 180;
                textBox2.Text = Convert.ToString("Degrees: " + (Math.Sinh(wynik)));
            }
            else if (wybor == "Radians")
            {
                zm1 = Convert.ToDouble(textBox2.Text);
                textBox2.Text = Convert.ToString("Radians: " + Math.Sinh(zm1));
            }
        }

        private void Button_Cosh_Click(object sender, EventArgs e)
        {
            if (wybor == "Degrees")
            {
                zm1 = Convert.ToDouble(textBox2.Text);
                double wynik = (zm1 * (Math.PI)) / 180;
                textBox2.Text = Convert.ToString("Degrees: " + (Math.Cosh(wynik)));
            }
            else if (wybor == "Radians")
            {
                zm1 = Convert.ToDouble(textBox2.Text);
                textBox2.Text = Convert.ToString("Radians: " + Math.Cosh(zm1));
            }
        }

        private void Button_Tanh_Click(object sender, EventArgs e)
        {
            if (wybor == "Degrees")
            {
                zm1 = Convert.ToDouble(textBox2.Text);
                double wynik = (zm1 * (Math.PI)) / 180;
                textBox2.Text = Convert.ToString("Degrees: " + (Math.Tanh(wynik)));
            }
            else if (wybor == "Radians")
            {
                zm1 = Convert.ToDouble(textBox2.Text);
                textBox2.Text = Convert.ToString("Radians: " + Math.Tanh(zm1));
            }
        }

        private void Button_Xpow2_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(zm1 * zm1);
        }

        private void Button_PowerY_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);
            dzialanie = "PowX";
            textBox2.Clear();
        }

        private void Button_Power3_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(zm1 * zm1 * zm1);
        }

        private void Button_MC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void Button_MR_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(memory);
        }

        private void Button_MS_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(textBox2.Text);
            textBox2.Clear();
        }

        private void Button_Mplus_Click(object sender, EventArgs e)
        {
            double wynik;
            zm1 = Convert.ToDouble(textBox2.Text);
            wynik = zm1 + memory;
            textBox2.Text = Convert.ToString(wynik);
        }

        private void Button_Mminus_Click(object sender, EventArgs e)
        {
            double wynik;
            zm1 = Convert.ToDouble(textBox2.Text);
            wynik = zm1 - memory;
            textBox2.Text = Convert.ToString(wynik);
        }

        private void Button_RootY_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);
            dzialanie = "RootY";
            textBox2.Clear();
        }

        private void Button_Root3_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);
            textBox2.Text = (Convert.ToString(Math.Pow(zm1, 0.333333)));
        }

        private void Button_10powX_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(Math.Pow(10, zm1));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(Math.Log10(zm1));
        }

        private void Button_in_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(Math.Log(zm1));
        }

        private void Button_Mod_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);
            dzialanie = "Mod";
            textBox2.Clear();
        }

        private void Button_Exp_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);
            dzialanie = "Exp";
            textBox2.Clear();
        }

        private void Button_int_Click(object sender, EventArgs e)
        {
            zm1 = Convert.ToDouble(textBox2.Text);
            zm4 = Convert.ToInt32(zm1);
            textBox2.Text = Convert.ToString(zm4);            
        }

        private void Button_Percent_Click(object sender, EventArgs e)
        {
            if (dzialanie == "add")
            {
                double wynik;
                zm2 = Convert.ToDouble(textBox2.Text);
                zm3 = (zm1 * zm2) / 100;
                wynik = zm1 + zm3;
                textBox2.Text = (Convert.ToString(wynik));
            }
            else if (dzialanie == "sub")
            {
                double wynik;
                zm2 = Convert.ToDouble(textBox2.Text);
                zm3 = (zm1 * zm2) / 100;
                wynik = zm1 - zm3;
                textBox2.Text = (Convert.ToString(wynik));
            }
            else if (dzialanie == "mult")
            {
                double wynik;
                zm2 = Convert.ToDouble(textBox2.Text);
                zm3 = (zm1 * zm2) / 100;
                wynik = zm1 * zm3;
                textBox2.Text = (Convert.ToString(wynik));
            }
            else if (dzialanie == "div")
            {
                double wynik;
                zm2 = Convert.ToDouble(textBox2.Text);
                zm3 = (zm1 * zm2) / 100;
                wynik = zm1 / zm3;
                textBox2.Text = (Convert.ToString(wynik));
            }
        }

        private void Button_equals_Click(object sender, EventArgs e)
        {
            switch (dzialanie)
            {
                case "add":
                    {                             
                        zm2 = Convert.ToDouble(textBox2.Text);
                        textBox2.Text = Convert.ToString(zm1 + zm2);                       
                    }
                    break;
                case "sub":
                    {
                        zm2 = Convert.ToDouble(textBox2.Text);
                        textBox2.Text = Convert.ToString(zm1 - zm2);
                    }
                    break;
                case "mult":
                    {
                        zm2 = Convert.ToDouble(textBox2.Text);
                        textBox2.Text = Convert.ToString(zm1 * zm2);
                    }break;
                case "div":
                    {
                        if (zm2 == 0)
                        {
                            textBox2.Text = "DIV / 0 !!!";
                        }
                        else
                        {
                            zm2 = Convert.ToDouble(textBox2.Text);
                            textBox2.Text = Convert.ToString(zm1 / zm2);
                        }
                    }break;
                case "PowX":
                    {
                        zm2 = Convert.ToDouble(textBox2.Text);
                        textBox2.Text = Convert.ToString(Math.Pow(zm1,zm2));
                    }break;
                case "RootY":
                    {                        
                        zm2 = Convert.ToDouble(textBox2.Text);
                        textBox2.Text = Convert.ToString(Math.Pow(zm1, (1 / zm2)));
                    }
                    break;
                case "Mod":
                    {
                        zm2 = Convert.ToDouble(textBox2.Text);
                        textBox2.Text = (Convert.ToString(zm1 % zm2));
                    }break;
                case "Exp":
                    {                       
                        zm2 = Convert.ToDouble(textBox2.Text);                        
                        textBox2.Text = Convert.ToString(zm1 * Math.Pow(10,zm2));
                        
                    }break;
            }
        }
    }
}
