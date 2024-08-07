using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class frmQuickWithdraw : Form
    {
        public frmQuickWithdraw()
        {
            InitializeComponent();

            _ShowClientBalance();
        }

        private void _ShowClientBalance()
        {
            lblBalance.Text = clsGlobal.CurrentClient.AccountBalance.ToString();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Button btnAmountToWithdraw = (Button)sender;
            decimal amountToWithdraw = decimal.Parse(btnAmountToWithdraw.Tag.ToString());

            WithdrawAmount(amountToWithdraw);
        }

        private void WithdrawAmount(decimal amountToWithdraw)
        {
            if (amountToWithdraw > clsGlobal.CurrentClient.AccountBalance)
            {
                MessageBox.Show("The amount exceeds your balance. Please make another choice.", "Exceeds amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to perform this transaction?", "Withdraw", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
                return;

            if (clsGlobal.CurrentClient.Withdraw(amountToWithdraw))
            {
                lblBalance.Text = clsGlobal.CurrentClient.AccountBalance.ToString();
                MessageBox.Show("Your new balance is " + clsGlobal.CurrentClient.AccountBalance.ToString());
            }
            else
            {
                MessageBox.Show("Transaction failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}