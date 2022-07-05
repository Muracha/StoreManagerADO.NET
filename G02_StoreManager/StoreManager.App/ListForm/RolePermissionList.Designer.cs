namespace StoreManager.App.ListForm
{
    partial class RolePermissionList
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
            this.grdRolePermission = new System.Windows.Forms.DataGridView();
            this.PermissionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdRolePermission)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRolePermission
            // 
            this.grdRolePermission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdRolePermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRolePermission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PermissionName,
            this.Description});
            this.grdRolePermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRolePermission.Location = new System.Drawing.Point(0, 0);
            this.grdRolePermission.Name = "grdRolePermission";
            this.grdRolePermission.RowHeadersWidth = 51;
            this.grdRolePermission.RowTemplate.Height = 24;
            this.grdRolePermission.Size = new System.Drawing.Size(800, 450);
            this.grdRolePermission.TabIndex = 0;
            // 
            // PermissionName
            // 
            this.PermissionName.DataPropertyName = "PermissionName";
            this.PermissionName.HeaderText = "Permission Name";
            this.PermissionName.MinimumWidth = 6;
            this.PermissionName.Name = "PermissionName";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // RolePermissionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdRolePermission);
            this.Name = "RolePermissionList";
            this.Text = "RolePermissionList";
            ((System.ComponentModel.ISupportInitialize)(this.grdRolePermission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdRolePermission;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermissionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}