using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            double a, b, c;

            lblsinal.Text = "+";

            try
            {
                a = double.Parse(txtn1.Text);
                b = double.Parse(txtn2.Text);
                c = a + b;

                lblresp.Text = c.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }
        private void btnsub_Click(object sender, EventArgs e)
        {
            double a, b, c;

            lblsinal.Text = "-";

            try
            {
                a = double.Parse(txtn1.Text);
                b = double.Parse(txtn2.Text);
                c = a - b;

                lblresp.Text = c.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            lblsinal.Text = "?";
            lblresp.Text = "?";
            txtn1.Focus();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            double a, b, c;

            lblsinal.Text = "x";

            try
            {
                a = double.Parse(txtn1.Text);
                b = double.Parse(txtn2.Text);
                c = a * b;

                lblresp.Text = c.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d;

            lblsinal.Text = " ";

            try
            {
                a = int.Parse(txtn1.Text);
                b = int.Parse(txtn2.Text);
                c = a % 2;
                d = b % 2;
                if (c == 0 | d == 0)
                {
                    lblresp.Text = "Ambos são pares";
                }
                if(c == 1 | d == 1)
                {
                    lblresp.Text = "Ambos são ímpares";
                }
                if (c == 1 | d == 0)
                {
                    a.ToString();
                    b.ToString();
                    lblresp.Text = (a+" é ímpar e "+b+" é par");
                }
                if (c == 0 | d == 1)
                {
                    c.ToString();
                    d.ToString();
                    lblresp.Text = (a + " é par e " + b + " é ímpar");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            double a, b, c;

            lblsinal.Text = "/";

            try
            {
                a = double.Parse(txtn1.Text);
                b = double.Parse(txtn2.Text);
                c = a / b;

                lblresp.Text = c.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnpot_Click(object sender, EventArgs e)
        {
            double a, b, r;

            lblsinal.Text = "^";

            try
            {
                a = double.Parse(txtn1.Text);
                b = double.Parse(txtn2.Text);

                r = a * a;

                for (int i = 2; i < b; i++)
                {
                    r = r * a;
                }


                lblresp.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btncomp_Click(object sender, EventArgs e)
        {
            double a, b;

            lblsinal.Text = "<>";

            try
            {
                a = double.Parse(txtn1.Text);
                b = double.Parse(txtn2.Text);

                if(a>b)
                {
                    a.ToString();
                    b.ToString();
                    lblresp.Text = (a+" é maior que "+b);
                }
                if (a < b)
                {
                    a.ToString();
                    b.ToString();
                    lblresp.Text = (a + " é menor que " + b);
                }
                if (a==b)
                {
                    a.ToString();
                    b.ToString();
                    lblresp.Text = (a + " é igual a " + b);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

    }
}

