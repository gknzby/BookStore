namespace BookStore
{
    partial class ShoppingListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picbxCoverPagePicture = new System.Windows.Forms.PictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.cmbxQuantity = new System.Windows.Forms.ComboBox();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbxCoverPagePicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbxCoverPagePicture
            // 
            this.picbxCoverPagePicture.BackColor = System.Drawing.SystemColors.Control;
            this.picbxCoverPagePicture.Location = new System.Drawing.Point(3, 3);
            this.picbxCoverPagePicture.Name = "picbxCoverPagePicture";
            this.picbxCoverPagePicture.Size = new System.Drawing.Size(194, 194);
            this.picbxCoverPagePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxCoverPagePicture.TabIndex = 0;
            this.picbxCoverPagePicture.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(225, 20);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(110, 20);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductType.Location = new System.Drawing.Point(225, 90);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(102, 20);
            this.lblProductType.TabIndex = 2;
            this.lblProductType.Text = "Product Type";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductPrice.Location = new System.Drawing.Point(225, 160);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(44, 20);
            this.lblProductPrice.TabIndex = 3;
            this.lblProductPrice.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.picbxCoverPagePicture);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 4;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddToCart.Location = new System.Drawing.Point(450, 83);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(40, 40);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "+";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // cmbxQuantity
            // 
            this.cmbxQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbxQuantity.FormattingEnabled = true;
            this.cmbxQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbxQuantity.Location = new System.Drawing.Point(440, 129);
            this.cmbxQuantity.Name = "cmbxQuantity";
            this.cmbxQuantity.Size = new System.Drawing.Size(50, 28);
            this.cmbxQuantity.TabIndex = 6;
            this.cmbxQuantity.SelectedIndexChanged += new System.EventHandler(this.cmbxQuantity_SelectedIndexChanged);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.FlatAppearance.BorderSize = 0;
            this.btnRemoveFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveFromCart.Location = new System.Drawing.Point(450, 20);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(40, 40);
            this.btnRemoveFromCart.TabIndex = 7;
            this.btnRemoveFromCart.Text = "-";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDetails.Location = new System.Drawing.Point(420, 163);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(70, 30);
            this.btnDetails.TabIndex = 8;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // ShoppingListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.cmbxQuantity);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.lblProductName);
            this.Name = "ShoppingListItem";
            this.Size = new System.Drawing.Size(500, 206);
            this.Load += new System.EventHandler(this.ShoppingListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxCoverPagePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxCoverPagePicture;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.ComboBox cmbxQuantity;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnDetails;
    }
}
