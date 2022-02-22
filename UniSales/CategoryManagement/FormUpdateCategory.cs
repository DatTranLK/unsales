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
    public partial class FormUpdateCategory : Form
    {
        public FormUpdateCategory(Category category)
        {
            InitializeComponent();
            this.updateCate = category;
            
        }
        private Category updateCate;
        public UCCategoryList ParentUserControl { get; set; }
        public FormUpdateCategory()
        {
            InitializeComponent();
        }

        private void FormUpdateCategory_Load(object sender, EventArgs e)
        {
            txtId.Text = updateCate.Id.ToString();
            txtCateName.Text = updateCate.Name;
            txtDescription.Text = updateCate.Description;
        }

        private void btnUpdateCate_Click(object sender, EventArgs e)
        {


            updateCate.Name = txtCateName.Text;
            updateCate.Description = txtDescription.Text;

            CategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.Update(updateCate);
            this.ParentUserControl.LoadDataToGridView();
            this.Close();
        }
    }
}
