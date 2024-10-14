namespace Pr01StopWatch
{
    public partial class frmMainForm : Form
    {
        private DateTime start;
        private DateTime stop;
        private TimeSpan elapsedTime;
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            tbStartTime.Text = start.ToLongTimeString();


            //Second and next executions:
            tbStopTime.Text = "";
            tbElapsedTime.Text = "";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = DateTime.Now;
            tbStopTime.Text = stop.ToLongTimeString();

            elapsedTime = stop - start;
            tbElapsedTime.Text = elapsedTime.Seconds.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool btnStopIsEnabled()
        {
            if (tbStartTime.Text == null || tbStartTime.Text.Length == 0)
            {
                btnStop.Enabled = false;
                return false;
            }
            else
            {
                btnStop.Enabled = true;
                return true;
            }
        }

        private void tbStartTime_TextChanged(object sender, EventArgs e)
        {
            btnStopIsEnabled();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbStartTime.Text = "";
            tbStopTime.Text = "";
            tbElapsedTime.Text = "";
        }
    }
}
