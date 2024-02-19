namespace WindowsFormsApp1.UI
{
    partial class settings
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
            this.password1 = new System.Windows.Forms.TextBox();
            this.password2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter your chosen password bellow";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(138, 163);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(345, 31);
            this.password1.TabIndex = 1;
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(138, 243);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(345, 31);
            this.password2.TabIndex = 2;
            this.password2.TextChanged += new System.EventHandler(this.password2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "confirm password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "enter the user name";
            // 
            // userbox
            // 
            this.userbox.Location = new System.Drawing.Point(143, 379);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(340, 31);
            this.userbox.TabIndex = 5;
            this.userbox.TextChanged += new System.EventHandler(this.userbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.label1);
            this.Name = "settings";
            this.Size = new System.Drawing.Size(1734, 750);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userbox;
        private System.Windows.Forms.Button button1;
    }
}
