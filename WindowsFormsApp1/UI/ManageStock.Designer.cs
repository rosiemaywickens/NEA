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
            this.label2 = new System.Windows.Forms.Label();
            this.medidbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lidbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eneterbut = new System.Windows.Forms.Button();
            this.errorbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter stock here:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "medicineID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // medidbox
            // 
            this.medidbox.Location = new System.Drawing.Point(198, 105);
            this.medidbox.Name = "medidbox";
            this.medidbox.Size = new System.Drawing.Size(100, 31);
            this.medidbox.TabIndex = 3;
            this.medidbox.TextChanged += new System.EventHandler(this.medidbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "LocationId:";
            // 
            // lidbox
            // 
            this.lidbox.Location = new System.Drawing.Point(198, 157);
            this.lidbox.Name = "lidbox";
            this.lidbox.Size = new System.Drawing.Size(100, 31);
            this.lidbox.TabIndex = 5;
            this.lidbox.TextChanged += new System.EventHandler(this.lidbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 6;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(198, 211);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(100, 31);
            this.AmountBox.TabIndex = 8;
            this.AmountBox.TextChanged += new System.EventHandler(this.AmountBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount:";
            // 
            // eneterbut
            // 
            this.eneterbut.Location = new System.Drawing.Point(198, 270);
            this.eneterbut.Name = "eneterbut";
            this.eneterbut.Size = new System.Drawing.Size(109, 63);
            this.eneterbut.TabIndex = 9;
            this.eneterbut.Text = "enter";
            this.eneterbut.UseVisualStyleBackColor = true;
            this.eneterbut.Click += new System.EventHandler(this.eneterbut_Click);
            // 
            // errorbox
            // 
            this.errorbox.Location = new System.Drawing.Point(73, 366);
            this.errorbox.Multiline = true;
            this.errorbox.Name = "errorbox";
            this.errorbox.Size = new System.Drawing.Size(532, 220);
            this.errorbox.TabIndex = 10;
            this.errorbox.TextChanged += new System.EventHandler(this.errorbox_TextChanged);
            // 
            // ManageStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorbox);
            this.Controls.Add(this.eneterbut);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lidbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.medidbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageStock";
            this.Size = new System.Drawing.Size(1996, 1040);
            this.Load += new System.EventHandler(this.ManageStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox medidbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lidbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button eneterbut;
        private System.Windows.Forms.TextBox errorbox;
    }
}
