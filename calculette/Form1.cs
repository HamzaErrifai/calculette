using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculette
{
    public partial class Form1 : Form
    {
        private string lvalue = "";
        string operation = "";
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = textShow; // set the focus to the textbox
        }

        private int calc()
        {
            if (operation == "+")
                return int.Parse(lvalue) + int.Parse(textShow.Text);
            else if (operation == "-")
                return int.Parse(lvalue) - int.Parse(textShow.Text);
            else if (operation == "*")
                return int.Parse(lvalue) * int.Parse(textShow.Text);
            else if (operation == "/")
                return int.Parse(lvalue) / int.Parse(textShow.Text);
            return 0;
        }

        private void _click(string btnVal)
        {
            if (btnVal == "+" || btnVal == "-" || btnVal == "/" || btnVal == "*")
            {
                lvalue = textShow.Text;
                operation = btnVal;
                textShow.Text = "";
            }
            else if (btnVal == "=")
            {
                int result = calc();
                textShow.Text = "";
                _click(result.ToString());
            }
            else if(btnVal == "clear")
            {
                operation = "";
                textShow.Text = "";
                lvalue = "";
            }
            else
                textShow.Text += btnVal;
        } 

        private void btn1_Click(object sender, EventArgs e)
        {
            _click("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            _click("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            _click("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            _click("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            _click("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            _click("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            _click("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            _click("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            _click("9");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _click("clear");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            _click("/");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            _click("*");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            _click("-");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            _click("+");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            _click("=");   
        }

        private void textShow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '+') 
                _click("+");
            if (e.KeyChar == '-')
                _click("-");
            if (e.KeyChar == '/')
                _click("/");
            if (e.KeyChar == '*')
                _click("*");
            if (e.KeyChar == 13)
            {
                e.Handled = true; //to prevent default
                _click("=");
            }
            if (e.KeyChar == 27)
            {
                e.Handled = true;
                _click("clear");
            }
            if(e.KeyChar == 23)
                this.Close();

        }


    }
}
