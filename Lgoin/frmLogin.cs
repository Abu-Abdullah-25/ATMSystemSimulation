using BankingSystem_Business;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginClient();
        }

        private void HandleInactiveAccount()
        {
            txtAccountNumber.Focus();
            MessageBox.Show("Your account is not active. Please contact the admin.", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HandleInvalidCredentials()
        {
            txtAccountNumber.Focus();
            MessageBox.Show("Invalid AccountNumber/PinCode.", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ProceedWithLoggedInClient(clsClient client)
        {
            clsGlobal.CurrentClient = client;
            //Here will log the credentails of user into db table
            //clsGlobal.CurrentUser.RegisterLogIn();

            using (frmMain frm = new frmMain(this))
            {
                this.Hide();
                frm.ShowDialog();
                _ResetDefaultFields();
            }

        }

        private void _ResetDefaultFields()
        {
            txtAccountNumber.Clear();
            txtPinCode.Clear();

            txtAccountNumber.Focus();
        }

        private void LoginClient()
        {
            string accountNumber = txtAccountNumber.Text.Trim();
            string pinCode = txtPinCode.Text.Trim();

            clsClient client = clsClient.FindByAccountNumberAndPinCode(accountNumber, pinCode);
            if (client != null)
            {
                if (!client.IsActive)
                {
                    HandleInactiveAccount();
                    return;
                }

                ProceedWithLoggedInClient(client);
            }
            else
            {
                HandleInvalidCredentials();
            }


        }
    }
}
