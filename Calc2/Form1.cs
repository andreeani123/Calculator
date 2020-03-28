using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc2
{
    public partial class Calculator : Form
    {

        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        Boolean ok = false;

        public Calculator()
        {
            InitializeComponent();
            zero.Click += new EventHandler(zero_Click);
            unu.Click += new EventHandler(unu_Click);
            doi.Click += new EventHandler(doi_Click);
            trei.Click += new EventHandler(trei_Click);
            patru.Click += new EventHandler(patru_Click);
            cinci.Click += new EventHandler(cinci_Click);
            sase.Click += new EventHandler(sase_Click);
            sapte.Click += new EventHandler(sapte_Click);
            opt.Click += new EventHandler(opt_Click);
            noua.Click += new EventHandler(noua_Click);
            pct.Click += new EventHandler(pct_Click);
            clear.Click += new EventHandler(clear_Click);
            plus.Click += new EventHandler(plus_Click);
            minus.Click += new EventHandler(minus_Click);
            mult.Click += new EventHandler(mult_Click);
            div.Click += new EventHandler(div_Click);
            equals.Click += new EventHandler(equals_Click);
        }

        protected void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "0";
            this.textBox1.Text += "0";
        }

        private void unu_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "1";
            this.textBox1.Text += "1";

        }

        private void doi_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "2";
            this.textBox1.Text += "2";
        }

        private void trei_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "3";
            this.textBox1.Text += "3";
        }

        private void patru_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "4";
            this.textBox1.Text += "4";
        }

        private void cinci_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "5";
            this.textBox1.Text += "5";
        }

        private void sase_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "6";
            this.textBox1.Text += "6";
        }

        private void sapte_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "7";
            this.textBox1.Text += "7";
        }

        private void opt_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "8";
            this.textBox1.Text += "8";
        }

        private void noua_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "9";
            this.textBox1.Text += "9";
        }

        private void pct_Click(object sender, EventArgs e)
        {
            if (ok == false)
            {
                this.textBox1.Text += "";
                input += ".";
                this.textBox1.Text += ".";
                ok = true;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            operand1 = input;
            operation = '+';
            input = string.Empty;
            ok = false;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            operand1 = input;
            operation = '-';
            input = string.Empty;
            ok = false;
        }

        private void div_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            operand1 = input;
            operation = '/';
            input = string.Empty;
            ok = false;
        }

        private void mult_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            operand1 = input;
            operation = '*';
            input = string.Empty;
            ok = false;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            ok = false;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "Error";
                }

            }

            input = result.ToString();
            ok = false;

        }

    }
}