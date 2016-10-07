using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCal
{
    public partial class Calculator : Form
    {
        private string Formula;

        public Calculator()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            formulaRichTextBox.Text += "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            formulaRichTextBox.Text += "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            formulaRichTextBox.Text += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            formulaRichTextBox.Text += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            formulaRichTextBox.Text += "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            formulaRichTextBox.Text += "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            formulaRichTextBox.Text += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            formulaRichTextBox.Text += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            formulaRichTextBox.Text += "9";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            formulaRichTextBox.Text += "0";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            formulaRichTextBox.Text += "+";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            formulaRichTextBox.Text += "-";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            formulaRichTextBox.Text += "*";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            formulaRichTextBox.Text += "/";
        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            formulaRichTextBox.Text += "%";
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            formulaRichTextBox.Text += ".";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            Formula = formulaRichTextBox.Text;
            formulaRichTextBox.Text = CalculateAnswer(Formula).ToString();
        }

        private double CalculateAnswer(string formula)
        {
            if(formula.Contains("+"))
            {
                var piecesOfFormula = formula.Split('+');
                return Convert.ToDouble(piecesOfFormula[0]) + Convert.ToDouble(piecesOfFormula[1]);
            }
            else if(formula.Contains("-"))
            {
                var piecesOfFormula = formula.Split('-');
                return Convert.ToDouble(piecesOfFormula[0]) - Convert.ToDouble(piecesOfFormula[1]);
            }
            else if(formula.Contains("*"))
            {
                var piecesOfFormula = formula.Split('*');
                return Convert.ToDouble(piecesOfFormula[0]) * Convert.ToDouble(piecesOfFormula[1]);
            }
            else if(formula.Contains("/"))
            {
                var piecesOfFormula = formula.Split('/');
                return Convert.ToDouble(piecesOfFormula[0]) / Convert.ToDouble(piecesOfFormula[1]);
            }
            else
            {
                formulaRichTextBox.Text = "";
                formula = "";
                return 0;
            }
        }
    }
}
