namespace Pr03BankInterest
{
    public partial class frmBackAccount : Form
    {
        private double monthlyDeposit, yearInterest, finalBalance, interestRate;
        private int numberMonths;

        public frmBackAccount()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void clearTextBoxes()
        {
            tbFinalBalance.Text = "";
            tbMonthlyDeposit.Text = "";
            tbNumberMonths.Text = "";
            tbYearlyInterest.Text = "";
        }

        private void checkDecimalNumber(KeyPressEventArgs e, TextBox textBox)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 13 /*Enter*/ || e.KeyChar == 8 /*backspace*/ )
            {
                e.Handled = false;
                if (textBox.Text.StartsWith("."))
                {
                    textBox.Text = "0" + textBox.Text;
                    textBox.SelectionStart = textBox.TextLength;
                }
            }
            else if (e.KeyChar == ',')
            {
                if ((textBox.Text.IndexOf(",") == -1))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Only one decimal comma allowed.");
                }
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = true;
                MessageBox.Show("Please, use a comma insted of a dot for decimal numbers.");
            }
            else
            {

                MessageBox.Show("Only decimal numbers are allowed.");
                e.Handled = true;
            }
        }

        private void checkIntegerNumbers(KeyPressEventArgs e, TextBox textBox)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 13 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Only integer numbers are allowed.");
                e.Handled = true;
            }
        }

        private bool areCheckBoxesNotEmpty()
        {
            if (tbMonthlyDeposit.Text.Length > 0)
            {
                monthlyDeposit = Convert.ToDouble(tbMonthlyDeposit.Text);
            }
            else
            {
                MessageBox.Show("Please insert a monthly deposit.");
                tbMonthlyDeposit.Focus();
                return false;
            }

            if (tbYearlyInterest.Text.Length > 0)
            {
                yearInterest = Convert.ToDouble(tbYearlyInterest.Text);
            }
            else
            {
                MessageBox.Show("Please insert a year interest.");
                tbYearlyInterest.Focus();
                return false;
            }

            if (tbNumberMonths.Text == "0")
            {
                MessageBox.Show("Please, the number of months must be greater than zero.");
                tbNumberMonths.Text = "";
                tbNumberMonths.Focus();
                return false;
            }
            else if (tbNumberMonths.Text.Length > 0)
            {
                numberMonths = Convert.ToInt32(tbNumberMonths.Text);
            }
            else
            {
                MessageBox.Show("Please insert the number of months.");
                tbNumberMonths.Focus();
                return false;
            }

            return true;
        }

        private void tbMonthlyDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDecimalNumber(e, tbMonthlyDeposit);
            if (e.KeyChar == 13)
            {
                tbYearlyInterest.Focus();
            }
        }

        private void tbYearlyInterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDecimalNumber(e, tbYearlyInterest);
            if (e.KeyChar == 13) tbNumberMonths.Focus();
        }

        private void tbNumberMonths_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkIntegerNumbers(e, tbNumberMonths);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {            
            if (areCheckBoxesNotEmpty())
            {
                interestRate = yearInterest / 1200;

                if (interestRate == 0)
                {
                    finalBalance = monthlyDeposit * numberMonths;
                }
                else
                {
                    finalBalance = monthlyDeposit * (Math.Pow( (1 + interestRate), numberMonths) - 1) / interestRate;
                    //tbFinalBalance.Text = finalBalance.ToString();
                }

                tbFinalBalance.Text = String.Format("{0:f2}", finalBalance);
            }
        }
    }
}
