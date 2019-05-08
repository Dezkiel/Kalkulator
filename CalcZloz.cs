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
        private static int OblczanieSilni(double firstInput)
        {
            int result = 1;
            for (int i = 1; i <= firstInput; i++)
            {
                result *= i;
            }
            return result;
        }
               
        double firstInput = 0, secondInput = 0, temporaryNumber = 0;        
        double memory;
        enum dzialania {add = 0, substract = 1, multiply = 2, divide = 3, powY = 4, rootY = 5, Modulo = 6, Exp = 7};
        string wybor;
        int dzialanie;

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
            firstInput = Convert.ToDouble(textBox2.Text);
            dzialanie = (int)dzialania.add;
            textBox2.Clear();            
        }

        private void Button_substract_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox2.Text);
            dzialanie = (int)dzialania.substract;
            textBox2.Clear();
        }

        private void Button_multiply_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox2.Text);
            dzialanie = (int)dzialania.multiply;
            textBox2.Clear();
        }

        private void Button_divide_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox2.Text);
            dzialanie = (int)dzialania.divide;
            textBox2.Clear();
        }

        private void Button_Reciprocal_Click(object sender, EventArgs e)
        {            
            firstInput = Convert.ToDouble(textBox2.Text);
            double wynik = 1 / firstInput;
            textBox2.Text = Convert.ToString(wynik);
        }

        private void Button_root_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(Math.Sqrt(firstInput));
        }

        private void Button_PlusMinus_Click(object sender, EventArgs e)
        {            
            double zmienna = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(-zmienna);
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            firstInput = 0;
            secondInput = 0;
            temporaryNumber = 0;
            textBox2.Text = Convert.ToString(0);
        }

        private void Button_Backspace_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_Factorial_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox2.Text);

            if (firstInput == 0)
            {
                textBox2.Text = Convert.ToString(1);
            }
            else
            {                
                textBox2.Text = Convert.ToString(OblczanieSilni(firstInput));
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
                firstInput = Convert.ToDouble(textBox2.Text);
                double wynik = (firstInput * (Math.PI)) / 180;
                textBox2.Text = Convert.ToString("Degrees: " +(Math.Sin(wynik)));
            }
            else if(wybor == "Radians")
            {
                firstInput = Convert.ToDouble(textBox2.Text);
                textBox2.Text = Convert.ToString("Radians: " + Math.Sin(firstInput));
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

        private void Button2_Cos_Click(object sender, EventArgs e)
        {
            if (wybor == "Degrees")
            {
                firstInput = Convert.ToDouble(textBox2.Text);
                double wynik = (firstInput * (Math.PI)) / 180;
                textBox2.Text = Convert.ToString("Degrees: " + (Math.Cos(wynik)));
            }
            else if (wybor == "Radians")
            {
                firstInput = Convert.ToDouble(textBox2.Text);
                textBox2.Text = Convert.ToString("Radians: " + Math.Cos(firstInput));
            }
        }

        private void Button_Tan_Click(object sender, EventArgs e)
        {
            if (wybor == "Degrees")
            {
                firstInput = Convert.ToDouble(textBox2.Text);
                double wynik = (firstInput * (Math.PI)) / 180;
                textBox2.Text = Convert.ToString("Degrees: " + (Math.Tan(wynik)));
            }
            else if (wybor == "Radians")
            {
                firstInput = Convert.ToDouble(textBox2.Text);
                textBox2.Text = Convert.ToString("Radians: " + Math.Tan(firstInput));
            }
        }

        private void Button_Sinh_Click(object sender, EventArgs e)
        {
            if (wybor == "Degrees")
            {
                firstInput = Convert.ToDouble(textBox2.Text);
                double wynik = (firstInput * (Math.PI)) / 180;
                textBox2.Text = Convert.ToString("Degrees: " + (Math.Sinh(wynik)));
            }
            else if (wybor == "Radians")
            {
                firstInput = Convert.ToDouble(textBox2.Text);
                textBox2.Text = Convert.ToString("Radians: " + Math.Sinh(firstInput));
            }
        }

        private void Button_Cosh_Click(object sender, EventArgs e)
        {
            if (wybor == "Degrees")
            {
                firstInput = Convert.ToDouble(textBox2.Text);
                double wynik = (firstInput * (Math.PI)) / 180;
                textBox2.Text = Convert.ToString("Degrees: " + (Math.Cosh(wynik)));
            }
            else if (wybor == "Radians")
            {
                firstInput = Convert.ToDouble(textBox2.Text);
                textBox2.Text = Convert.ToString("Radians: " + Math.Cosh(firstInput));
            }
        }

        private void Button_Tanh_Click(object sender, EventArgs e)
        {
            if (wybor == "Degrees")
            {
                firstInput = Convert.ToDouble(textBox2.Text);
                double wynik = (firstInput * (Math.PI)) / 180;
                textBox2.Text = Convert.ToString("Degrees: " + (Math.Tanh(wynik)));
            }
            else if (wybor == "Radians")
            {
                firstInput = Convert.ToDouble(textBox2.Text);
                textBox2.Text = Convert.ToString("Radians: " + Math.Tanh(firstInput));
            }
        }

        private void Button_Xpow2_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(firstInput * firstInput);
        }

        private void Button_PowerY_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox2.Text);
            dzialanie = (int)dzialania.powY;
            textBox2.Clear();
        }

        private void Button_Power3_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(firstInput * firstInput * firstInput);
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
            firstInput = Convert.ToDouble(textBox2.Text);
            wynik = firstInput + memory;
            textBox2.Text = Convert.ToString(wynik);
        }

        private void Button_Mminus_Click(object sender, EventArgs e)
        {
            double wynik;
            firstInput = Convert.ToDouble(textBox2.Text);
            wynik = firstInput - memory;
            textBox2.Text = Convert.ToString(wynik);
        }

        private void Button_RootY_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox2.Text);
            dzialanie = (int)dzialania.rootY;
            textBox2.Clear();
        }

        private void Button_Root3_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox2.Text);
            textBox2.Text = (Convert.ToString(Math.Pow(firstInput, 0.333333)));
        }

        private void Button_10powX_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(Math.Pow(10, firstInput));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(Math.Log10(firstInput));
        }

        private void Button_in_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(Math.Log(firstInput));
        }

        private void Button_Mod_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox2.Text);
            dzialanie = (int)dzialania.Modulo;
            textBox2.Clear();
        }

        private void Button_Exp_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(textBox2.Text);
            dzialanie = (int)dzialania.Exp;
            textBox2.Clear();
        }

        private void Button_int_Click(object sender, EventArgs e)
        {
            
            firstInput = Convert.ToDouble(textBox2.Text);
            int wynik = Convert.ToInt32(firstInput);
            textBox2.Text = Convert.ToString(wynik);            
        }

        private void Button_CE_Click(object sender, EventArgs e)
        {
            secondInput = 0;
            textBox2.Text = Convert.ToString(firstInput);
        }

        private void Button_Percent_Click(object sender, EventArgs e)
        {
            switch (dzialanie)
            {
                case 0:
                    {
                        double wynik;
                        secondInput = Convert.ToDouble(textBox2.Text);
                        temporaryNumber = (firstInput * secondInput) / 100;
                        wynik = firstInput + temporaryNumber;
                        textBox2.Text = (Convert.ToString(wynik));
                    }break;
                case 1:
                    {
                        double wynik;
                        secondInput = Convert.ToDouble(textBox2.Text);
                        temporaryNumber = (firstInput * secondInput) / 100;
                        wynik = firstInput - temporaryNumber;
                        textBox2.Text = (Convert.ToString(wynik));
                    }break;
                case 2:
                    {
                        double wynik;
                        secondInput = Convert.ToDouble(textBox2.Text);
                        temporaryNumber = (firstInput * secondInput) / 100;
                        wynik = firstInput * temporaryNumber;
                        textBox2.Text = (Convert.ToString(wynik));
                    }
                    break;
                case 3:
                    {
                        double wynik;
                        secondInput = Convert.ToDouble(textBox2.Text);
                        temporaryNumber = (firstInput * secondInput) / 100;
                        wynik = firstInput / temporaryNumber;
                        textBox2.Text = (Convert.ToString(wynik));
                    }
                    break;
            }
            
        }

        private void Button_equals_Click(object sender, EventArgs e)
        {
            switch (dzialanie)
            {
                case 0:
                    {                             
                        secondInput = Convert.ToDouble(textBox2.Text);
                        textBox2.Text = Convert.ToString(firstInput + secondInput);                       
                    }
                    break;
                case 1:
                    {
                        secondInput = Convert.ToDouble(textBox2.Text);
                        textBox2.Text = Convert.ToString(firstInput - secondInput);
                    }
                    break;
                case 2:
                    {
                        secondInput = Convert.ToDouble(textBox2.Text);
                        textBox2.Text = Convert.ToString(firstInput * secondInput);
                    }break;
                case 3:
                    {
                        if (secondInput == 0)
                        {
                            textBox2.Text = "DIV / 0 !!!";
                        }
                        else
                        {
                            secondInput = Convert.ToDouble(textBox2.Text);
                            textBox2.Text = Convert.ToString(firstInput / secondInput);
                        }
                    }break;
                case 4:
                    {
                        secondInput = Convert.ToDouble(textBox2.Text);
                        textBox2.Text = Convert.ToString(Math.Pow(firstInput,secondInput));
                    }break;
                case 5:
                    {                        
                        secondInput = Convert.ToDouble(textBox2.Text);
                        textBox2.Text = Convert.ToString(Math.Pow(firstInput, (1 / secondInput)));
                    }
                    break;
                case 6:
                    {
                        secondInput = Convert.ToDouble(textBox2.Text);
                        textBox2.Text = (Convert.ToString(firstInput % secondInput));
                    }break;
                case 7:
                    {                       
                        secondInput = Convert.ToDouble(textBox2.Text);                        
                        textBox2.Text = Convert.ToString(firstInput * Math.Pow(10,secondInput));
                        
                    }break;
            }
        }
    }
}
