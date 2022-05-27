namespace StoreManager.App
{
    partial class Home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbllSellesPercent = new System.Windows.Forms.Label();
            this.pctSellePanel = new System.Windows.Forms.PictureBox();
            this.lblNumSales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRevenuePercent = new System.Windows.Forms.Label();
            this.pctRevenuePanel = new System.Windows.Forms.PictureBox();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbllProfitPercent = new System.Windows.Forms.Label();
            this.pctProfitPanel = new System.Windows.Forms.PictureBox();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartSellesByDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTotalCounter = new System.Windows.Forms.Panel();
            this.pctCategoriesCounter = new System.Windows.Forms.PictureBox();
            this.pctProductsCounter = new System.Windows.Forms.PictureBox();
            this.pctSupliersCounter = new System.Windows.Forms.PictureBox();
            this.pctEmployeesCounter = new System.Windows.Forms.PictureBox();
            this.pctUserCounter = new System.Windows.Forms.PictureBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSupliers = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grdUnderStock = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProductsUnderStock = new System.Windows.Forms.Label();
            this.btnSearchCustoomDate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSellePanel)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRevenuePanel)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctProfitPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSellesByDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            this.pnlTotalCounter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCategoriesCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProductsCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSupliersCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmployeesCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUserCounter)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnderStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(12, 16);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(56, 20);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Home";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.CustomFormat = "MMM,dd,yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(408, 14);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(107, 20);
            this.dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.CustomFormat = "MMM,dd,yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(531, 14);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(106, 20);
            this.dtpEndDate.TabIndex = 2;
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast30Days.BackColor = System.Drawing.Color.White;
            this.btnLast30Days.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast30Days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLast30Days.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnLast30Days.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLast30Days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLast30Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast30Days.Location = new System.Drawing.Point(827, 12);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(79, 23);
            this.btnLast30Days.TabIndex = 4;
            this.btnLast30Days.Text = "Last 30 Days";
            this.btnLast30Days.UseVisualStyleBackColor = false;
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast7Days.BackColor = System.Drawing.Color.White;
            this.btnLast7Days.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast7Days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLast7Days.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnLast7Days.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLast7Days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast7Days.Location = new System.Drawing.Point(757, 12);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(75, 23);
            this.btnLast7Days.TabIndex = 5;
            this.btnLast7Days.Text = "Last 7 Days";
            this.btnLast7Days.UseVisualStyleBackColor = false;
            // 
            // btnToday
            // 
            this.btnToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToday.BackColor = System.Drawing.Color.White;
            this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnToday.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnToday.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnToday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Location = new System.Drawing.Point(688, 12);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 23);
            this.btnToday.TabIndex = 6;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = false;
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThisMonth.BackColor = System.Drawing.Color.White;
            this.btnThisMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThisMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThisMonth.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnThisMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThisMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonth.Location = new System.Drawing.Point(904, 12);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(75, 23);
            this.btnThisMonth.TabIndex = 7;
            this.btnThisMonth.Text = "This Month";
            this.btnThisMonth.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.lbllSellesPercent);
            this.panel1.Controls.Add(this.pctSellePanel);
            this.panel1.Controls.Add(this.lblNumSales);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 79);
            this.panel1.TabIndex = 9;
            // 
            // lbllSellesPercent
            // 
            this.lbllSellesPercent.AutoSize = true;
            this.lbllSellesPercent.BackColor = System.Drawing.Color.IndianRed;
            this.lbllSellesPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllSellesPercent.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbllSellesPercent.Location = new System.Drawing.Point(164, 34);
            this.lbllSellesPercent.Name = "lbllSellesPercent";
            this.lbllSellesPercent.Size = new System.Drawing.Size(41, 20);
            this.lbllSellesPercent.TabIndex = 6;
            this.lbllSellesPercent.Text = "+0%";
            // 
            // pctSellePanel
            // 
            this.pctSellePanel.Image = global::StoreManager.App.Properties.Resources.sell;
            this.pctSellePanel.Location = new System.Drawing.Point(6, 28);
            this.pctSellePanel.Name = "pctSellePanel";
            this.pctSellePanel.Size = new System.Drawing.Size(52, 43);
            this.pctSellePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSellePanel.TabIndex = 2;
            this.pctSellePanel.TabStop = false;
            // 
            // lblNumSales
            // 
            this.lblNumSales.AutoSize = true;
            this.lblNumSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSales.ForeColor = System.Drawing.Color.Black;
            this.lblNumSales.Location = new System.Drawing.Point(65, 34);
            this.lblNumSales.Name = "lblNumSales";
            this.lblNumSales.Size = new System.Drawing.Size(56, 25);
            this.lblNumSales.TabIndex = 1;
            this.lblNumSales.Text = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Sales";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.lblRevenuePercent);
            this.panel2.Controls.Add(this.pctRevenuePanel);
            this.panel2.Controls.Add(this.lblTotalRevenue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(242, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 79);
            this.panel2.TabIndex = 10;
            // 
            // lblRevenuePercent
            // 
            this.lblRevenuePercent.AutoSize = true;
            this.lblRevenuePercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenuePercent.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRevenuePercent.Location = new System.Drawing.Point(209, 34);
            this.lblRevenuePercent.Name = "lblRevenuePercent";
            this.lblRevenuePercent.Size = new System.Drawing.Size(50, 20);
            this.lblRevenuePercent.TabIndex = 7;
            this.lblRevenuePercent.Text = "+00%";
            // 
            // pctRevenuePanel
            // 
            this.pctRevenuePanel.Image = global::StoreManager.App.Properties.Resources.Revenue;
            this.pctRevenuePanel.Location = new System.Drawing.Point(2, 28);
            this.pctRevenuePanel.Name = "pctRevenuePanel";
            this.pctRevenuePanel.Size = new System.Drawing.Size(48, 43);
            this.pctRevenuePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctRevenuePanel.TabIndex = 3;
            this.pctRevenuePanel.TabStop = false;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalRevenue.Location = new System.Drawing.Point(56, 34);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(56, 25);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Revenue";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.lbllProfitPercent);
            this.panel3.Controls.Add(this.pctProfitPanel);
            this.panel3.Controls.Add(this.lblTotalProfit);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(510, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 79);
            this.panel3.TabIndex = 11;
            // 
            // lbllProfitPercent
            // 
            this.lbllProfitPercent.AutoSize = true;
            this.lbllProfitPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllProfitPercent.ForeColor = System.Drawing.Color.Blue;
            this.lbllProfitPercent.Location = new System.Drawing.Point(413, 34);
            this.lbllProfitPercent.Name = "lbllProfitPercent";
            this.lbllProfitPercent.Size = new System.Drawing.Size(50, 20);
            this.lbllProfitPercent.TabIndex = 5;
            this.lbllProfitPercent.Text = "+00%";
            // 
            // pctProfitPanel
            // 
            this.pctProfitPanel.Image = global::StoreManager.App.Properties.Resources.profit;
            this.pctProfitPanel.Location = new System.Drawing.Point(3, 28);
            this.pctProfitPanel.Name = "pctProfitPanel";
            this.pctProfitPanel.Size = new System.Drawing.Size(51, 43);
            this.pctProfitPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctProfitPanel.TabIndex = 4;
            this.pctProfitPanel.TabStop = false;
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(60, 34);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(56, 25);
            this.lblTotalProfit.TabIndex = 1;
            this.lblTotalProfit.Text = "0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Profit";
            // 
            // chartSellesByDate
            // 
            this.chartSellesByDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chartSellesByDate.BackColor = System.Drawing.Color.Azure;
            chartArea1.Name = "ChartArea1";
            this.chartSellesByDate.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartSellesByDate.Legends.Add(legend1);
            this.chartSellesByDate.Location = new System.Drawing.Point(22, 150);
            this.chartSellesByDate.Name = "chartSellesByDate";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSellesByDate.Series.Add(series1);
            this.chartSellesByDate.Size = new System.Drawing.Size(670, 218);
            this.chartSellesByDate.TabIndex = 12;
            this.chartSellesByDate.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.Name = "Title1";
            title1.Text = "Selles by date";
            this.chartSellesByDate.Titles.Add(title1);
            // 
            // chartTopProducts
            // 
            this.chartTopProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chartTopProducts.BackColor = System.Drawing.Color.AntiqueWhite;
            chartArea2.Name = "ChartArea1";
            this.chartTopProducts.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chartTopProducts.Legends.Add(legend2);
            this.chartTopProducts.Location = new System.Drawing.Point(697, 150);
            this.chartTopProducts.Name = "chartTopProducts";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTopProducts.Series.Add(series2);
            this.chartTopProducts.Size = new System.Drawing.Size(279, 494);
            this.chartTopProducts.TabIndex = 13;
            this.chartTopProducts.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title2.Name = "Title1";
            title2.Text = " 10 Best selling products";
            this.chartTopProducts.Titles.Add(title2);
            // 
            // pnlTotalCounter
            // 
            this.pnlTotalCounter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTotalCounter.BackColor = System.Drawing.Color.Azure;
            this.pnlTotalCounter.Controls.Add(this.pctCategoriesCounter);
            this.pnlTotalCounter.Controls.Add(this.pctProductsCounter);
            this.pnlTotalCounter.Controls.Add(this.pctSupliersCounter);
            this.pnlTotalCounter.Controls.Add(this.pctEmployeesCounter);
            this.pnlTotalCounter.Controls.Add(this.pctUserCounter);
            this.pnlTotalCounter.Controls.Add(this.lblCategories);
            this.pnlTotalCounter.Controls.Add(this.label12);
            this.pnlTotalCounter.Controls.Add(this.lblUsers);
            this.pnlTotalCounter.Controls.Add(this.label14);
            this.pnlTotalCounter.Controls.Add(this.lblProducts);
            this.pnlTotalCounter.Controls.Add(this.label10);
            this.pnlTotalCounter.Controls.Add(this.lblSupliers);
            this.pnlTotalCounter.Controls.Add(this.label8);
            this.pnlTotalCounter.Controls.Add(this.lblEmployees);
            this.pnlTotalCounter.Controls.Add(this.label7);
            this.pnlTotalCounter.Controls.Add(this.label5);
            this.pnlTotalCounter.Location = new System.Drawing.Point(21, 374);
            this.pnlTotalCounter.Name = "pnlTotalCounter";
            this.pnlTotalCounter.Size = new System.Drawing.Size(217, 270);
            this.pnlTotalCounter.TabIndex = 10;
            // 
            // pctCategoriesCounter
            // 
            this.pctCategoriesCounter.Image = global::StoreManager.App.Properties.Resources.Categories;
            this.pctCategoriesCounter.Location = new System.Drawing.Point(6, 223);
            this.pctCategoriesCounter.Name = "pctCategoriesCounter";
            this.pctCategoriesCounter.Size = new System.Drawing.Size(41, 31);
            this.pctCategoriesCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCategoriesCounter.TabIndex = 18;
            this.pctCategoriesCounter.TabStop = false;
            // 
            // pctProductsCounter
            // 
            this.pctProductsCounter.Image = global::StoreManager.App.Properties.Resources.Productss;
            this.pctProductsCounter.Location = new System.Drawing.Point(7, 174);
            this.pctProductsCounter.Name = "pctProductsCounter";
            this.pctProductsCounter.Size = new System.Drawing.Size(41, 31);
            this.pctProductsCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctProductsCounter.TabIndex = 17;
            this.pctProductsCounter.TabStop = false;
            // 
            // pctSupliersCounter
            // 
            this.pctSupliersCounter.Image = global::StoreManager.App.Properties.Resources.Supliers;
            this.pctSupliersCounter.Location = new System.Drawing.Point(6, 125);
            this.pctSupliersCounter.Name = "pctSupliersCounter";
            this.pctSupliersCounter.Size = new System.Drawing.Size(41, 31);
            this.pctSupliersCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSupliersCounter.TabIndex = 16;
            this.pctSupliersCounter.TabStop = false;
            // 
            // pctEmployeesCounter
            // 
            this.pctEmployeesCounter.Image = global::StoreManager.App.Properties.Resources.employees1;
            this.pctEmployeesCounter.Location = new System.Drawing.Point(7, 78);
            this.pctEmployeesCounter.Name = "pctEmployeesCounter";
            this.pctEmployeesCounter.Size = new System.Drawing.Size(41, 31);
            this.pctEmployeesCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctEmployeesCounter.TabIndex = 15;
            this.pctEmployeesCounter.TabStop = false;
            // 
            // pctUserCounter
            // 
            this.pctUserCounter.Image = global::StoreManager.App.Properties.Resources.users;
            this.pctUserCounter.Location = new System.Drawing.Point(8, 37);
            this.pctUserCounter.Name = "pctUserCounter";
            this.pctUserCounter.Size = new System.Drawing.Size(41, 31);
            this.pctUserCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUserCounter.TabIndex = 14;
            this.pctUserCounter.TabStop = false;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.Location = new System.Drawing.Point(44, 236);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(56, 25);
            this.lblCategories.TabIndex = 13;
            this.lblCategories.Text = "0000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Number of Categories";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(46, 50);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(45, 25);
            this.lblUsers.TabIndex = 11;
            this.lblUsers.Text = "000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Number of Users";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(45, 187);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(56, 25);
            this.lblProducts.TabIndex = 7;
            this.lblProducts.Text = "0000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Number of Products";
            // 
            // lblSupliers
            // 
            this.lblSupliers.AutoSize = true;
            this.lblSupliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupliers.Location = new System.Drawing.Point(44, 138);
            this.lblSupliers.Name = "lblSupliers";
            this.lblSupliers.Size = new System.Drawing.Size(56, 25);
            this.lblSupliers.TabIndex = 5;
            this.lblSupliers.Text = "0000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Number of Supliers";
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.Location = new System.Drawing.Point(47, 91);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(45, 25);
            this.lblEmployees.TabIndex = 3;
            this.lblEmployees.Text = "000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Number of Employees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Counter";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.grdUnderStock);
            this.panel4.Controls.Add(this.lblProductsUnderStock);
            this.panel4.Location = new System.Drawing.Point(244, 374);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(447, 270);
            this.panel4.TabIndex = 14;
            // 
            // grdUnderStock
            // 
            this.grdUnderStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdUnderStock.BackgroundColor = System.Drawing.Color.Azure;
            this.grdUnderStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUnderStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Units});
            this.grdUnderStock.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdUnderStock.Location = new System.Drawing.Point(8, 37);
            this.grdUnderStock.Name = "grdUnderStock";
            this.grdUnderStock.Size = new System.Drawing.Size(430, 224);
            this.grdUnderStock.TabIndex = 1;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Units
            // 
            this.Units.HeaderText = "Units";
            this.Units.Name = "Units";
            // 
            // lblProductsUnderStock
            // 
            this.lblProductsUnderStock.AutoSize = true;
            this.lblProductsUnderStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsUnderStock.Location = new System.Drawing.Point(3, 0);
            this.lblProductsUnderStock.Name = "lblProductsUnderStock";
            this.lblProductsUnderStock.Size = new System.Drawing.Size(197, 25);
            this.lblProductsUnderStock.TabIndex = 0;
            this.lblProductsUnderStock.Text = "Products UnderStock";
            // 
            // btnSearchCustoomDate
            // 
            this.btnSearchCustoomDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchCustoomDate.BackColor = System.Drawing.Color.White;
            this.btnSearchCustoomDate.BackgroundImage = global::StoreManager.App.Properties.Resources.Search;
            this.btnSearchCustoomDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchCustoomDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCustoomDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchCustoomDate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnSearchCustoomDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchCustoomDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchCustoomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustoomDate.Location = new System.Drawing.Point(632, 14);
            this.btnSearchCustoomDate.Name = "btnSearchCustoomDate";
            this.btnSearchCustoomDate.Size = new System.Drawing.Size(27, 20);
            this.btnSearchCustoomDate.TabIndex = 8;
            this.btnSearchCustoomDate.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(991, 649);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlTotalCounter);
            this.Controls.Add(this.chartTopProducts);
            this.Controls.Add(this.chartSellesByDate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchCustoomDate);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnLast30Days);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSellePanel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRevenuePanel)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctProfitPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSellesByDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            this.pnlTotalCounter.ResumeLayout(false);
            this.pnlTotalCounter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCategoriesCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProductsCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSupliersCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmployeesCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUserCounter)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnderStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnSearchCustoomDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSellesByDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private System.Windows.Forms.Panel pnlTotalCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSupliers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblProductsUnderStock;
        private System.Windows.Forms.DataGridView grdUnderStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.PictureBox pctSellePanel;
        private System.Windows.Forms.PictureBox pctRevenuePanel;
        private System.Windows.Forms.PictureBox pctProfitPanel;
        private System.Windows.Forms.PictureBox pctCategoriesCounter;
        private System.Windows.Forms.PictureBox pctProductsCounter;
        private System.Windows.Forms.PictureBox pctSupliersCounter;
        private System.Windows.Forms.PictureBox pctEmployeesCounter;
        private System.Windows.Forms.PictureBox pctUserCounter;
        private System.Windows.Forms.Label lbllSellesPercent;
        private System.Windows.Forms.Label lblRevenuePercent;
        private System.Windows.Forms.Label lbllProfitPercent;
    }
}