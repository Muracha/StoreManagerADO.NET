namespace StoreManager.App.ListForm
{
    partial class ContactInfoList
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
            this.grdContactInfo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPrimary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdContactInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // grdContactInfo
            // 
            this.grdContactInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdContactInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContactInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EmployeeID,
            this.ContactType,
            this.ContactData,
            this.IsPrimary,
            this.CreateDate,
            this.IsDeleted});
            this.grdContactInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContactInfo.Location = new System.Drawing.Point(0, 0);
            this.grdContactInfo.Name = "grdContactInfo";
            this.grdContactInfo.RowHeadersWidth = 51;
            this.grdContactInfo.RowTemplate.Height = 24;
            this.grdContactInfo.Size = new System.Drawing.Size(904, 487);
            this.grdContactInfo.TabIndex = 0;
            this.grdContactInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdContactInfo_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "Employee ID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            // 
            // ContactType
            // 
            this.ContactType.DataPropertyName = "ContactType";
            this.ContactType.HeaderText = "Contact Type";
            this.ContactType.MinimumWidth = 6;
            this.ContactType.Name = "ContactType";
            // 
            // ContactData
            // 
            this.ContactData.DataPropertyName = "ContactData";
            this.ContactData.HeaderText = "Contact Data";
            this.ContactData.MinimumWidth = 6;
            this.ContactData.Name = "ContactData";
            // 
            // IsPrimary
            // 
            this.IsPrimary.DataPropertyName = "IsPrimary";
            this.IsPrimary.HeaderText = "Primary";
            this.IsPrimary.MinimumWidth = 6;
            this.IsPrimary.Name = "IsPrimary";
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
            // ContactInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 487);
            this.Controls.Add(this.grdContactInfo);
            this.Name = "ContactInfoList";
            this.Text = "ContactInfoList";
            ((System.ComponentModel.ISupportInitialize)(this.grdContactInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdContactInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactData;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPrimary;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeleted;
    }
}