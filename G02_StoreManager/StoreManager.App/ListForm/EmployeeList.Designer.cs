namespace StoreManager.App.ListForm
{
    partial class EmployeeList
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
            this.components = new System.ComponentModel.Container();
            this.dgEmployeeList = new System.Windows.Forms.DataGridView();
            this.g02_StoreDataSet = new StoreManager.App.G02_StoreDataSet();
            this.g02StoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g02_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g02StoreDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmployeeList
            // 
            this.dgEmployeeList.AllowUserToAddRows = false;
            this.dgEmployeeList.AllowUserToDeleteRows = false;
            this.dgEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.BirthDate,
            this.HireDate,
            this.CreateDate});
            this.dgEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEmployeeList.Location = new System.Drawing.Point(0, 0);
            this.dgEmployeeList.Name = "dgEmployeeList";
            this.dgEmployeeList.ReadOnly = true;
            this.dgEmployeeList.RowHeadersWidth = 51;
            this.dgEmployeeList.RowTemplate.Height = 24;
            this.dgEmployeeList.Size = new System.Drawing.Size(1221, 572);
            this.dgEmployeeList.TabIndex = 0;
            this.dgEmployeeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployeeList_CellClick);
            // 
            // g02_StoreDataSet
            // 
            this.g02_StoreDataSet.DataSetName = "G02_StoreDataSet";
            this.g02_StoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // g02StoreDataSetBindingSource
            // 
            this.g02StoreDataSetBindingSource.DataSource = this.g02_StoreDataSet;
            this.g02StoreDataSetBindingSource.Position = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Birth Date";
            this.BirthDate.MinimumWidth = 6;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // HireDate
            // 
            this.HireDate.DataPropertyName = "HireDate";
            this.HireDate.HeaderText = "Hire Date";
            this.HireDate.MinimumWidth = 6;
            this.HireDate.Name = "HireDate";
            this.HireDate.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "Create Date";
            this.CreateDate.MinimumWidth = 6;
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 572);
            this.Controls.Add(this.dgEmployeeList);
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g02_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g02StoreDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmployeeList;
        private System.Windows.Forms.BindingSource g02StoreDataSetBindingSource;
        private G02_StoreDataSet g02_StoreDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
    }
}