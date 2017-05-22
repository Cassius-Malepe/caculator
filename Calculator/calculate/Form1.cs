using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            input.Text += " 1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            input.Text += " 2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            input.Text += " 3";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            input.Text += " 4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            input.Text += " 5";
        }

        private void tbn_6_Click(object sender, EventArgs e)
        {
            input.Text += " 6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            input.Text += " 7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            input.Text += " 8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            input.Text += " 9";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            input.Text += " 0";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            input.Text += " +";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            input.Text += " -";
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            input.Text += " *";
        }

        private void btn_devide_Click(object sender, EventArgs e)
        {
            input.Text += " /";
        }

        private void compute_Click(object sender, EventArgs e)
        {
            var sum = GetOperands('+', input.Text);
            MessageBox.Show(sum.ToString());

        }

        double sum = 0;
        double left1 = 0;
        double GetOperands(char signOperator, string input)//out string left, out string right)
        {
            
            string left = "0"; string right = "0";
            var indexOrSign = input.IndexOf(signOperator);
            if (indexOrSign != -1)
            {
                left = input.Substring(0, indexOrSign);
                right = input.Substring(indexOrSign + 1);
               
                var result = GetOperands(signOperator, right);
                sum += result;
                return sum;
            }
            else
            {
                switch (signOperator)
                {
                    case '+':
                        return left1 + double.Parse(input);
                    case '*':
                        return left1 * double.Parse(input);
                    case '-':
                        return left1 - double.Parse(input);
                    case '/':
                        return left1 / double.Parse(input);

                    default:
                        return 0;

                }

            }


        }

        //BO DMAS
    }
}
