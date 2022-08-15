using Repo.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PRN_TShop
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            LoadData();
            cbCat.SelectedItem = null;
            cbCat.Text = "--select--";
        }

        private void Product_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
        private void LoadData()
        {
            using (var db = new DrinkAllContext(Program.ConnectionString))
            {
                dgvProduct.AutoGenerateColumns = false;
                dgvProduct.DataSource = db.Products.Where(p => p.Status == 1).ToList();
                dgvProdOff.AutoGenerateColumns = false;
                dgvProdOff.DataSource = db.Products.Where(p => p.Status == 0).ToList();
                cbCat.DataSource = db.Categories.Where(c => c.Status == 1).ToList();
                cbCat.DisplayMember = "Name";
                cbCat.ValueMember = "Id";
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this product?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (dgvProduct.SelectedRows.Count > 0)
                {
                    int prodID = int.Parse(dgvProduct.SelectedRows[0].Cells[0].Value.ToString());
                    using (var db = new DrinkAllContext(Program.ConnectionString))
                    {
                        var delProd = db.Products.Find(prodID);
                        if (delProd.Status == 1)
                        {
                            delProd.Status = 0;
                            db.Products.Update(delProd);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("This product is deleted, you cannot delete again!");
                        }
                    }
                }
            }
            cbCat.SelectedItem = null;
            cbCat.Text = "--select--";
            LoadData();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            UpdateInfo upP = new UpdateInfo(int.Parse(dgvProduct.SelectedRows[0].Cells[0].Value.ToString()));
            upP.ShowDialog();
            cbCat.SelectedItem = null;
            cbCat.Text = "--select--";
            LoadData();
        }

        private void btRe_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                int prodID = int.Parse(dgvProdOff.SelectedRows[0].Cells[0].Value.ToString());
                using (var db = new DrinkAllContext(Program.ConnectionString))
                {
                    var reProd = db.Products.Find(prodID);
                    if (reProd.Status == 0)
                    {
                        reProd.Status = 1;
                        db.Products.Update(reProd);
                        db.SaveChanges();
                        MessageBox.Show("Restock successful!");
                    }
                    else
                    {
                        MessageBox.Show("This product is in shop already!");
                    }
                }
            }
            cbCat.SelectedItem = null;
            cbCat.Text = "--select--";
            LoadData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            ProductInfo addP = new ProductInfo();
            addP.ShowDialog();
            cbCat.SelectedItem = null;
            cbCat.Text = "--select--";
            LoadData();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            using (var db = new DrinkAllContext(Program.ConnectionString))
            {
                dgvProduct.AutoGenerateColumns = false;
                dgvProduct.DataSource = db.Products.Where(p => p.CategoryId == int.Parse(cbCat.SelectedValue.ToString()) && p.Status == 1).ToList();
                dgvProdOff.AutoGenerateColumns = false;
                dgvProdOff.DataSource = db.Products.Where(p => p.CategoryId == int.Parse(cbCat.SelectedValue.ToString()) && p.Status == 0).ToList();
            }
        }

        private void btBuy_Click(object sender, EventArgs e)
        {
            Buy bP = new Buy(int.Parse(dgvProduct.SelectedRows[0].Cells[0].Value.ToString()));
            bP.ShowDialog();
            cbCat.SelectedItem = null;
            cbCat.Text = "--select--";
            LoadData();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            CreateOrder order = new CreateOrder();
            order.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.ShowDialog();
        }
    }
}
