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
    public partial class frmChangePinCode : Form
    {
        public frmChangePinCode()
        {
            InitializeComponent();
        }

        private void txtCurrentPinCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPinCode.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPinCode, "PinCode cannot be blank");
            }
            else if (clsGlobal.CurrentClient.PinCode != txtCurrentPinCode.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPinCode, "Current PinCode is wrong!");
            }
            else
            {
                errorProvider1.SetError(txtCurrentPinCode, null);
            }
        }

        private void txtNewPinCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPinCode.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPinCode, "New PinCode cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtNewPinCode, null);
            }
        }

        private void txtConfirmPinCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPinCode.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPinCode, "PinCode Confirmation cannot be blank");
            }
            else if (txtConfirmPinCode.Text.Trim() != txtNewPinCode.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPinCode, "PinCode Confirmation does not match New PinCode!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPinCode, null);
            }
        }


        private void _ResetDefualtValues()
        {
            txtCurrentPinCode.Text = "";
            txtNewPinCode.Text = "";
            txtConfirmPinCode.Text = "";
            txtCurrentPinCode.Focus();
        }

        private void frmChangePinCode_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsGlobal.CurrentClient.PinCode = txtNewPinCode.Text.Trim();

            if (clsGlobal.CurrentClient.Save())
            {
                MessageBox.Show("PinCode Changed Successfully.",
                   "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("An Erro Occured, PinCode did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
