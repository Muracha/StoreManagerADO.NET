namespace StoreManager.App.ListForm
{
    partial class PermissionList
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
            this.grdPermission = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermissionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermissionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdPermission)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPermission
            // 
            this.grdPermission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPermission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PermissionName,
            this.PermissionCode,
            this.Description,
            this.CreateDate,
            this.IsDeleted});
            this.grdPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPermission.Location = new System.Drawing.Point(0, 0);
            this.grdPermission.Name = "grdPermission";
            this.grdPermission.RowHeadersWidth = 51;
            this.grdPermission.RowTemplate.Height = 24;
            this.grdPermission.Size = new System.Drawing.Size(925, 541);
            this.grdPermission.TabIndex = 0;
            this.grdPermission.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPermission_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // PermissionName
            // 
            this.PermissionName.DataPropertyName = "PermissionName";
            this.PermissionName.HeaderText = "Permission Name";
            this.PermissionName.MinimumWidth = 6;
            this.PermissionName.Name = "PermissionName";
            // 
            // PermissionCode
            // 
            this.PermissionCode.DataPropertyName = "PermissionCode";
            this.PermissionCode.HeaderText = "Permission Code";
            this.PermissionCode.MinimumWidth = 6;
            this.PermissionCode.Name = "PermissionCode";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "Create Date";
            this.CreateDate.MinimumWidth = 6;
            this.CreateDate.Name = "CreateDate";
            // 
            // IsDeleted
            // 
            this.IsDeleted.DataPropertyName = "IsDeleted";
            this.IsDeleted.HeaderText = "Deleted";
            this.IsDeleted.MinimumWidth = 6;
            this.IsDeleted.Name = "IsDeleted";
            // 
            // PermissionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 541);
            this.Controls.Add(this.grdPermission);
            this.Name = "PermissionList";
            this.Text = "PermissionList";
            ((System.ComponentModel.ISupportInitialize)(this.grdPermission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPermission;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermissionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermissionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeleted;
    }
}