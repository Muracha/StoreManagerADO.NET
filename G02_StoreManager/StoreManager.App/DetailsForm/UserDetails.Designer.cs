
namespace StoreManager.App
{
    partial class UserDetails
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtIDValue = new System.Windows.Forms.TextBox();
            this.txtUserNameValue = new System.Windows.Forms.TextBox();
            this.txtPasswordValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSelectEmployee = new System.Windows.Forms.ComboBox();
            this.lblSelectEmployee = new System.Windows.Forms.Label();
            this.ckBIsActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(295, 192);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(403, 192);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtIDValue
            // 
            this.txtIDValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDValue.Enabled = false;
            this.txtIDValue.Location = new System.Drawing.Point(123, 55);
            this.txtIDValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDValue.Name = "txtIDValue";
            this.txtIDValue.Size = new System.Drawing.Size(379, 22);
            this.txtIDValue.TabIndex = 2;
            this.txtIDValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserID_KeyPress);
            // 
            // txtUserNameValue
            // 
            this.txtUserNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserNameValue.Location = new System.Drawing.Point(123, 87);
            this.txtUserNameValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserNameValue.Name = "txtUserNameValue";
            this.txtUserNameValue.Size = new System.Drawing.Size(379, 22);
            this.txtUserNameValue.TabIndex = 3;
            // 
            // txtPasswordValue
            // 
            this.txtPasswordValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPasswordValue.Location = new System.Drawing.Point(123, 119);
            this.txtPasswordValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordValue.Name = "txtPasswordValue";
            this.txtPasswordValue.Size = new System.Drawing.Size(379, 22);
            this.txtPasswordValue.TabIndex = 5;
            this.txtPasswordValue.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // cmbSelectEmployee
            // 
            this.cmbSelectEmployee.DisplayMember = "FullName";
            this.cmbSelectEmployee.FormattingEnabled = true;
            this.cmbSelectEmployee.Location = new System.Drawing.Point(123, 22);
            this.cmbSelectEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSelectEmployee.Name = "cmbSelectEmployee";
            this.cmbSelectEmployee.Size = new System.Drawing.Size(379, 24);
            this.cmbSelectEmployee.TabIndex = 14;
            this.cmbSelectEmployee.ValueMember = "ID";
            this.cmbSelectEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbSelectEmployee_SelectedIndexChanged);
            // 
            // lblSelectEmployee
            // 
            this.lblSelectEmployee.AutoSize = true;
            this.lblSelectEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectEmployee.Location = new System.Drawing.Point(16, 22);
            this.lblSelectEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectEmployee.Name = "lblSelectEmployee";
            this.lblSelectEmployee.Size = new System.Drawing.Size(49, 18);
            this.lblSelectEmployee.TabIndex = 15;
            this.lblSelectEmployee.Text = "Select";
            // 
            // ckBIsActive
            // 
            this.ckBIsActive.AutoSize = true;
            this.ckBIsActive.Location = new System.Drawing.Point(123, 155);
            this.ckBIsActive.Margin = new System.Windows.Forms.Padding(4);
            this.ckBIsActive.Name = "ckBIsActive";
            this.ckBIsActive.Size = new System.Drawing.Size(76, 20);
            this.ckBIsActive.TabIndex = 16;
            this.ckBIsActive.Text = "IsActive";
            this.ckBIsActive.UseVisualStyleBackColor = true;
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(519, 235);
            this.Controls.Add(this.ckBIsActive);
            this.Controls.Add(this.lblSelectEmployee);
            this.Controls.Add(this.cmbSelectEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswordValue);
            this.Controls.Add(this.txtUserNameValue);
            this.Controls.Add(this.txtIDValue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserDetails";
            this.Load += new System.EventHandler(this.UserDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtIDValue;
        public System.Windows.Forms.TextBox txtUserNameValue;
        public System.Windows.Forms.TextBox txtPasswordValue;
        private System.Windows.Forms.ComboBox cmbSelectEmployee;
        private System.Windows.Forms.Label lblSelectEmployee;
        private System.Windows.Forms.CheckBox ckBIsActive;
    }
}