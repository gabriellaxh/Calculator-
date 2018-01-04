using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += 0;
            this.textBox.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += 1;
            this.textBox.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += 2;
            this.textBox.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += 3;
            this.textBox.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += 4;
            this.textBox.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += 5;
            this.textBox.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += 6;
            this.textBox.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += 7;
            this.textBox.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += 8;
            this.textBox.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += 9;
            this.textBox.Text += input;
        }

        private void point_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void pi_Click(object sender, EventArgs e)
        {
            input += 3.14159265359;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            this.textBox.Text = input;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;

        }

        private void division_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void addition_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void substraction_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '√';
        }

        private void percent_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '%';
        }

        private void power_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '^';
            input = string.Empty;
        }

        private void dash_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1;
            double num2;

            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox.Text = result.ToString();
            }

            else if (operation == '-')
            {
                result = num1 - num2;
                textBox.Text = result.ToString();
            }

            else if (operation == '*')
            {
                result = num1 * num2;
                textBox.Text = result.ToString();
            }

            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox.Text = result.ToString();
                }
                else
                {
                    textBox.Text = "Zero!";
                }
            }
            else if (operation == '√')
            {
                var parsedInput = double.Parse(input);

                result = Math.Sqrt(parsedInput);
                textBox.Text = result.ToString();

            }
            else if (operation == '%')
            {
                result = double.Parse(input) / 100.0;
                textBox.Text = result.ToString();
            }
            else if(operation == '^')
            {
                operand2 = input;
                double numm1;
                int numm2;
                double.TryParse(operand1, out numm1);
                int.TryParse(operand2, out numm2);

                var powered = 1.0;
                for (int i = 0; i < numm2; i++)
                {
                    powered *= numm1;
                }
                result = powered;
                textBox.Text = result.ToString();
            }
        }

        
    }
}
