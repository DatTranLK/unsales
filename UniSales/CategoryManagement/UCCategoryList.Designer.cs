
namespace UniSales.CategoryManagement
{
    partial class UCCategoryList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnDeleteCate = new System.Windows.Forms.Button();
            this.btnUpdateCate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(68, 37);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1373, 383);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Description";
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(641, 426);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(191, 46);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Add me ";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnDeleteCate
            // 
            this.btnDeleteCate.Location = new System.Drawing.Point(858, 426);
            this.btnDeleteCate.Name = "btnDeleteCate";
            this.btnDeleteCate.Size = new System.Drawing.Size(191, 46);
            this.btnDeleteCate.TabIndex = 2;
            this.btnDeleteCate.Text = "Delete me ";
            this.btnDeleteCate.UseVisualStyleBackColor = true;
            this.btnDeleteCate.Click += new System.EventHandler(this.btnDeleteCate_Click);
            // 
            // btnUpdateCate
            // 
            this.btnUpdateCate.Location = new System.Drawing.Point(1097, 426);
            this.btnUpdateCate.Name = "btnUpdateCate";
            this.btnUpdateCate.Size = new System.Drawing.Size(191, 46);
            this.btnUpdateCate.TabIndex = 3;
            this.btnUpdateCate.Text = "Update me ";
            this.btnUpdateCate.UseVisualStyleBackColor = true;
            this.btnUpdateCate.Click += new System.EventHandler(this.btnUpdateCate_Click);
            // 
            // UCCategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdateCate);
            this.Controls.Add(this.btnDeleteCate);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCCategoryList";
            this.Size = new System.Drawing.Size(1574, 567);
            this.Load += new System.EventHandler(this.UCCategoryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnDeleteCate;
        private System.Windows.Forms.Button btnUpdateCate;
    }
}
