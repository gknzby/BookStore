namespace BookStore
{
    partial class ShoppingForm
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
            this.btnAccount = new System.Windows.Forms.Button();
            this.pnlUserControl = new System.Windows.Forms.Panel();
            this.chckbxMusicCDs = new System.Windows.Forms.CheckBox();
            this.chckbxMagazines = new System.Windows.Forms.CheckBox();
            this.chckbxBooks = new System.Windows.Forms.CheckBox();
            this.btnBookStore = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnShoppingCart = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.flwLytPnlShopping = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUserControl.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccount
            // 
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccount.Location = new System.Drawing.Point(614, 17);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(125, 40);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUserControl.Controls.Add(this.chckbxMusicCDs);
            this.pnlUserControl.Controls.Add(this.chckbxMagazines);
            this.pnlUserControl.Controls.Add(this.chckbxBooks);
            this.pnlUserControl.Controls.Add(this.btnBookStore);
            this.pnlUserControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUserControl.Location = new System.Drawing.Point(0, 0);
            this.pnlUserControl.Name = "pnlUserControl";
            this.pnlUserControl.Size = new System.Drawing.Size(200, 650);
            this.pnlUserControl.TabIndex = 1;
            // 
            // chckbxMusicCDs
            // 
            this.chckbxMusicCDs.AutoSize = true;
            this.chckbxMusicCDs.Checked = true;
            this.chckbxMusicCDs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckbxMusicCDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckbxMusicCDs.Location = new System.Drawing.Point(50, 275);
            this.chckbxMusicCDs.Name = "chckbxMusicCDs";
            this.chckbxMusicCDs.Size = new System.Drawing.Size(104, 24);
            this.chckbxMusicCDs.TabIndex = 6;
            this.chckbxMusicCDs.Text = "Music CDs";
            this.chckbxMusicCDs.UseVisualStyleBackColor = true;
            this.chckbxMusicCDs.CheckedChanged += new System.EventHandler(this.chckbxMusicCDs_CheckedChanged);
            // 
            // chckbxMagazines
            // 
            this.chckbxMagazines.AutoSize = true;
            this.chckbxMagazines.Checked = true;
            this.chckbxMagazines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckbxMagazines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckbxMagazines.Location = new System.Drawing.Point(50, 225);
            this.chckbxMagazines.Name = "chckbxMagazines";
            this.chckbxMagazines.Size = new System.Drawing.Size(105, 24);
            this.chckbxMagazines.TabIndex = 5;
            this.chckbxMagazines.Text = "Magazines";
            this.chckbxMagazines.UseVisualStyleBackColor = true;
            this.chckbxMagazines.CheckedChanged += new System.EventHandler(this.chckbxMagazines_CheckedChanged);
            // 
            // chckbxBooks
            // 
            this.chckbxBooks.AutoSize = true;
            this.chckbxBooks.Checked = true;
            this.chckbxBooks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckbxBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckbxBooks.Location = new System.Drawing.Point(50, 175);
            this.chckbxBooks.Name = "chckbxBooks";
            this.chckbxBooks.Size = new System.Drawing.Size(73, 24);
            this.chckbxBooks.TabIndex = 4;
            this.chckbxBooks.Text = "Books";
            this.chckbxBooks.UseVisualStyleBackColor = true;
            this.chckbxBooks.CheckedChanged += new System.EventHandler(this.chckbxBooks_CheckedChanged);
            // 
            // btnBookStore
            // 
            this.btnBookStore.FlatAppearance.BorderSize = 0;
            this.btnBookStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookStore.Location = new System.Drawing.Point(12, 17);
            this.btnBookStore.Name = "btnBookStore";
            this.btnBookStore.Size = new System.Drawing.Size(176, 40);
            this.btnBookStore.TabIndex = 3;
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
            this.pnlHeader.TabIndex = 2;
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.FlatAppearance.BorderSize = 0;
            this.btnShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShoppingCart.Location = new System.Drawing.Point(745, 17);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(125, 40);
            this.btnShoppingCart.TabIndex = 3;
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
            this.btnMinimize.TabIndex = 6;
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
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // flwLytPnlShopping
            // 
            this.flwLytPnlShopping.AutoScroll = true;
            this.flwLytPnlShopping.Location = new System.Drawing.Point(206, 80);
            this.flwLytPnlShopping.Name = "flwLytPnlShopping";
            this.flwLytPnlShopping.Size = new System.Drawing.Size(1032, 558);
            this.flwLytPnlShopping.TabIndex = 3;
            // 
            // ShoppingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 650);
            this.Controls.Add(this.flwLytPnlShopping);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlUserControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShoppingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShoppingForm_FormClosing);
            this.Load += new System.EventHandler(this.ShoppingForm_Load);
            this.pnlUserControl.ResumeLayout(false);
            this.pnlUserControl.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel pnlUserControl;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnBookStore;
        private System.Windows.Forms.FlowLayoutPanel flwLytPnlShopping;
        private System.Windows.Forms.CheckBox chckbxMusicCDs;
        private System.Windows.Forms.CheckBox chckbxMagazines;
        private System.Windows.Forms.CheckBox chckbxBooks;
    }
}