using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniSales.Repository;
using UniSales.Repository.Entity;

namespace UniSales.CategoryManagement
{
    public partial class FormAddCategory : Form
    {
        public FormAddCategory()
        {
            InitializeComponent();
        }
        public UCCategoryList ParentUserControl { get; set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAddCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryRepository cr = new CategoryRepository();
            Category cate = new Category() { 
                Name = txtCateName.Text,
                Description = txtDescription.Text
            };
            cr.Create(cate);
            this.ParentUserControl.LoadDataToGridView();
            this.Close();
        }
    }
}
