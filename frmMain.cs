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
    public partial class frmMain : Form
    {
        private frmLogin _frmLogin;
        public frmMain(frmLogin frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
        }





        private void btnQuickWithdraw_Click_1(object sender, EventArgs e)
        {
            using (frmQuickWithdraw frm = new frmQuickWithdraw())
            {
                frm.ShowDialog();
            }
        }

        private void btnNormalWithdraw_Click(object sender, EventArgs e)
        {
            using (frmNormalWithdraw frm = new frmNormalWithdraw())
            {
                frm.ShowDialog();
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            using (frmDeposit frm = new frmDeposit())
            {
                frm.ShowDialog();
            }
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            decimal currentClientBalance = clsGlobal.CurrentClient.AccountBalance;

            using (frmCheckBalance frm = new frmCheckBalance(currentClientBalance))
            {
                frm.ShowDialog();
            }
        }

        private void btnChangePinCode_Click_1(object sender, EventArgs e)
        {
            using (frmChangePinCode frm = new frmChangePinCode())
            {
                frm.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentClient = null;
            _frmLogin.Show();
            this.Close();
        }
    }
}
