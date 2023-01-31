using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Result { get; set; }
        public decimal value { get; set; }
        private Operation OpSelected;
        private enum Operation
        {
            Addition,
            Subtraction,
            Multiplication,
            Division,
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }

        //
        private void buttonZero(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void buttonOne(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void buttonTwo(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void buttonThree(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void buttonFour(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void buttonFive(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void buttonSix(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }
        private void buttonSeven(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }
        private void buttonEight(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }     
        private void buttonNine(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void buttonComma(object sender, EventArgs e)
        {
            if(!txtResult.Text.Contains(".") ) { 
            txtResult.Text += ".";
            }
        }
        private void buttonSum(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                OpSelected = Operation.Addition;
                lblOperacao.Text = "+";
                value = Convert.ToDecimal(txtResult.Text);
                txtResult.Text = "";
            }
            else
            {
                MessageBox.Show("Error, enter a value to perform the sum");
            }
        }
        private void buttonSubtraction(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                OpSelected = Operation.Subtraction;
                lblOperacao.Text = "-";
                value = Convert.ToDecimal(txtResult.Text);
                txtResult.Text = "";

            }
            else
            {
                MessageBox.Show("Error, enter a value to perform the subtraction");
            }
        }
        private void buttonMultiplication(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                OpSelected = Operation.Multiplication;
                lblOperacao.Text = "x";
                value = Convert.ToDecimal(txtResult.Text);
                txtResult.Text = "";
                    
            }
            else
            {
                MessageBox.Show("Error, inform a value to perform the Multiplication");
            }
        }

        private void buttonDivision(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                OpSelected = Operation.Division;
                lblOperacao.Text = "/";
                value = Convert.ToDecimal(txtResult.Text);
                txtResult.Text = "";

            }
            else
            {
                MessageBox.Show("Error, enter a value to perform the division");
            }
        }

        private void buttonDeleteTxtResult(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void buttonDeleteAll(object sender, EventArgs e)
        {
            txtResult.Text = "";
            value = 0;
            lblOperacao.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEqual(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                lblOperacao.Text = "=";
                switch (OpSelected)
                {
                    case Operation.Addition:
                        Result = value + Convert.ToDecimal( txtResult.Text);

                        break;
                    case Operation.Subtraction:
                        Result = value - Convert.ToDecimal(txtResult.Text);

                        break;
                    case Operation.Multiplication:
                        Result = value *  Convert.ToDecimal( txtResult.Text);

                        break;
                    case Operation.Division:
                        Result = value / Convert.ToDecimal(txtResult.Text);

                        break;

                 }
                txtResult.Text = Convert.ToString(Result);
                
            }
            else
            {
                MessageBox.Show("Error!!! Report an Operation");
            }
            
        }        
    }
}
