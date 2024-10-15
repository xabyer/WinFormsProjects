namespace Pr03BankInterest
{
    partial class frmBackAccount
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbMonthlyDeposit = new TextBox();
            tbYearlyInterest = new TextBox();
            tbNumberMonths = new TextBox();
            tbFinalBalance = new TextBox();
            lblMontlyDeposit = new Label();
            lblYearlyInterest = new Label();
            lblNumberMonths = new Label();
            lblFinalBalance = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // tbMonthlyDeposit
            // 
            tbMonthlyDeposit.Location = new Point(152, 49);
            tbMonthlyDeposit.Name = "tbMonthlyDeposit";
            tbMonthlyDeposit.Size = new Size(152, 23);
            tbMonthlyDeposit.TabIndex = 0;
            // 
            // tbYearlyInterest
            // 
            tbYearlyInterest.Location = new Point(152, 95);
            tbYearlyInterest.Name = "tbYearlyInterest";
            tbYearlyInterest.Size = new Size(152, 23);
            tbYearlyInterest.TabIndex = 1;
            // 
            // tbNumberMonths
            // 
            tbNumberMonths.Location = new Point(152, 148);
            tbNumberMonths.Name = "tbNumberMonths";
            tbNumberMonths.Size = new Size(152, 23);
            tbNumberMonths.TabIndex = 2;
            // 
            // tbFinalBalance
            // 
            tbFinalBalance.Location = new Point(152, 209);
            tbFinalBalance.Name = "tbFinalBalance";
            tbFinalBalance.Size = new Size(152, 23);
            tbFinalBalance.TabIndex = 3;
            // 
            // lblMontlyDeposit
            // 
            lblMontlyDeposit.AutoSize = true;
            lblMontlyDeposit.Location = new Point(51, 52);
            lblMontlyDeposit.Name = "lblMontlyDeposit";
            lblMontlyDeposit.Size = new Size(95, 15);
            lblMontlyDeposit.TabIndex = 4;
            lblMontlyDeposit.Text = "Monthly Deposit";
            // 
            // lblYearlyInterest
            // 
            lblYearlyInterest.AutoSize = true;
            lblYearlyInterest.Location = new Point(66, 98);
            lblYearlyInterest.Name = "lblYearlyInterest";
            lblYearlyInterest.Size = new Size(80, 15);
            lblYearlyInterest.TabIndex = 5;
            lblYearlyInterest.Text = "Yearly Interest";
            // 
            // lblNumberMonths
            // 
            lblNumberMonths.AutoSize = true;
            lblNumberMonths.Location = new Point(37, 151);
            lblNumberMonths.Name = "lblNumberMonths";
            lblNumberMonths.Size = new Size(109, 15);
            lblNumberMonths.TabIndex = 6;
            lblNumberMonths.Text = "Number of Months";
            // 
            // lblFinalBalance
            // 
            lblFinalBalance.AutoSize = true;
            lblFinalBalance.Location = new Point(70, 212);
            lblFinalBalance.Name = "lblFinalBalance";
            lblFinalBalance.Size = new Size(76, 15);
            lblFinalBalance.TabIndex = 7;
            lblFinalBalance.Text = "Final Balance";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(71, 284);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(210, 284);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear Boxes";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.Location = new Point(0, 370);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(370, 59);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmBackAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 429);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lblFinalBalance);
            Controls.Add(lblNumberMonths);
            Controls.Add(lblYearlyInterest);
            Controls.Add(lblMontlyDeposit);
            Controls.Add(tbFinalBalance);
            Controls.Add(tbNumberMonths);
            Controls.Add(tbYearlyInterest);
            Controls.Add(tbMonthlyDeposit);
            Name = "frmBackAccount";
            Text = "Bank Account Interest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMonthlyDeposit;
        private TextBox tbYearlyInterest;
        private TextBox tbNumberMonths;
        private TextBox tbFinalBalance;
        private Label lblMontlyDeposit;
        private Label lblYearlyInterest;
        private Label lblNumberMonths;
        private Label lblFinalBalance;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
