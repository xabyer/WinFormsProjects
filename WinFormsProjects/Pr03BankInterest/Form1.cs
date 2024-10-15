namespace Pr03BankInterest
{
    public partial class frmBackAccount : Form
    {
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
            else if (e.KeyChar == '.')
            {
                if ((textBox.Text.IndexOf(".") == -1))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Only one decimal dot allowed.");
                }
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = true;
                MessageBox.Show("Please, use a dot insted of a comma for decimal numbers.");
            }
            else
            {

                MessageBox.Show("Only decimal numbers are allowed.");
                e.Handled = true;
            }
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
            if(e.KeyChar == 13) tbNumberMonths.Focus();
        }
    }
}
