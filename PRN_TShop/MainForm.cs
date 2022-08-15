using System;
using System.Windows.Forms;

namespace PRN_TShop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void allMenu_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void editCat_Click_1(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void allOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm();
            order.Show();
            this.Hide();
        }
    }
}
