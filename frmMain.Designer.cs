namespace ATM
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuickWithdraw = new FontAwesome.Sharp.IconButton();
            this.btnNormalWithdraw = new FontAwesome.Sharp.IconButton();
            this.btnDeposit = new FontAwesome.Sharp.IconButton();
            this.btnCheckBalance = new FontAwesome.Sharp.IconButton();
            this.btnChangePinCode = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(205, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "ATM Machine";
            // 
            // btnQuickWithdraw
            // 
            this.btnQuickWithdraw.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickWithdraw.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnQuickWithdraw.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnQuickWithdraw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuickWithdraw.Location = new System.Drawing.Point(42, 121);
            this.btnQuickWithdraw.Name = "btnQuickWithdraw";
            this.btnQuickWithdraw.Size = new System.Drawing.Size(172, 57);
            this.btnQuickWithdraw.TabIndex = 7;
            this.btnQuickWithdraw.Text = "Quick Withdraw";
            this.btnQuickWithdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuickWithdraw.UseVisualStyleBackColor = true;
            this.btnQuickWithdraw.Click += new System.EventHandler(this.btnQuickWithdraw_Click_1);
            // 
            // btnNormalWithdraw
            // 
            this.btnNormalWithdraw.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormalWithdraw.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btnNormalWithdraw.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNormalWithdraw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNormalWithdraw.Location = new System.Drawing.Point(301, 121);
            this.btnNormalWithdraw.Name = "btnNormalWithdraw";
            this.btnNormalWithdraw.Size = new System.Drawing.Size(172, 57);
            this.btnNormalWithdraw.TabIndex = 8;
            this.btnNormalWithdraw.Text = "Normal Withdraw";
            this.btnNormalWithdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNormalWithdraw.UseVisualStyleBackColor = true;
            this.btnNormalWithdraw.Click += new System.EventHandler(this.btnNormalWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.btnDeposit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeposit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeposit.Location = new System.Drawing.Point(42, 215);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(172, 57);
            this.btnDeposit.TabIndex = 9;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBalance.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.btnCheckBalance.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCheckBalance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckBalance.Location = new System.Drawing.Point(301, 215);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(172, 57);
            this.btnCheckBalance.TabIndex = 10;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnChangePinCode
            // 
            this.btnChangePinCode.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePinCode.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnChangePinCode.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnChangePinCode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangePinCode.Location = new System.Drawing.Point(42, 305);
            this.btnChangePinCode.Name = "btnChangePinCode";
            this.btnChangePinCode.Size = new System.Drawing.Size(172, 57);
            this.btnChangePinCode.TabIndex = 11;
            this.btnChangePinCode.Text = "Change PinCode";
            this.btnChangePinCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePinCode.UseVisualStyleBackColor = true;
            this.btnChangePinCode.Click += new System.EventHandler(this.btnChangePinCode_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SquareXmark;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.Location = new System.Drawing.Point(301, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 57);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(510, 397);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangePinCode);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnNormalWithdraw);
            this.Controls.Add(this.btnQuickWithdraw);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnQuickWithdraw;
        private FontAwesome.Sharp.IconButton btnNormalWithdraw;
        private FontAwesome.Sharp.IconButton btnDeposit;
        private FontAwesome.Sharp.IconButton btnCheckBalance;
        private FontAwesome.Sharp.IconButton btnChangePinCode;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}