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

namespace UniSales.CategoryManagement
{
    public partial class UCCategoryList : UserControl
    {
        public UCCategoryList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UCCategoryList_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
        public void LoadDataToGridView()
        {
            CategoryRepository cr = new CategoryRepository();
            var categories = cr.GetCategories();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = categories;
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FormAddCategory fac = new FormAddCategory();
            fac.ParentUserControl = this;
            fac.ShowDialog();

        }

        private void btnDeleteCate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chui");
            }
            else 
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                if (MessageBox.Show(String.Format("Are you sure to Delete this {0} ?", id), "confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CategoryRepository cr = new CategoryRepository();
                    cr.Delete(id);
                    LoadDataToGridView();
                }
                
                

            }
        }

        private void btnUpdateCate_Click(object sender, EventArgs e)
        {
            
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            CategoryRepository cr = new CategoryRepository();
            var category = cr.Get(id);
            FormUpdateCategory fuc = new FormUpdateCategory(category);
            fuc.ParentUserControl = this;
            fuc.ShowDialog();
        }
    }
}
