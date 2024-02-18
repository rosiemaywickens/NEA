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
            this.labelsearch = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.enbut = new System.Windows.Forms.Button();
            this.searcherrors = new System.Windows.Forms.Label();
            this.resultsgrid = new System.Windows.Forms.DataGridView();
            this.q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultsgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // surnamecheck
            // 
            this.surnamecheck.AutoSize = true;
            this.surnamecheck.Location = new System.Drawing.Point(56, 93);
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
            this.prenum.Location = new System.Drawing.Point(56, 128);
            this.prenum.Name = "prenum";
            this.prenum.Size = new System.Drawing.Size(269, 29);
            this.prenum.TabIndex = 1;
            this.prenum.Text = "by prescription number:";
            this.prenum.UseVisualStyleBackColor = true;
            this.prenum.CheckedChanged += new System.EventHandler(this.prenum_CheckedChanged);
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.Location = new System.Drawing.Point(51, 53);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(284, 25);
            this.labelsearch.TabIndex = 3;
            this.labelsearch.Text = "search for prescriptiopns by:";
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(56, 174);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(310, 31);
            this.searchbox.TabIndex = 4;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // enbut
            // 
            this.enbut.Location = new System.Drawing.Point(56, 227);
            this.enbut.Name = "enbut";
            this.enbut.Size = new System.Drawing.Size(105, 45);
            this.enbut.TabIndex = 5;
            this.enbut.Text = "confirm";
            this.enbut.UseVisualStyleBackColor = true;
            this.enbut.Click += new System.EventHandler(this.enbut_Click);
            // 
            // searcherrors
            // 
            this.searcherrors.AutoSize = true;
            this.searcherrors.Location = new System.Drawing.Point(189, 227);
            this.searcherrors.Name = "searcherrors";
            this.searcherrors.Size = new System.Drawing.Size(0, 25);
            this.searcherrors.TabIndex = 6;
            // 
            // resultsgrid
            // 
            this.resultsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.q,
            this.w,
            this.e,
            this.r});
            this.resultsgrid.Location = new System.Drawing.Point(56, 330);
            this.resultsgrid.Name = "resultsgrid";
            this.resultsgrid.RowHeadersWidth = 82;
            this.resultsgrid.RowTemplate.Height = 33;
            this.resultsgrid.Size = new System.Drawing.Size(885, 290);
            this.resultsgrid.TabIndex = 7;
            this.resultsgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsgrid_CellContentClick);
            // 
            // q
            // 
            this.q.HeaderText = "PrescriptionID";
            this.q.MinimumWidth = 10;
            this.q.Name = "q";
            this.q.Width = 200;
            // 
            // w
            // 
            this.w.HeaderText = "MedicineID";
            this.w.MinimumWidth = 10;
            this.w.Name = "w";
            this.w.Width = 200;
            // 
            // e
            // 
            this.e.HeaderText = "ExpiryDate";
            this.e.MinimumWidth = 10;
            this.e.Name = "e";
            this.e.Width = 200;
            // 
            // r
            // 
            this.r.HeaderText = "customersurname";
            this.r.MinimumWidth = 10;
            this.r.Name = "r";
            this.r.Width = 200;
            // 
            // SearchPrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultsgrid);
            this.Controls.Add(this.searcherrors);
            this.Controls.Add(this.enbut);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.labelsearch);
            this.Controls.Add(this.prenum);
            this.Controls.Add(this.surnamecheck);
            this.Name = "SearchPrescriptions";
            this.Size = new System.Drawing.Size(1504, 1064);
            this.Load += new System.EventHandler(this.SearchPrescriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox surnamecheck;
        private System.Windows.Forms.CheckBox prenum;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button enbut;
        private System.Windows.Forms.Label searcherrors;
        private System.Windows.Forms.DataGridView resultsgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn q;
        private System.Windows.Forms.DataGridViewTextBoxColumn w;
        private System.Windows.Forms.DataGridViewTextBoxColumn e;
        private System.Windows.Forms.DataGridViewTextBoxColumn r;
    }
}
