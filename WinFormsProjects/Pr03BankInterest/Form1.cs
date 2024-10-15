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
    }
}
