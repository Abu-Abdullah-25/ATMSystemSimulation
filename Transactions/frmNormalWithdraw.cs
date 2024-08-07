using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class frmNormalWithdraw : Form
    {
        public frmNormalWithdraw()
        {
            InitializeComponent();
        }


        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // Get the withdrawal amount entered by the user
            decimal amountToWithdraw;
            if (!decimal.TryParse(txtWithdrawAmount.Text, out amountToWithdraw))
            {
                MessageBox.Show("Please enter a valid amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the amount is a multiple of 5
            if (amountToWithdraw % 5 != 0)
            {
                MessageBox.Show("Please enter an amount that is a multiple of 5.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proceed with the withdrawal process
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
                MessageBox.Show("Your new balance is " + clsGlobal.CurrentClient.AccountBalance.ToString());
            }
            else
            {
                MessageBox.Show("Transaction failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
