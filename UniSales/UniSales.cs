using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniSales.CategoryManagement;
using UniSales.Order;
using UniSales.Product;

namespace UniSales
{
    public partial class UniSales : Form
    {
        public UniSales()
        {
            InitializeComponent();
        }
        UCProductList uCProductList;
        UCCategoryList uCCategoryList;
        UCOrderList uCOrderList;
        private void createNewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uCOrderList == null) {
                uCOrderList = new UCOrderList();
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(uCOrderList);
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uCProductList == null) {
                uCProductList = new UCProductList();

            }
            panel1.Controls.Clear();
            panel1.Controls.Add(uCProductList);
        }

        private void categoryListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uCCategoryList == null) 
            {
                uCCategoryList = new UCCategoryList(); 
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(uCCategoryList);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
