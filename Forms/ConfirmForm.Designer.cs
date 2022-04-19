namespace BookStore
{
    partial class ConfirmForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtConfirmationCode = new System.Windows.Forms.TextBox();
            this.lblConfirmationCode = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlConfirmMail = new System.Windows.Forms.Panel();
            this.pnlConfirmCreditCard = new System.Windows.Forms.Panel();
            this.btnConfirmCreditCard = new System.Windows.Forms.Button();
            this.txtCreditCardNo = new System.Windows.Forms.TextBox();
            this.lblCreditCardNo = new System.Windows.Forms.Label();
            this.pnlConfirmMail.SuspendLayout();
            this.pnlConfirmCreditCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(160, 17);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(183, 31);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Confirm Email";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(438, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtConfirmationCode
            // 
            this.txtConfirmationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtConfirmationCode.Location = new System.Drawing.Point(163, 47);
            this.txtConfirmationCode.Name = "txtConfirmationCode";
            this.txtConfirmationCode.Size = new System.Drawing.Size(150, 26);
            this.txtConfirmationCode.TabIndex = 22;
            // 
            // lblConfirmationCode
            // 
            this.lblConfirmationCode.AutoSize = true;
            this.lblConfirmationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConfirmationCode.Location = new System.Drawing.Point(12, 50);
            this.lblConfirmationCode.Name = "lblConfirmationCode";
            this.lblConfirmationCode.Size = new System.Drawing.Size(145, 20);
            this.lblConfirmationCode.TabIndex = 23;
            this.lblConfirmationCode.Text = "Confirmation Code:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirm.Location = new System.Drawing.Point(350, 45);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.TabIndex = 24;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnlConfirmMail
            // 
            this.pnlConfirmMail.Controls.Add(this.btnConfirm);
            this.pnlConfirmMail.Controls.Add(this.txtConfirmationCode);
            this.pnlConfirmMail.Controls.Add(this.lblConfirmationCode);
            this.pnlConfirmMail.Location = new System.Drawing.Point(12, 68);
            this.pnlConfirmMail.Name = "pnlConfirmMail";
            this.pnlConfirmMail.Size = new System.Drawing.Size(476, 120);
            this.pnlConfirmMail.TabIndex = 25;
            // 
            // pnlConfirmCreditCard
            // 
            this.pnlConfirmCreditCard.Controls.Add(this.btnConfirmCreditCard);
            this.pnlConfirmCreditCard.Controls.Add(this.txtCreditCardNo);
            this.pnlConfirmCreditCard.Controls.Add(this.lblCreditCardNo);
            this.pnlConfirmCreditCard.Location = new System.Drawing.Point(12, 68);
            this.pnlConfirmCreditCard.Name = "pnlConfirmCreditCard";
            this.pnlConfirmCreditCard.Size = new System.Drawing.Size(476, 120);
            this.pnlConfirmCreditCard.TabIndex = 26;
            // 
            // btnConfirmCreditCard
            // 
            this.btnConfirmCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirmCreditCard.Location = new System.Drawing.Point(350, 45);
            this.btnConfirmCreditCard.Name = "btnConfirmCreditCard";
            this.btnConfirmCreditCard.Size = new System.Drawing.Size(100, 30);
            this.btnConfirmCreditCard.TabIndex = 24;
            this.btnConfirmCreditCard.Text = "Confirm";
            this.btnConfirmCreditCard.UseVisualStyleBackColor = true;
            this.btnConfirmCreditCard.Click += new System.EventHandler(this.btnConfirmCreditCard_Click);
            // 
            // txtCreditCardNo
            // 
            this.txtCreditCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCreditCardNo.Location = new System.Drawing.Point(163, 47);
            this.txtCreditCardNo.Name = "txtCreditCardNo";
            this.txtCreditCardNo.Size = new System.Drawing.Size(150, 26);
            this.txtCreditCardNo.TabIndex = 22;
            // 
            // lblCreditCardNo
            // 
            this.lblCreditCardNo.AutoSize = true;
            this.lblCreditCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCreditCardNo.Location = new System.Drawing.Point(12, 50);
            this.lblCreditCardNo.Name = "lblCreditCardNo";
            this.lblCreditCardNo.Size = new System.Drawing.Size(117, 20);
            this.lblCreditCardNo.TabIndex = 23;
            this.lblCreditCardNo.Text = "Credit Card No:";
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.pnlConfirmCreditCard);
            this.Controls.Add(this.pnlConfirmMail);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmForm";
            this.Load += new System.EventHandler(this.ConfirmForm_Load);
            this.pnlConfirmMail.ResumeLayout(false);
            this.pnlConfirmMail.PerformLayout();
            this.pnlConfirmCreditCard.ResumeLayout(false);
            this.pnlConfirmCreditCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtConfirmationCode;
        private System.Windows.Forms.Label lblConfirmationCode;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel pnlConfirmMail;
        private System.Windows.Forms.Panel pnlConfirmCreditCard;
        private System.Windows.Forms.Button btnConfirmCreditCard;
        private System.Windows.Forms.TextBox txtCreditCardNo;
        private System.Windows.Forms.Label lblCreditCardNo;
    }
}