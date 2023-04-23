using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sebastian_Stanislawek_Kalkulator
{
    public partial class Form1 : Form
    {
        Double wynik = 0;
        String operacja = "";
        bool wpisana_wartosc = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (!textBox1.Text.Contains("-"))
                {
                    if ((textBox1.Text == "0") || (wpisana_wartosc))
                    {
                        textBox1.Text = "";
                        wpisana_wartosc = false;
                    }
                    textBox1.Text = "-" + textBox1.Text;
                }
                else if (textBox1.Text.Contains("-"))
                {
                    if ((textBox1.Text == "0") || (wpisana_wartosc))
                    {
                        textBox1.Text = "";
                        wpisana_wartosc = false;
                    }

                    textBox1.Text = textBox1.Text.Substring(1, textBox1.Text.Length - 1);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (wpisana_wartosc))
                textBox1.Text = "";
            wpisana_wartosc = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (wpisana_wartosc))
                textBox1.Text = "";
            wpisana_wartosc = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (wpisana_wartosc))
                textBox1.Text = "";
            wpisana_wartosc = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operacja = num.Text;
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("*") || label2.Text.Contains("/"))
            {

                label2.Text = label2.Text.Remove(label2.Text.Length - 1) + operacja;
            }
            else
            {

                wynik = Double.Parse(textBox1.Text);
                textBox1.Text = "0";
                label2.Text = System.Convert.ToString(wynik) + " " + operacja;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (wpisana_wartosc))
                textBox1.Text = "";
            wpisana_wartosc = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (wpisana_wartosc))
                textBox1.Text = "";
            wpisana_wartosc = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (wpisana_wartosc))
                textBox1.Text = "";
            wpisana_wartosc = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operacja = num.Text;
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("*") || label2.Text.Contains("/"))
            {

                label2.Text = label2.Text.Remove(label2.Text.Length - 1) + operacja;
            }
            else
            {

                wynik = Double.Parse(textBox1.Text);
                textBox1.Text = "0";
                label2.Text = System.Convert.ToString(wynik) + " " + operacja;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (wpisana_wartosc))
                textBox1.Text = "";
            wpisana_wartosc = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (wpisana_wartosc))
                textBox1.Text = "";
            wpisana_wartosc = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (wpisana_wartosc))
                textBox1.Text = "";
            wpisana_wartosc = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operacja = num.Text;
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("*") || label2.Text.Contains("/"))
            {

                label2.Text = label2.Text.Remove(label2.Text.Length - 1) + operacja;
            }
            else
            {

                wynik = Double.Parse(textBox1.Text);
                textBox1.Text = "0";
                label2.Text = System.Convert.ToString(wynik) + " " + operacja;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (wpisana_wartosc))
                textBox1.Text = "";
            wpisana_wartosc = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (wpisana_wartosc))
                textBox1.Text = "";
            wpisana_wartosc = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            switch (operacja)
            {
                case "+":
                    textBox1.Text = (wynik + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (wynik - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (wynik * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (wynik / Double.Parse(textBox1.Text)).ToString();
                    break;
                    double i = Double.Parse(textBox1.Text);
                    double q;
                    q = (wynik);
                    textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operacja = num.Text;
            if (label2.Text.Contains("+") || label2.Text.Contains("-") || label2.Text.Contains("*") || label2.Text.Contains("/"))
            {

                label2.Text = label2.Text.Remove(label2.Text.Length - 1) + operacja;
            }
            else
            {

                wynik = Double.Parse(textBox1.Text);
                textBox1.Text = "0";
                label2.Text = System.Convert.ToString(wynik) + " " + operacja;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.14159265359";
        }



        private void button27_Click(object sender, EventArgs e)
        {
            double asin = Double.Parse(textBox1.Text);
            label2.Text = System.Convert.ToString("sin" + "(" + (textBox1.Text) + ")");
            asin = Math.Sin(asin);
            textBox1.Text = System.Convert.ToString(asin);
        }


        private void button38_Click(object sender, EventArgs e)
        {
            long f = 1;

            for (long i = 1; i <= long.Parse(textBox1.Text); i++)
            {
                f = f * i;
            }
            textBox1.Text = f.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Double y;
            y = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(y);
        }


        private void button29_Click(object sender, EventArgs e)
        {
            Double b;
            b = Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(b);
        }


        private void button37_Click(object sender, EventArgs e)
        {
            Double y;
            y = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(y);
        }

        private void standardowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 303;
            textBox1.Width = 266;
        }

        private void naukowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 600;
            textBox1.Width = 560;
        }

        private void button33_Click(object sender, EventArgs e)
        {

        }
    }
}
