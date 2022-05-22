namespace StoreManager.App
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pctUserLogo = new System.Windows.Forms.PictureBox();
            this.pctUserGifLogo = new System.Windows.Forms.PictureBox();
            this.pctPassword = new System.Windows.Forms.PictureBox();
            this.pctUsername = new System.Windows.Forms.PictureBox();
            this.pnlUserName = new System.Windows.Forms.FlowLayoutPanel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlPassword = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctUserLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUserGifLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Image = global::StoreManager.App.Properties.Resources.Btnlogin;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(246, 188);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(86, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Login";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::StoreManager.App.Properties.Resources.BtnCancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(337, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // pctUserLogo
            // 
            this.pctUserLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctUserLogo.Image = global::StoreManager.App.Properties.Resources.userLogi;
            this.pctUserLogo.Location = new System.Drawing.Point(297, 12);
            this.pctUserLogo.Name = "pctUserLogo";
            this.pctUserLogo.Size = new System.Drawing.Size(80, 59);
            this.pctUserLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUserLogo.TabIndex = 11;
            this.pctUserLogo.TabStop = false;
            // 
            // pctUserGifLogo
            // 
            this.pctUserGifLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctUserGifLogo.Image")));
            this.pctUserGifLogo.Location = new System.Drawing.Point(12, 12);
            this.pctUserGifLogo.Name = "pctUserGifLogo";
            this.pctUserGifLogo.Size = new System.Drawing.Size(218, 199);
            this.pctUserGifLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUserGifLogo.TabIndex = 9;
            this.pctUserGifLogo.TabStop = false;
            // 
            // pctPassword
            // 
            this.pctPassword.Image = global::StoreManager.App.Properties.Resources.password;
            this.pctPassword.Location = new System.Drawing.Point(240, 130);
            this.pctPassword.Name = "pctPassword";
            this.pctPassword.Size = new System.Drawing.Size(22, 20);
            this.pctPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPassword.TabIndex = 8;
            this.pctPassword.TabStop = false;
            // 
            // pctUsername
            // 
            this.pctUsername.Image = global::StoreManager.App.Properties.Resources.User;
            this.pctUsername.Location = new System.Drawing.Point(240, 92);
            this.pctUsername.Name = "pctUsername";
            this.pctUsername.Size = new System.Drawing.Size(22, 20);
            this.pctUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUsername.TabIndex = 7;
            this.pctUsername.TabStop = false;
            // 
            // pnlUserName
            // 
            this.pnlUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserName.Location = new System.Drawing.Point(264, 108);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Size = new System.Drawing.Size(158, 7);
            this.pnlUserName.TabIndex = 12;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUsername.Location = new System.Drawing.Point(264, 92);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(159, 20);
            this.txtUsername.TabIndex = 13;
            this.txtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            // 
            // pnlPassword
            // 
            this.pnlPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPassword.Location = new System.Drawing.Point(264, 150);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlPassword.Size = new System.Drawing.Size(159, 4);
            this.pnlPassword.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPassword.Location = new System.Drawing.Point(264, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(159, 20);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // ShowPassword
            // 
            this.ShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Checked = true;
            this.ShowPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowPassword.Location = new System.Drawing.Point(407, 160);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(15, 14);
            this.ShowPassword.TabIndex = 16;
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(435, 223);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pnlUserName);
            this.Controls.Add(this.pctUserLogo);
            this.Controls.Add(this.pctUserGifLogo);
            this.Controls.Add(this.pctPassword);
            this.Controls.Add(this.pctUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pctUserLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUserGifLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pctUsername;
        private System.Windows.Forms.PictureBox pctPassword;
        private System.Windows.Forms.PictureBox pctUserGifLogo;
        private System.Windows.Forms.PictureBox pctUserLogo;
        private System.Windows.Forms.FlowLayoutPanel pnlUserName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.FlowLayoutPanel pnlPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox ShowPassword;
    }
}