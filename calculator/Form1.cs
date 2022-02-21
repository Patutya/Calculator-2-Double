using System;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string a = ""; 
        string b = "";
        string c = "";
        double d = 0;
        int j = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, System.EventArgs e)
        {
            if (j == 0)
            {
                a += "1";
                lblfirst.Text = a;
            }
            else if (j == 1)
            {
                b += "1";
                lblsecond.Text = b;
            }
        }

        private void btn2_Click(object sender, System.EventArgs e)
        {
            if (j == 0)
            {
                a += "2";
                lblfirst.Text = a;
            }
            else if (j == 1)
            {
                b += "2";
                lblsecond.Text = b;
            }
        }

        private void btn3_Click(object sender, System.EventArgs e)
        {
            if (j == 0)
            {
                a += "3";
                lblfirst.Text = a;

            }
            else if (j == 1)
            {
                b += "3";
                lblsecond.Text = b;
            }
        }

        private void btnadd_Click(object sender, System.EventArgs e)
        {
            if (j == 0)
            {
                c = "+";
                j = 1;
                lblchar.Text = c;
            }
        }

        private void btnequal_Click(object sender, System.EventArgs e)
        {
            if (j == 1)
            {
                switch (c)
                {
                    case "+":
                        d = Convert.ToDouble(a) + Convert.ToDouble(b);
                        lblansw.Text = Convert.ToString(d);
                        break;
                    case "-":
                        d = Convert.ToDouble(a) - Convert.ToDouble(b);
                        lblansw.Text = Convert.ToString(d);
                        break;
                    case "X":
                        d = Convert.ToDouble(a) * Convert.ToDouble(b);
                        lblansw.Text = Convert.ToString(d);
                        break;
                    case "/":
                        d = Convert.ToDouble(a) / Convert.ToDouble(b);
                        lblansw.Text = Convert.ToString(d);
                        break;
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            a = "";
            b = "";
            c = "";
            d = 0;
            j = 0;
            lblansw.Text = "";
            lblfirst.Text = "";
            lblsecond.Text = "";
            lblchar.Text = "";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                a += "4";
                lblfirst.Text = a;

            }
            else if (j == 1)
            {
                b += "4";
                lblsecond.Text = b;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                a += "5";
                lblfirst.Text = a;

            }
            else if (j == 1)
            {
                b += "5";
                lblsecond.Text = b;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                a += "6";
                lblfirst.Text = a;

            }
            else if (j == 1)
            {
                b += "6";
                lblsecond.Text = b;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                a += "7";
                lblfirst.Text = a;

            }
            else if (j == 1)
            {
                b += "7";
                lblsecond.Text = b;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                a += "8";
                lblfirst.Text = a;

            }
            else if (j == 1)
            {
                b += "8";
                lblsecond.Text = b;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                a += "9";
                lblfirst.Text = a;

            }
            else if (j == 1)
            {
                b += "9";
                lblsecond.Text = b;
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                c = "-";
                j = 1;
                lblchar.Text = c;
            }
        }

        private void btnmulty_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                c = "X";
                j = 1;
                lblchar.Text = c;
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                c = "/";
                j = 1;
                lblchar.Text = c;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
