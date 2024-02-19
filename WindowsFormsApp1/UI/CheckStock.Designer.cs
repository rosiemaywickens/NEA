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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.two = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.three = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbox2
            // 
            this.searchbox2.Location = new System.Drawing.Point(132, 187);
            this.searchbox2.Name = "searchbox2";
            this.searchbox2.Size = new System.Drawing.Size(642, 31);
            this.searchbox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "seach medications by name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.y,
            this.two,
            this.three,
            this.brand});
            this.dataGridView1.Location = new System.Drawing.Point(132, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // y
            // 
            this.y.HeaderText = "medicine";
            this.y.MinimumWidth = 10;
            this.y.Name = "y";
            this.y.Width = 200;
            // 
            // two
            // 
            this.two.HeaderText = "dose";
            this.two.MinimumWidth = 10;
            this.two.Name = "two";
            this.two.Width = 200;
            // 
            // three
            // 
            this.three.HeaderText = "location";
            this.three.MinimumWidth = 10;
            this.three.Name = "three";
            this.three.Width = 200;
            // 
            // brand
            // 
            this.brand.HeaderText = "brand";
            this.brand.MinimumWidth = 10;
            this.brand.Name = "brand";
            this.brand.Width = 200;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(811, 187);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 31);
            this.enter.TabIndex = 3;
            this.enter.Text = "enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // CheckStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.enter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbox2);
            this.Name = "CheckStock";
            this.Size = new System.Drawing.Size(2211, 1142);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn two;
        private System.Windows.Forms.DataGridViewTextBoxColumn three;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.Button enter;
    }
}
