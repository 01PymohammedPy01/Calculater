using System;
using System.Windows.Forms;
using Tier2Layer;

namespace Calculater
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        enum enOperations { Add = 1, Subtract = 2, Multiply = 3, Divide = 4 }

        public decimal Number1 = 0;
        public decimal Number2 = 0;
        enOperations Operator;

        private bool _DigitState = false;           // True = next digit overwrites screen
        private bool _hasPendingOperation = false;  // True = an operator was previously selected

        void DigitClick(object sender, EventArgs e)
        {
            Button ClickedDigit = (Button)sender;

            if (_DigitState)
            {
                txtbxResult.Text = ClickedDigit.Tag.ToString();
                _DigitState = false;
            }
            else
            {
                txtbxResult.Text += ClickedDigit.Tag.ToString();
            }
        }

        void StartCalculate(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxResult.Text) || txtbxResult.Text == "Cannot Divide By Zero") return;

            Button TheOperator = (Button)sender;
            enOperations selectedOp = (enOperations)Convert.ToInt32(TheOperator.Tag);

            // Case 1: Changing mind on operator (e.g., pressed + then immediately -)
            if (_DigitState && _hasPendingOperation)
            {
                Operator = selectedOp;
                lblResult.Text = Number1.ToString() + " " + TheOperator.Text;
                return;
            }

            // Case 2: Continuous chaining (e.g., 5 + 3 + 2)
            if (_hasPendingOperation)
            {
                Number2 = decimal.Parse(txtbxResult.Text);
                Number1 = ExecuteMath(Number1, Number2, Operator);
                txtbxResult.Text = Number1.ToString();
            }
            else
            {
                // First operator click in a new calculation
                Number1 = decimal.Parse(txtbxResult.Text);
            }

            Operator = selectedOp;
            _hasPendingOperation = true;
            _DigitState = true;
            lblResult.Text = Number1.ToString() + " " + TheOperator.Text;
        }

        private void btnResult_Click(object sender, EventArgs e) // Equals (=) Button
        {
            if (string.IsNullOrWhiteSpace(txtbxResult.Text) || !_hasPendingOperation) return;

            Number2 = decimal.Parse(txtbxResult.Text);
            lblResult.Text = $"{Number1} {GetOperatorSymbol(Operator)} {Number2} =";

            decimal result = ExecuteMath(Number1, Number2, Operator);

            txtbxResult.Text = result.ToString();
            Number1 = result;
            _hasPendingOperation = false;
            _DigitState = true;
        }

        // Shared calculation helper (DRY principle)
        private decimal ExecuteMath(decimal num1, decimal num2, enOperations op)
        {
            switch (op)
            {
                case enOperations.Add:
                    return clsMathOperations.Add(num1, num2);
                case enOperations.Subtract:
                    return clsMathOperations.Subtract(num1, num2);
                case enOperations.Multiply:
                    return clsMathOperations.Multiply(num1, num2);
                case enOperations.Divide:
                    if (num2 == 0)
                    {
                        txtbxResult.Text = "Cannot Divide By Zero";
                        return 0;
                    }
                    return clsMathOperations.Divide(num1, num2);
                default:
                    return num2;
            }
        }

        private string GetOperatorSymbol(enOperations op)
        {
            switch (op)
            {
                case enOperations.Add: return "+";
                case enOperations.Subtract: return "-";
                case enOperations.Multiply: return "*";
                case enOperations.Divide: return "/";
                default: return "";
            }
        }
    }
}