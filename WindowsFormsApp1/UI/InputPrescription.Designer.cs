namespace WindowsFormsApp1.UI
{
    partial class InputPrescription
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
            this.inputbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xprin = new System.Windows.Forms.MaskedTextBox();
            this.xmein = new System.Windows.Forms.MaskedTextBox();
            this.day = new System.Windows.Forms.MaskedTextBox();
            this.xsuin = new System.Windows.Forms.TextBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.month = new System.Windows.Forms.MaskedTextBox();
            this.year = new System.Windows.Forms.MaskedTextBox();
            this.errorbox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputbutton
            // 
            this.inputbutton.Location = new System.Drawing.Point(64, 252);
            this.inputbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputbutton.Name = "inputbutton";
            this.inputbutton.Size = new System.Drawing.Size(108, 36);
            this.inputbutton.TabIndex = 0;
            this.inputbutton.Text = "Input Prescription";
            this.inputbutton.UseVisualStyleBackColor = true;
            this.inputbutton.Click += new System.EventHandler(this.inputbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "prescriptionID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MedicineID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Expiry date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Surname:";
            // 
            // xprin
            // 
            this.xprin.Location = new System.Drawing.Point(96, 30);
            this.xprin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xprin.Name = "xprin";
            this.xprin.Size = new System.Drawing.Size(58, 20);
            this.xprin.TabIndex = 5;
            this.xprin.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.xprin_MaskInputRejected);
            // 
            // xmein
            // 
            this.xmein.Location = new System.Drawing.Point(96, 55);
            this.xmein.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xmein.Name = "xmein";
            this.xmein.Size = new System.Drawing.Size(58, 20);
            this.xmein.TabIndex = 6;
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(96, 76);
            this.day.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(24, 20);
            this.day.TabIndex = 7;
            this.day.Text = "dd";
            this.day.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.day_MaskInputRejected);
            // 
            // xsuin
            // 
            this.xsuin.Location = new System.Drawing.Point(96, 97);
            this.xsuin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xsuin.Name = "xsuin";
            this.xsuin.Size = new System.Drawing.Size(58, 20);
            this.xsuin.TabIndex = 8;
            this.xsuin.TextChanged += new System.EventHandler(this.xsuin_TextChanged);
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(119, 76);
            this.month.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(29, 20);
            this.month.TabIndex = 9;
            this.month.Text = "mm";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(148, 76);
            this.year.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(42, 20);
            this.year.TabIndex = 10;
            this.year.Text = "yyyy";
            // 
            // errorbox2
            // 
            this.errorbox2.Location = new System.Drawing.Point(22, 125);
            this.errorbox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.errorbox2.Multiline = true;
            this.errorbox2.Name = "errorbox2";
            this.errorbox2.Size = new System.Drawing.Size(153, 114);
            this.errorbox2.TabIndex = 11;
            this.errorbox2.TextChanged += new System.EventHandler(this.errorbox2_TextChanged);
            // 
            // InputPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorbox2);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.xsuin);
            this.Controls.Add(this.day);
            this.Controls.Add(this.xmein);
            this.Controls.Add(this.xprin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputbutton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InputPrescription";
            this.Size = new System.Drawing.Size(721, 462);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox xprin;
        private System.Windows.Forms.MaskedTextBox xmein;
        private System.Windows.Forms.MaskedTextBox day;
        private System.Windows.Forms.TextBox xsuin;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.MaskedTextBox month;
        private System.Windows.Forms.MaskedTextBox year;
        private System.Windows.Forms.TextBox errorbox2;
    }
}
