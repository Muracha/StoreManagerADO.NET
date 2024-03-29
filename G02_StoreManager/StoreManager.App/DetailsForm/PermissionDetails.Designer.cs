﻿namespace StoreManager.App.DetailsForm
{
    partial class PermissionDetails
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
            this.txtPermissionCodeValue = new System.Windows.Forms.TextBox();
            this.txtPermissionNameValue = new System.Windows.Forms.TextBox();
            this.txtDescriptionValue = new System.Windows.Forms.TextBox();
            this.lblPermissionName = new System.Windows.Forms.Label();
            this.lblPermissionCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPermissionCodeValue
            // 
            this.txtPermissionCodeValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPermissionCodeValue.Location = new System.Drawing.Point(212, 37);
            this.txtPermissionCodeValue.Name = "txtPermissionCodeValue";
            this.txtPermissionCodeValue.Size = new System.Drawing.Size(240, 22);
            this.txtPermissionCodeValue.TabIndex = 0;
            // 
            // txtPermissionNameValue
            // 
            this.txtPermissionNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPermissionNameValue.Location = new System.Drawing.Point(212, 6);
            this.txtPermissionNameValue.Name = "txtPermissionNameValue";
            this.txtPermissionNameValue.Size = new System.Drawing.Size(240, 22);
            this.txtPermissionNameValue.TabIndex = 1;
            // 
            // txtDescriptionValue
            // 
            this.txtDescriptionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescriptionValue.Location = new System.Drawing.Point(212, 68);
            this.txtDescriptionValue.Multiline = true;
            this.txtDescriptionValue.Name = "txtDescriptionValue";
            this.txtDescriptionValue.Size = new System.Drawing.Size(240, 67);
            this.txtDescriptionValue.TabIndex = 2;
            // 
            // lblPermissionName
            // 
            this.lblPermissionName.AutoSize = true;
            this.lblPermissionName.Location = new System.Drawing.Point(13, 9);
            this.lblPermissionName.Name = "lblPermissionName";
            this.lblPermissionName.Size = new System.Drawing.Size(114, 16);
            this.lblPermissionName.TabIndex = 5;
            this.lblPermissionName.Text = "Permission Name";
            // 
            // lblPermissionCode
            // 
            this.lblPermissionCode.AutoSize = true;
            this.lblPermissionCode.Location = new System.Drawing.Point(13, 40);
            this.lblPermissionCode.Name = "lblPermissionCode";
            this.lblPermissionCode.Size = new System.Drawing.Size(110, 16);
            this.lblPermissionCode.TabIndex = 6;
            this.lblPermissionCode.Text = "Permission Code";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 71);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(281, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(377, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // PermissionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(464, 182);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPermissionCode);
            this.Controls.Add(this.lblPermissionName);
            this.Controls.Add(this.txtDescriptionValue);
            this.Controls.Add(this.txtPermissionNameValue);
            this.Controls.Add(this.txtPermissionCodeValue);
            this.Name = "PermissionDetails";
            this.Text = "PermissionDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPermissionCodeValue;
        private System.Windows.Forms.TextBox txtPermissionNameValue;
        private System.Windows.Forms.TextBox txtDescriptionValue;
        private System.Windows.Forms.Label lblPermissionName;
        private System.Windows.Forms.Label lblPermissionCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}