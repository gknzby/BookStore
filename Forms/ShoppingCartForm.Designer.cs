namespace BookStore
{
    partial class ShoppingCartForm
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
            this.pnlUserControl = new System.Windows.Forms.Panel();
            this.btnBookStore = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnShoppingCart = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.flwLytPnlShoppingCart = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.btnClearShoppingCart = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.btnPaymentMethod = new System.Windows.Forms.Button();
            this.pnlUserControl.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUserControl.Controls.Add(this.btnBookStore);
            this.pnlUserControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUserControl.Location = new System.Drawing.Point(0, 0);
            this.pnlUserControl.Name = "pnlUserControl";
            this.pnlUserControl.Size = new System.Drawing.Size(200, 650);
            this.pnlUserControl.TabIndex = 2;
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
            this.pnlHeader.TabIndex = 3;
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
            // flwLytPnlShoppingCart
            // 
            this.flwLytPnlShoppingCart.AutoScroll = true;
            this.flwLytPnlShoppingCart.Location = new System.Drawing.Point(206, 80);
            this.flwLytPnlShoppingCart.Name = "flwLytPnlShoppingCart";
            this.flwLytPnlShoppingCart.Size = new System.Drawing.Size(732, 558);
            this.flwLytPnlShoppingCart.TabIndex = 4;
            // 
            // pnlOrder
            // 
            this.pnlOrder.Controls.Add(this.btnPaymentMethod);
            this.pnlOrder.Controls.Add(this.btnClearShoppingCart);
            this.pnlOrder.Controls.Add(this.btnPlaceOrder);
            this.pnlOrder.Controls.Add(this.lblTotalPrice);
            this.pnlOrder.Controls.Add(this.lblItemCount);
            this.pnlOrder.Controls.Add(this.lblOrderSummary);
            this.pnlOrder.Location = new System.Drawing.Point(944, 80);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(294, 558);
            this.pnlOrder.TabIndex = 5;
            // 
            // btnClearShoppingCart
            // 
            this.btnClearShoppingCart.FlatAppearance.BorderSize = 0;
            this.btnClearShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearShoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClearShoppingCart.Location = new System.Drawing.Point(166, 515);
            this.btnClearShoppingCart.Name = "btnClearShoppingCart";
            this.btnClearShoppingCart.Size = new System.Drawing.Size(125, 40);
            this.btnClearShoppingCart.TabIndex = 4;
            this.btnClearShoppingCart.Text = "Clear The Cart";
            this.btnClearShoppingCart.UseVisualStyleBackColor = true;
            this.btnClearShoppingCart.Click += new System.EventHandler(this.btnClearShoppingCart_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(85, 400);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(125, 40);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.Location = new System.Drawing.Point(60, 200);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(91, 20);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "Total Price :";
            // 
            // lblItemCount
            // 
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItemCount.Location = new System.Drawing.Point(60, 150);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(96, 20);
            this.lblItemCount.TabIndex = 1;
            this.lblItemCount.Text = "Item Count :";
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderSummary.Location = new System.Drawing.Point(45, 45);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(205, 31);
            this.lblOrderSummary.TabIndex = 0;
            this.lblOrderSummary.Text = "Order Summary";
            // 
            // btnPaymentMethod
            // 
            this.btnPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPaymentMethod.Location = new System.Drawing.Point(35, 325);
            this.btnPaymentMethod.Name = "btnPaymentMethod";
            this.btnPaymentMethod.Size = new System.Drawing.Size(225, 40);
            this.btnPaymentMethod.TabIndex = 5;
            this.btnPaymentMethod.Text = "Select Payment Method";
            this.btnPaymentMethod.UseVisualStyleBackColor = true;
            this.btnPaymentMethod.Click += new System.EventHandler(this.btnPaymentMethod_Click);
            // 
            // ShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 650);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.flwLytPnlShoppingCart);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlUserControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShoppingCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoppingCartForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShoppingCartForm_FormClosing);
            this.Load += new System.EventHandler(this.ShoppingCartForm_Load);
            this.pnlUserControl.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserControl;
        private System.Windows.Forms.Button btnBookStore;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.FlowLayoutPanel flwLytPnlShoppingCart;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnClearShoppingCart;
        private System.Windows.Forms.Button btnPaymentMethod;
    }
}