namespace WindowsFormsApp1.UI
{
    partial class CheckStock
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
            this.searchbox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStocks = new System.Windows.Forms.DataGridView();
            this.enter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbox2
            // 
            this.searchbox2.Location = new System.Drawing.Point(66, 97);
            this.searchbox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchbox2.Name = "searchbox2";
            this.searchbox2.Size = new System.Drawing.Size(323, 20);
            this.searchbox2.TabIndex = 0;
            this.searchbox2.TextChanged += new System.EventHandler(this.searchbox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "seach medications by name";
            // 
            // dataGridViewStocks
            // 
            this.dataGridViewStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStocks.Location = new System.Drawing.Point(66, 127);
            this.dataGridViewStocks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewStocks.Name = "dataGridViewStocks";
            this.dataGridViewStocks.RowHeadersWidth = 82;
            this.dataGridViewStocks.RowTemplate.Height = 33;
            this.dataGridViewStocks.Size = new System.Drawing.Size(884, 300);
            this.dataGridViewStocks.TabIndex = 2;
            this.dataGridViewStocks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(402, 93);
            this.enter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(67, 26);
            this.enter.TabIndex = 3;
            this.enter.Text = "enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // CheckStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.enter);
            this.Controls.Add(this.dataGridViewStocks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckStock";
            this.Size = new System.Drawing.Size(1012, 594);
            this.Load += new System.EventHandler(this.CheckStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewStocks;
        private System.Windows.Forms.Button enter;
    }
}
