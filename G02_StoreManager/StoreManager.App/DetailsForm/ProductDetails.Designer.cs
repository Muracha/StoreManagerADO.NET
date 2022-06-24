namespace StoreManager.App
{
    partial class ProductDetails
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
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtCategoryIDValue = new System.Windows.Forms.TextBox();
            this.txtSupplierIDValue = new System.Windows.Forms.TextBox();
            this.txtProductNameValue = new System.Windows.Forms.TextBox();
            this.txtPriceValue = new System.Windows.Forms.TextBox();
            this.txtDescriptionValue = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtQuantityValue = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(12, 21);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(78, 16);
            this.lblCategoryID.TabIndex = 0;
            this.lblCategoryID.Text = "Category ID";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 81);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(93, 16);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(12, 49);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(73, 16);
            this.lblSupplierID.TabIndex = 2;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(10, 166);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 110);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // txtCategoryIDValue
            // 
            this.txtCategoryIDValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoryIDValue.Location = new System.Drawing.Point(125, 18);
            this.txtCategoryIDValue.Name = "txtCategoryIDValue";
            this.txtCategoryIDValue.Size = new System.Drawing.Size(367, 22);
            this.txtCategoryIDValue.TabIndex = 5;
            // 
            // txtSupplierIDValue
            // 
            this.txtSupplierIDValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupplierIDValue.Location = new System.Drawing.Point(125, 46);
            this.txtSupplierIDValue.Name = "txtSupplierIDValue";
            this.txtSupplierIDValue.Size = new System.Drawing.Size(367, 22);
            this.txtSupplierIDValue.TabIndex = 6;
            // 
            // txtProductNameValue
            // 
            this.txtProductNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductNameValue.Location = new System.Drawing.Point(125, 78);
            this.txtProductNameValue.Name = "txtProductNameValue";
            this.txtProductNameValue.Size = new System.Drawing.Size(367, 22);
            this.txtProductNameValue.TabIndex = 7;
            // 
            // txtPriceValue
            // 
            this.txtPriceValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriceValue.Location = new System.Drawing.Point(125, 107);
            this.txtPriceValue.Name = "txtPriceValue";
            this.txtPriceValue.Size = new System.Drawing.Size(367, 22);
            this.txtPriceValue.TabIndex = 8;
            // 
            // txtDescriptionValue
            // 
            this.txtDescriptionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescriptionValue.Location = new System.Drawing.Point(125, 163);
            this.txtDescriptionValue.Multiline = true;
            this.txtDescriptionValue.Name = "txtDescriptionValue";
            this.txtDescriptionValue.Size = new System.Drawing.Size(367, 86);
            this.txtDescriptionValue.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(316, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(408, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtQuantityValue
            // 
            this.txtQuantityValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantityValue.Location = new System.Drawing.Point(125, 135);
            this.txtQuantityValue.Name = "txtQuantityValue";
            this.txtQuantityValue.Size = new System.Drawing.Size(367, 22);
            this.txtQuantityValue.TabIndex = 12;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(10, 138);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 16);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "Quantity";
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(504, 290);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantityValue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescriptionValue);
            this.Controls.Add(this.txtPriceValue);
            this.Controls.Add(this.txtProductNameValue);
            this.Controls.Add(this.txtSupplierIDValue);
            this.Controls.Add(this.txtCategoryIDValue);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblCategoryID);
            this.Name = "ProductDetails";
            this.Text = "ProductDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtCategoryIDValue;
        private System.Windows.Forms.TextBox txtSupplierIDValue;
        private System.Windows.Forms.TextBox txtProductNameValue;
        private System.Windows.Forms.TextBox txtPriceValue;
        private System.Windows.Forms.TextBox txtDescriptionValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtQuantityValue;
        private System.Windows.Forms.Label lblQuantity;
    }
}