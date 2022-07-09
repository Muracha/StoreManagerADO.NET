namespace StoreManager.App.ListForm
{
    partial class UserRoleList
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdCurrentUserRoles = new System.Windows.Forms.DataGridView();
            this.deleteRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCurrentUserRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRolesToolStripMenuItem,
            this.deleteRoleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewRolesToolStripMenuItem
            // 
            this.addNewRolesToolStripMenuItem.Name = "addNewRolesToolStripMenuItem";
            this.addNewRolesToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.addNewRolesToolStripMenuItem.Text = "Add new Roles";
            this.addNewRolesToolStripMenuItem.Click += new System.EventHandler(this.addNewRolesToolStripMenuItem_Click);
            // 
            // grdCurrentUserRoles
            // 
            this.grdCurrentUserRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCurrentUserRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCurrentUserRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleName,
            this.Description,
            this.ID,
            this.CreateDate,
            this.IsDeleted});
            this.grdCurrentUserRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCurrentUserRoles.Location = new System.Drawing.Point(0, 28);
            this.grdCurrentUserRoles.Name = "grdCurrentUserRoles";
            this.grdCurrentUserRoles.RowHeadersWidth = 51;
            this.grdCurrentUserRoles.RowTemplate.Height = 24;
            this.grdCurrentUserRoles.Size = new System.Drawing.Size(800, 422);
            this.grdCurrentUserRoles.TabIndex = 1;
            this.grdCurrentUserRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCurrentUserRoles_CellClick);
            // 
            // deleteRoleToolStripMenuItem
            // 
            this.deleteRoleToolStripMenuItem.Name = "deleteRoleToolStripMenuItem";
            this.deleteRoleToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.deleteRoleToolStripMenuItem.Text = "Delete Role";
            this.deleteRoleToolStripMenuItem.Click += new System.EventHandler(this.deleteRoleToolStripMenuItem_Click);
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "Role Name";
            this.RoleName.MinimumWidth = 6;
            this.RoleName.Name = "RoleName";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "CreateDate";
            this.CreateDate.MinimumWidth = 6;
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Visible = false;
            // 
            // IsDeleted
            // 
            this.IsDeleted.DataPropertyName = "IsDeleted";
            this.IsDeleted.HeaderText = "IsDeleted";
            this.IsDeleted.MinimumWidth = 6;
            this.IsDeleted.Name = "IsDeleted";
            this.IsDeleted.Visible = false;
            // 
            // CurrentUserRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdCurrentUserRoles);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CurrentUserRoles";
            this.Text = "CurrentUserRoles";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCurrentUserRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRoleToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdCurrentUserRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeleted;
    }
}