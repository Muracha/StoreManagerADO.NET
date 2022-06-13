namespace StoreManager.App
{
    partial class UserList
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
            this.grdUserList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUserList
            // 
            this.grdUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserName,
            this.Password,
            this.CreateDate,
            this.IsActive,
            this.IsDeleted});
            this.grdUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUserList.Location = new System.Drawing.Point(0, 0);
            this.grdUserList.Name = "grdUserList";
            this.grdUserList.Size = new System.Drawing.Size(800, 450);
            this.grdUserList.TabIndex = 0;
            this.grdUserList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUserList_CellClick);
            this.grdUserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUserList_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "User ID";
            this.ID.Name = "ID";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "Username";
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "Create Date";
            this.CreateDate.Name = "CreateDate";
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Is Active";
            this.IsActive.Name = "IsActive";
            // 
            // IsDeleted
            // 
            this.IsDeleted.DataPropertyName = "IsDeleted";
            this.IsDeleted.HeaderText = "Is Deleted";
            this.IsDeleted.Name = "IsDeleted";
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdUserList);
            this.Name = "UserList";
            this.Text = "UserList";
            this.Load += new System.EventHandler(this.UserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView grdUserList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeleted;
    }
}