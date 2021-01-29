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
        double value = 0;
        String operationPerformed = "";
        bool isOperatorPressed = false;
        public Calculator()
        {
            InitializeComponent();
            
        }

        // Create event handler for numeric buttons 0-9
        private void button_Click(object sender, EventArgs e)
        {
            if ((results.Text == "0") || (isOperatorPressed))
            {
                results.Clear();
            }

            isOperatorPressed = false;
            Button button = (Button)sender;

            // So user can only enter 1 decimal
            if (button.Text == ".")
            {
                if (!results.Text.Contains("."))
                {
                    results.Text += button.Text;
                }
            }
            else
            {
                results.Text += button.Text;
            }
            
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            if (results.Text.Length > 0)
            {
                results.Text = results.Text.Remove(results.Text.Length - 1, 1); // removes 1 at a time
            }
        }

        // Create event handler for math operators(+,-,*,/)
        private void operations(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Perform multiple operations without having to hit equals before next operator
            if (value != 0)
            {
                buttonEquals.PerformClick();
                isOperatorPressed = true;
                operationPerformed = button.Text;
                equationText.Text = value + " " + operationPerformed;
            }
            else
            {
                operationPerformed = button.Text;
                value = double.Parse(results.Text);
                isOperatorPressed = true;
                equationText.Text = value + " " + operationPerformed;
            }
            
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            
            equationText.Text = "";
            switch (operationPerformed)
            {
                case "+":
                    results.Text = (value + Double.Parse(results.Text)).ToString();
                    break;

                case "-":
                    results.Text = (value - Double.Parse(results.Text)).ToString();
                    break;

                case "*":
                    results.Text = (value * Double.Parse(results.Text)).ToString();
                    break;

                case "/":
                    results.Text = (value / Double.Parse(results.Text)).ToString();
                    break;

                default:
                    break;
            }
            value = Double.Parse(results.Text);
            operationPerformed = "";
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            results.Text = "0";
            value = 0;
            equationText.Text = ""; // clears the label too
            
        }
        
        // Enable keyboard usage
        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            switch (e.KeyChar.ToString())
            {
                
                // Number Pad 0-9
                case "0":
                    buttonZero.PerformClick();
                    this.Focus();
                    break;

                case "1":
                    buttonOne.PerformClick();
                    this.Focus();
                    break;

                case "2":
                    buttonTwo.PerformClick();
                    this.Focus();
                    break;

                case "3":
                    buttonThree.PerformClick();
                    this.Focus();
                    break;

                case "4":
                    buttonFour.PerformClick();
                    this.Focus();
                    break;

                case "5":
                    buttonFive.PerformClick();
                    this.Focus();
                    break;

                case "6":
                    buttonSix.PerformClick();
                    this.Focus();
                    break;

                case "7":
                    buttonSeven.PerformClick();
                    this.Focus();
                    break;

                case "8":
                    buttonEight.PerformClick();
                    this.Focus();
                    break;

                case "9":
                    buttonNine.PerformClick();
                    this.Focus();
                    break;

                // Math Operators
                case "+":
                    buttonAdd.PerformClick();
                    break;

                case "-":
                    buttonSubtract.PerformClick();
                    break;

                case "*":
                    buttonMultiply.PerformClick();
                    break;

                case "/":
                    buttonDivide.PerformClick();
                    break;

                case "ENTER":
                    buttonEquals.PerformClick();    // counldn't get to work correctly
                    break;

                default:
                    break;

            }
        }
        

        // Square Root button
        private void buttonSQRT_Click(object sender, EventArgs e)
        {
            results.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(results.Text)));
        }
        
        // x^2 button
        private void buttonSquared_Click(object sender, EventArgs e)
        {
            results.Text = Convert.ToString(Convert.ToInt32(results.Text) * Convert.ToInt32(results.Text));
        }

        // +/- button
        private void buttonPosNeg_Click(object sender, EventArgs e)
        {
            results.Text = Convert.ToString(-Convert.ToInt32(results.Text));
        }

        // PI button
        private void buttonPI_Click(object sender, EventArgs e)
        {
            results.Text = Convert.ToString(Math.PI);
        }

    }// end of form

    }// end of class
