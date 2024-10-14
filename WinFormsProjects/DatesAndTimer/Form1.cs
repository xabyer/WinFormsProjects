namespace DatesAndTimer
{
    public partial class frmDatesTimer : Form
    {
        private DateTime today;
        public frmDatesTimer()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timTime.Enabled = true;
            setTime();
        }

        private void timTime_Tick(object sender, EventArgs e)
        {
            setTime();
        }

        private void setTime()
        {
            today = DateTime.Now;
            lblDayOfWeek.Text = today.DayOfWeek.ToString();
            lblDayOfMonth.Text = today.Day.ToString();
            lblMonth.Text = today.ToString("MMMM");
            lblYear.Text = today.Year.ToString();
            lblTime.Text = today.ToLongTimeString();
        }
    }
}
