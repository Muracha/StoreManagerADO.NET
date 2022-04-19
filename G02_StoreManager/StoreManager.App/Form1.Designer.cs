
namespace StoreManager.App
{
	partial class Form1
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
            this.b = new System.Windows.Forms.DateTimePicker();
            this.h = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b
            // 
            this.b.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.b.Location = new System.Drawing.Point(284, 149);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(200, 20);
            this.b.TabIndex = 0;
            // 
            // h
            // 
            this.h.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.h.Location = new System.Drawing.Point(284, 187);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(200, 20);
            this.h.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.h);
            this.Controls.Add(this.b);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.DateTimePicker b;
        private System.Windows.Forms.DateTimePicker h;
        private System.Windows.Forms.Button button1;
    }
}

