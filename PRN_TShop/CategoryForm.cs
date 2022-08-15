using Repo.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PRN_TShop
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void Category_FormClosed(object sender, FormClosedEventArgs e)
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
                dgvCat.AutoGenerateColumns = false;
                dgvCat.DataSource = db.Categories.Where(c => c.Status == 1).ToList();
                dgvCatOff.AutoGenerateColumns = false;
                dgvCatOff.DataSource = db.Categories.Where(c => c.Status == 0).ToList();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this category?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (dgvCat.SelectedRows.Count > 0)
                {
                    int catID = int.Parse(dgvCat.SelectedRows[0].Cells[0].Value.ToString());
                    using (var db = new DrinkAllContext(Program.ConnectionString))
                    {
                        var delCat = db.Categories.Find(catID);
                        if (delCat.Status == 1)
                        {
                            delCat.Status = 0;
                            db.Categories.Update(delCat);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("This is deleted, you cannot delete again!");
                        }
                    }
                }
            }
            LoadData();
        }

        private void btRe_Click(object sender, EventArgs e)
        {
            if (dgvCat.SelectedRows.Count > 0)
            {
                int catID = int.Parse(dgvCatOff.SelectedRows[0].Cells[0].Value.ToString());
                using (var db = new DrinkAllContext(Program.ConnectionString))
                {
                    var reCat = db.Categories.Find(catID);
                    if (reCat.Status == 0)
                    {
                        reCat.Status = 1;
                        db.Categories.Update(reCat);
                        db.SaveChanges();
                        MessageBox.Show("Restock successful!");
                    }
                    else
                    {
                        MessageBox.Show("This is in shop already!");
                    }
                }
            }
            LoadData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            CategoryInfo addC = new CategoryInfo();
            addC.ShowDialog();
            LoadData();
        }
    }
}