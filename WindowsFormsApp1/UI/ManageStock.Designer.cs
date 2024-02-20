namespace WindowsFormsApp1.UI
{
    partial class ManageStock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lidbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eneterbut = new System.Windows.Forms.Button();
            this.errorbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BrandBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter stock here:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "LocationId:";
            // 
            // lidbox
            // 
            this.lidbox.Location = new System.Drawing.Point(99, 90);
            this.lidbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lidbox.Name = "lidbox";
            this.lidbox.Size = new System.Drawing.Size(52, 20);
            this.lidbox.TabIndex = 5;
            this.lidbox.TextChanged += new System.EventHandler(this.lidbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(99, 118);
            this.AmountBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(52, 20);
            this.AmountBox.TabIndex = 8;
            this.AmountBox.TextChanged += new System.EventHandler(this.AmountBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount:";
            // 
            // eneterbut
            // 
            this.eneterbut.Location = new System.Drawing.Point(99, 176);
            this.eneterbut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eneterbut.Name = "eneterbut";
            this.eneterbut.Size = new System.Drawing.Size(54, 33);
            this.eneterbut.TabIndex = 9;
            this.eneterbut.Text = "enter";
            this.eneterbut.UseVisualStyleBackColor = true;
            this.eneterbut.Click += new System.EventHandler(this.eneterbut_Click);
            // 
            // errorbox
            // 
            this.errorbox.Location = new System.Drawing.Point(37, 229);
            this.errorbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.errorbox.Multiline = true;
            this.errorbox.Name = "errorbox";
            this.errorbox.Size = new System.Drawing.Size(268, 116);
            this.errorbox.TabIndex = 10;
            this.errorbox.TextChanged += new System.EventHandler(this.errorbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Brand:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // BrandBox
            // 
            this.BrandBox.Location = new System.Drawing.Point(99, 145);
            this.BrandBox.Margin = new System.Windows.Forms.Padding(2);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(52, 20);
            this.BrandBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "MedicineName:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(99, 63);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(52, 20);
            this.NameBox.TabIndex = 14;
            // 
            // ManageStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BrandBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.errorbox);
            this.Controls.Add(this.eneterbut);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lidbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageStock";
            this.Size = new System.Drawing.Size(998, 541);
            this.Load += new System.EventHandler(this.ManageStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lidbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button eneterbut;
        private System.Windows.Forms.TextBox errorbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BrandBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameBox;
    }
}
