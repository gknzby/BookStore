namespace BookStore
{
    partial class AccountForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlUserControl = new System.Windows.Forms.Panel();
            this.btnBookStore = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnShoppingCart = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPasswordAgain = new System.Windows.Forms.TextBox();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblNewPasswordAgain = new System.Windows.Forms.Label();
            this.pnlChangePass = new System.Windows.Forms.Panel();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnUpdatePersonalInfo = new System.Windows.Forms.Button();
            this.pnlPersonalInfo = new System.Windows.Forms.Panel();
            this.btnConfirmEmail = new System.Windows.Forms.Button();
            this.lblYourPersonalInformations = new System.Windows.Forms.Label();
            this.pnlOperationChoice = new System.Windows.Forms.Panel();
            this.btnYourOrders = new System.Windows.Forms.Button();
            this.btnAdminFeatures = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangePersonalInformations = new System.Windows.Forms.Button();
            this.lblYourAccount = new System.Windows.Forms.Label();
            this.lblAdminFeatures = new System.Windows.Forms.Label();
            this.cmboxAdminOperationChoice = new System.Windows.Forms.ComboBox();
            this.lstAllListed = new System.Windows.Forms.ListView();
            this.btnConfirmRegistration = new System.Windows.Forms.Button();
            this.btnUpgradeToAdmin = new System.Windows.Forms.Button();
            this.chckbxAccountConfirmed = new System.Windows.Forms.CheckBox();
            this.chckbxIsAdmin = new System.Windows.Forms.CheckBox();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblYourOrders = new System.Windows.Forms.Label();
            this.flwLytPnlYourOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUserControl.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlChangePass.SuspendLayout();
            this.pnlPersonalInfo.SuspendLayout();
            this.pnlOperationChoice.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.Location = new System.Drawing.Point(12, 598);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(176, 40);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUserControl.Controls.Add(this.btnLogout);
            this.pnlUserControl.Controls.Add(this.btnBookStore);
            this.pnlUserControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUserControl.Location = new System.Drawing.Point(0, 0);
            this.pnlUserControl.Name = "pnlUserControl";
            this.pnlUserControl.Size = new System.Drawing.Size(200, 650);
            this.pnlUserControl.TabIndex = 8;
            // 
            // btnBookStore
            // 
            this.btnBookStore.FlatAppearance.BorderSize = 0;
            this.btnBookStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookStore.Location = new System.Drawing.Point(12, 17);
            this.btnBookStore.Name = "btnBookStore";
            this.btnBookStore.Size = new System.Drawing.Size(176, 40);
            this.btnBookStore.TabIndex = 16;
            this.btnBookStore.Text = "Book Store";
            this.btnBookStore.UseVisualStyleBackColor = true;
            this.btnBookStore.Click += new System.EventHandler(this.btnBookStore_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlHeader.Controls.Add(this.btnShoppingCart);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.btnAccount);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1050, 74);
            this.pnlHeader.TabIndex = 9;
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.FlatAppearance.BorderSize = 0;
            this.btnShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShoppingCart.Location = new System.Drawing.Point(745, 17);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(125, 40);
            this.btnShoppingCart.TabIndex = 18;
            this.btnShoppingCart.Text = "Shopping Cart";
            this.btnShoppingCart.UseVisualStyleBackColor = true;
            this.btnShoppingCart.Click += new System.EventHandler(this.btnShoppingCart_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinimize.Location = new System.Drawing.Point(932, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 19;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(988, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccount.Location = new System.Drawing.Point(614, 17);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(125, 40);
            this.btnAccount.TabIndex = 17;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOldPassword.Location = new System.Drawing.Point(200, 125);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(250, 26);
            this.txtOldPassword.TabIndex = 9;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChangePassword.Location = new System.Drawing.Point(198, 32);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(236, 31);
            this.lblChangePassword.TabIndex = 0;
            this.lblChangePassword.Text = "Change Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewPassword.Location = new System.Drawing.Point(200, 200);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(250, 26);
            this.txtNewPassword.TabIndex = 10;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPasswordAgain
            // 
            this.txtNewPasswordAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewPasswordAgain.Location = new System.Drawing.Point(200, 275);
            this.txtNewPasswordAgain.Name = "txtNewPasswordAgain";
            this.txtNewPasswordAgain.Size = new System.Drawing.Size(250, 26);
            this.txtNewPasswordAgain.TabIndex = 11;
            this.txtNewPasswordAgain.UseSystemPasswordChar = true;
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdatePassword.Location = new System.Drawing.Point(325, 425);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(125, 50);
            this.btnUpdatePassword.TabIndex = 12;
            this.btnUpdatePassword.Text = "Update";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOldPassword.Location = new System.Drawing.Point(50, 128);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(106, 20);
            this.lblOldPassword.TabIndex = 0;
            this.lblOldPassword.Text = "Old Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewPassword.Location = new System.Drawing.Point(50, 203);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(113, 20);
            this.lblNewPassword.TabIndex = 0;
            this.lblNewPassword.Text = "New Password";
            // 
            // lblNewPasswordAgain
            // 
            this.lblNewPasswordAgain.AutoSize = true;
            this.lblNewPasswordAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewPasswordAgain.Location = new System.Drawing.Point(50, 278);
            this.lblNewPasswordAgain.Name = "lblNewPasswordAgain";
            this.lblNewPasswordAgain.Size = new System.Drawing.Size(113, 40);
            this.lblNewPasswordAgain.TabIndex = 0;
            this.lblNewPasswordAgain.Text = "New Password\r\n      (Again)";
            // 
            // pnlChangePass
            // 
            this.pnlChangePass.Controls.Add(this.lblNewPasswordAgain);
            this.pnlChangePass.Controls.Add(this.lblNewPassword);
            this.pnlChangePass.Controls.Add(this.lblOldPassword);
            this.pnlChangePass.Controls.Add(this.btnUpdatePassword);
            this.pnlChangePass.Controls.Add(this.txtNewPasswordAgain);
            this.pnlChangePass.Controls.Add(this.txtNewPassword);
            this.pnlChangePass.Controls.Add(this.lblChangePassword);
            this.pnlChangePass.Controls.Add(this.txtOldPassword);
            this.pnlChangePass.Location = new System.Drawing.Point(606, 80);
            this.pnlChangePass.Name = "pnlChangePass";
            this.pnlChangePass.Size = new System.Drawing.Size(632, 558);
            this.pnlChangePass.TabIndex = 0;
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdress.Location = new System.Drawing.Point(200, 275);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(250, 125);
            this.txtAdress.TabIndex = 7;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdress.Location = new System.Drawing.Point(50, 278);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(59, 20);
            this.lblAdress.TabIndex = 0;
            this.lblAdress.Text = "Adress";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(50, 178);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(200, 175);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 26);
            this.txtName.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(50, 228);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.Location = new System.Drawing.Point(50, 128);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(200, 225);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.Location = new System.Drawing.Point(200, 125);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 26);
            this.txtUsername.TabIndex = 4;
            // 
            // btnUpdatePersonalInfo
            // 
            this.btnUpdatePersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdatePersonalInfo.Location = new System.Drawing.Point(325, 425);
            this.btnUpdatePersonalInfo.Name = "btnUpdatePersonalInfo";
            this.btnUpdatePersonalInfo.Size = new System.Drawing.Size(125, 50);
            this.btnUpdatePersonalInfo.TabIndex = 8;
            this.btnUpdatePersonalInfo.Text = "Update";
            this.btnUpdatePersonalInfo.UseVisualStyleBackColor = true;
            this.btnUpdatePersonalInfo.Click += new System.EventHandler(this.btnUpdatePersonalInfo_Click);
            // 
            // pnlPersonalInfo
            // 
            this.pnlPersonalInfo.Controls.Add(this.btnConfirmEmail);
            this.pnlPersonalInfo.Controls.Add(this.btnUpdatePersonalInfo);
            this.pnlPersonalInfo.Controls.Add(this.lblYourPersonalInformations);
            this.pnlPersonalInfo.Controls.Add(this.txtUsername);
            this.pnlPersonalInfo.Controls.Add(this.txtEmail);
            this.pnlPersonalInfo.Controls.Add(this.lblUsername);
            this.pnlPersonalInfo.Controls.Add(this.lblEmail);
            this.pnlPersonalInfo.Controls.Add(this.txtName);
            this.pnlPersonalInfo.Controls.Add(this.lblName);
            this.pnlPersonalInfo.Controls.Add(this.lblAdress);
            this.pnlPersonalInfo.Controls.Add(this.txtAdress);
            this.pnlPersonalInfo.Location = new System.Drawing.Point(606, 80);
            this.pnlPersonalInfo.Name = "pnlPersonalInfo";
            this.pnlPersonalInfo.Size = new System.Drawing.Size(632, 558);
            this.pnlPersonalInfo.TabIndex = 0;
            // 
            // btnConfirmEmail
            // 
            this.btnConfirmEmail.FlatAppearance.BorderSize = 0;
            this.btnConfirmEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirmEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirmEmail.Location = new System.Drawing.Point(454, 225);
            this.btnConfirmEmail.Name = "btnConfirmEmail";
            this.btnConfirmEmail.Size = new System.Drawing.Size(175, 26);
            this.btnConfirmEmail.TabIndex = 9;
            this.btnConfirmEmail.Text = "Confirm Your Email";
            this.btnConfirmEmail.UseVisualStyleBackColor = true;
            this.btnConfirmEmail.Click += new System.EventHandler(this.btnConfirmEmail_Click);
            // 
            // lblYourPersonalInformations
            // 
            this.lblYourPersonalInformations.AutoSize = true;
            this.lblYourPersonalInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYourPersonalInformations.Location = new System.Drawing.Point(150, 32);
            this.lblYourPersonalInformations.Name = "lblYourPersonalInformations";
            this.lblYourPersonalInformations.Size = new System.Drawing.Size(342, 31);
            this.lblYourPersonalInformations.TabIndex = 0;
            this.lblYourPersonalInformations.Text = "Your Personal Informations";
            // 
            // pnlOperationChoice
            // 
            this.pnlOperationChoice.Controls.Add(this.btnYourOrders);
            this.pnlOperationChoice.Controls.Add(this.btnAdminFeatures);
            this.pnlOperationChoice.Controls.Add(this.btnChangePassword);
            this.pnlOperationChoice.Controls.Add(this.btnChangePersonalInformations);
            this.pnlOperationChoice.Controls.Add(this.lblYourAccount);
            this.pnlOperationChoice.Location = new System.Drawing.Point(206, 80);
            this.pnlOperationChoice.Name = "pnlOperationChoice";
            this.pnlOperationChoice.Size = new System.Drawing.Size(394, 558);
            this.pnlOperationChoice.TabIndex = 0;
            // 
            // btnYourOrders
            // 
            this.btnYourOrders.FlatAppearance.BorderSize = 0;
            this.btnYourOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYourOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYourOrders.Location = new System.Drawing.Point(50, 125);
            this.btnYourOrders.Name = "btnYourOrders";
            this.btnYourOrders.Size = new System.Drawing.Size(140, 40);
            this.btnYourOrders.TabIndex = 0;
            this.btnYourOrders.Text = "Your Orders";
            this.btnYourOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYourOrders.UseVisualStyleBackColor = true;
            this.btnYourOrders.Click += new System.EventHandler(this.btnYourOrders_Click);
            // 
            // btnAdminFeatures
            // 
            this.btnAdminFeatures.FlatAppearance.BorderSize = 0;
            this.btnAdminFeatures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminFeatures.Location = new System.Drawing.Point(50, 350);
            this.btnAdminFeatures.Name = "btnAdminFeatures";
            this.btnAdminFeatures.Size = new System.Drawing.Size(140, 40);
            this.btnAdminFeatures.TabIndex = 3;
            this.btnAdminFeatures.Text = "Admin Features";
            this.btnAdminFeatures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminFeatures.UseVisualStyleBackColor = true;
            this.btnAdminFeatures.Click += new System.EventHandler(this.btnAdminFeatures_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangePassword.Location = new System.Drawing.Point(50, 275);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(150, 40);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnChangePersonalInformations
            // 
            this.btnChangePersonalInformations.FlatAppearance.BorderSize = 0;
            this.btnChangePersonalInformations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePersonalInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangePersonalInformations.Location = new System.Drawing.Point(50, 200);
            this.btnChangePersonalInformations.Name = "btnChangePersonalInformations";
            this.btnChangePersonalInformations.Size = new System.Drawing.Size(240, 40);
            this.btnChangePersonalInformations.TabIndex = 1;
            this.btnChangePersonalInformations.Text = "Change Personal Informations";
            this.btnChangePersonalInformations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePersonalInformations.UseVisualStyleBackColor = true;
            this.btnChangePersonalInformations.Click += new System.EventHandler(this.btnChangePersonalInformations_Click);
            // 
            // lblYourAccount
            // 
            this.lblYourAccount.AutoSize = true;
            this.lblYourAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYourAccount.Location = new System.Drawing.Point(108, 32);
            this.lblYourAccount.Name = "lblYourAccount";
            this.lblYourAccount.Size = new System.Drawing.Size(177, 31);
            this.lblYourAccount.TabIndex = 0;
            this.lblYourAccount.Text = "Your Account";
            // 
            // lblAdminFeatures
            // 
            this.lblAdminFeatures.AutoSize = true;
            this.lblAdminFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminFeatures.Location = new System.Drawing.Point(213, 32);
            this.lblAdminFeatures.Name = "lblAdminFeatures";
            this.lblAdminFeatures.Size = new System.Drawing.Size(205, 31);
            this.lblAdminFeatures.TabIndex = 0;
            this.lblAdminFeatures.Text = "Admin Features";
            // 
            // cmboxAdminOperationChoice
            // 
            this.cmboxAdminOperationChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxAdminOperationChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmboxAdminOperationChoice.FormattingEnabled = true;
            this.cmboxAdminOperationChoice.Items.AddRange(new object[] {
            "Edit Users",
            "Edit Products"});
            this.cmboxAdminOperationChoice.Location = new System.Drawing.Point(208, 100);
            this.cmboxAdminOperationChoice.Name = "cmboxAdminOperationChoice";
            this.cmboxAdminOperationChoice.Size = new System.Drawing.Size(210, 28);
            this.cmboxAdminOperationChoice.TabIndex = 13;
            this.cmboxAdminOperationChoice.SelectedIndexChanged += new System.EventHandler(this.cmboxAdminOperationChoice_SelectedIndexChanged);
            // 
            // lstAllListed
            // 
            this.lstAllListed.FullRowSelect = true;
            this.lstAllListed.GridLines = true;
            this.lstAllListed.Location = new System.Drawing.Point(25, 200);
            this.lstAllListed.MultiSelect = false;
            this.lstAllListed.Name = "lstAllListed";
            this.lstAllListed.Size = new System.Drawing.Size(582, 200);
            this.lstAllListed.TabIndex = 14;
            this.lstAllListed.UseCompatibleStateImageBehavior = false;
            this.lstAllListed.View = System.Windows.Forms.View.Details;
            this.lstAllListed.SelectedIndexChanged += new System.EventHandler(this.lstAllListed_SelectedIndexChanged);
            this.lstAllListed.DoubleClick += new System.EventHandler(this.lstAllListed_DoubleClick);
            // 
            // btnConfirmRegistration
            // 
            this.btnConfirmRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirmRegistration.Location = new System.Drawing.Point(482, 450);
            this.btnConfirmRegistration.Name = "btnConfirmRegistration";
            this.btnConfirmRegistration.Size = new System.Drawing.Size(125, 50);
            this.btnConfirmRegistration.TabIndex = 18;
            this.btnConfirmRegistration.Text = "Confirm Registration";
            this.btnConfirmRegistration.UseVisualStyleBackColor = true;
            this.btnConfirmRegistration.Click += new System.EventHandler(this.btnConfirmRegistration_Click);
            // 
            // btnUpgradeToAdmin
            // 
            this.btnUpgradeToAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpgradeToAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpgradeToAdmin.Location = new System.Drawing.Point(121, 450);
            this.btnUpgradeToAdmin.Name = "btnUpgradeToAdmin";
            this.btnUpgradeToAdmin.Size = new System.Drawing.Size(125, 50);
            this.btnUpgradeToAdmin.TabIndex = 16;
            this.btnUpgradeToAdmin.Text = "Upgrade To Admin";
            this.btnUpgradeToAdmin.UseVisualStyleBackColor = true;
            this.btnUpgradeToAdmin.Click += new System.EventHandler(this.btnUpgradeToAdmin_Click);
            // 
            // chckbxAccountConfirmed
            // 
            this.chckbxAccountConfirmed.AutoSize = true;
            this.chckbxAccountConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckbxAccountConfirmed.Location = new System.Drawing.Point(308, 450);
            this.chckbxAccountConfirmed.Name = "chckbxAccountConfirmed";
            this.chckbxAccountConfirmed.Size = new System.Drawing.Size(164, 24);
            this.chckbxAccountConfirmed.TabIndex = 17;
            this.chckbxAccountConfirmed.Text = "Account Confirmed";
            this.chckbxAccountConfirmed.UseVisualStyleBackColor = true;
            // 
            // chckbxIsAdmin
            // 
            this.chckbxIsAdmin.AutoSize = true;
            this.chckbxIsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckbxIsAdmin.Location = new System.Drawing.Point(25, 450);
            this.chckbxIsAdmin.Name = "chckbxIsAdmin";
            this.chckbxIsAdmin.Size = new System.Drawing.Size(90, 24);
            this.chckbxIsAdmin.TabIndex = 15;
            this.chckbxIsAdmin.Text = "Is Admin";
            this.chckbxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewProduct.Location = new System.Drawing.Point(482, 128);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(125, 50);
            this.btnAddNewProduct.TabIndex = 19;
            this.btnAddNewProduct.Text = "Add New Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.btnAddNewProduct);
            this.pnlAdmin.Controls.Add(this.chckbxIsAdmin);
            this.pnlAdmin.Controls.Add(this.chckbxAccountConfirmed);
            this.pnlAdmin.Controls.Add(this.btnUpgradeToAdmin);
            this.pnlAdmin.Controls.Add(this.btnConfirmRegistration);
            this.pnlAdmin.Controls.Add(this.lstAllListed);
            this.pnlAdmin.Controls.Add(this.cmboxAdminOperationChoice);
            this.pnlAdmin.Controls.Add(this.lblAdminFeatures);
            this.pnlAdmin.Location = new System.Drawing.Point(606, 80);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(632, 558);
            this.pnlAdmin.TabIndex = 0;
            // 
            // pnlOrders
            // 
            this.pnlOrders.Controls.Add(this.flwLytPnlYourOrders);
            this.pnlOrders.Controls.Add(this.lblYourOrders);
            this.pnlOrders.Location = new System.Drawing.Point(606, 80);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(632, 558);
            this.pnlOrders.TabIndex = 20;
            // 
            // lblYourOrders
            // 
            this.lblYourOrders.AutoSize = true;
            this.lblYourOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYourOrders.Location = new System.Drawing.Point(235, 32);
            this.lblYourOrders.Name = "lblYourOrders";
            this.lblYourOrders.Size = new System.Drawing.Size(161, 31);
            this.lblYourOrders.TabIndex = 1;
            this.lblYourOrders.Text = "Your Orders";
            // 
            // flwLytPnlYourOrders
            // 
            this.flwLytPnlYourOrders.AutoScroll = true;
            this.flwLytPnlYourOrders.Location = new System.Drawing.Point(3, 75);
            this.flwLytPnlYourOrders.Name = "flwLytPnlYourOrders";
            this.flwLytPnlYourOrders.Size = new System.Drawing.Size(626, 480);
            this.flwLytPnlYourOrders.TabIndex = 5;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 650);
            this.Controls.Add(this.pnlOrders);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.pnlOperationChoice);
            this.Controls.Add(this.pnlPersonalInfo);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlChangePass);
            this.Controls.Add(this.pnlUserControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountForm_FormClosing);
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.pnlUserControl.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlChangePass.ResumeLayout(false);
            this.pnlChangePass.PerformLayout();
            this.pnlPersonalInfo.ResumeLayout(false);
            this.pnlPersonalInfo.PerformLayout();
            this.pnlOperationChoice.ResumeLayout(false);
            this.pnlOperationChoice.PerformLayout();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlUserControl;
        private System.Windows.Forms.Button btnBookStore;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewPasswordAgain;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblNewPasswordAgain;
        private System.Windows.Forms.Panel pnlChangePass;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnUpdatePersonalInfo;
        private System.Windows.Forms.Panel pnlPersonalInfo;
        private System.Windows.Forms.Label lblYourPersonalInformations;
        private System.Windows.Forms.Panel pnlOperationChoice;
        private System.Windows.Forms.Button btnYourOrders;
        private System.Windows.Forms.Button btnAdminFeatures;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangePersonalInformations;
        private System.Windows.Forms.Label lblYourAccount;
        private System.Windows.Forms.Button btnConfirmEmail;
        private System.Windows.Forms.Label lblAdminFeatures;
        private System.Windows.Forms.ComboBox cmboxAdminOperationChoice;
        private System.Windows.Forms.ListView lstAllListed;
        private System.Windows.Forms.Button btnConfirmRegistration;
        private System.Windows.Forms.Button btnUpgradeToAdmin;
        private System.Windows.Forms.CheckBox chckbxAccountConfirmed;
        private System.Windows.Forms.CheckBox chckbxIsAdmin;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Label lblYourOrders;
        private System.Windows.Forms.FlowLayoutPanel flwLytPnlYourOrders;
    }
}