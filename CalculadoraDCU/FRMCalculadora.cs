using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PSLunes
{
    public partial class FRMCalculadora : Form
    {
        public FRMCalculadora()
        {
            InitializeComponent();
        }

        string operand1;
        string operand2;

        string input;
        string operation;
        double result;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {

        }

        private void btn01_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void btn08_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void btn09_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
            textBox1.Text = "";
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = "*";
            input = string.Empty;
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = "/";
            input = string.Empty;
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = "-";
            input = string.Empty;
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = "+";
            input = string.Empty;
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;

            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);   

            if (operation == "+")
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == "-")
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
        
            else if (operation == "*")
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == "/")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "No se divide entre 0";

                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRMCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
