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
    public partial class frmDeposit : Form
    {
        public frmDeposit()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDepositAmount.Text.Trim()))
            {
                MessageBox.Show("Fill the despoit amount", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDepositAmount.Focus();
                return;
            }


            decimal amountToDeposit = decimal.Parse(txtDepositAmount.Text.Trim());

            DepositAmount(amountToDeposit);
        }


        private void DepositAmount(decimal amountToDeposit)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to perform this transaction?", "Deposit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
                return;


            if (clsGlobal.CurrentClient.Deposit(amountToDeposit))
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
