namespace WindowsFormsApp1.UI
{
    partial class SearchPrescriptions
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
            this.surnamecheck = new System.Windows.Forms.CheckBox();
            this.prenum = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelsearch = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // surnamecheck
            // 
            this.surnamecheck.AutoSize = true;
            this.surnamecheck.Location = new System.Drawing.Point(91, 419);
            this.surnamecheck.Name = "surnamecheck";
            this.surnamecheck.Size = new System.Drawing.Size(156, 29);
            this.surnamecheck.TabIndex = 0;
            this.surnamecheck.Text = "by surname";
            this.surnamecheck.UseVisualStyleBackColor = true;
            this.surnamecheck.CheckedChanged += new System.EventHandler(this.surnamecheck_CheckedChanged);
            // 
            // prenum
            // 
            this.prenum.AutoSize = true;
            this.prenum.Location = new System.Drawing.Point(91, 454);
            this.prenum.Name = "prenum";
            this.prenum.Size = new System.Drawing.Size(269, 29);
            this.prenum.TabIndex = 1;
            this.prenum.Text = "by prescription number:";
            this.prenum.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.Location = new System.Drawing.Point(86, 379);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(284, 25);
            this.labelsearch.TabIndex = 3;
            this.labelsearch.Text = "search for prescriptiopns by:";
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(91, 500);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(235, 31);
            this.searchbox.TabIndex = 4;
            // 
            // SearchPrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.labelsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prenum);
            this.Controls.Add(this.surnamecheck);
            this.Name = "SearchPrescriptions";
            this.Size = new System.Drawing.Size(1504, 1064);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox surnamecheck;
        private System.Windows.Forms.CheckBox prenum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.TextBox searchbox;
    }
}
