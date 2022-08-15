using Repo.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PRN_TShop
{
    public partial class ProductInfo : Form
    {
        public ProductInfo()
        {
            InitializeComponent();
            LoadData();
        }

        private void btAdd_Click(object sender, System.EventArgs e)
        {
            if (IsValid())
            {
                if (IsDuplicate(txtName.Text))
                {
                    MessageBox.Show("Duplicated name!");
                }
                else
                {
                    using (var db = new DrinkAllContext(Program.ConnectionString))
                    {
                        var prod = new Product()
                        {
                            Name = txtName.Text,
                            Price = (int)txtPrice.Value,
                            CreatedDate = DateTime.Now.Date,
                            Status = 1,
                            CategoryId = int.Parse(cbCat.SelectedValue.ToString())
                        };
                        db.Products.Add(prod);
                        db.SaveChanges();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Your input is not valid!");
            }
        }
        private bool IsDuplicate(string name)
        {
            using (var db = new DrinkAllContext(Program.ConnectionString))
            {
                var prod = db.Products.Where(p => p.Name.Equals(name)).FirstOrDefault();
                if (prod == null)
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsValid()
        {
            if (txtName.Text == "" || txtName.Text.Length < 5) return false;
            var words = txtName.Text.Split();
            foreach (var w in words)
            {
                if (!char.IsUpper(w[0]))
                {
                    return false;
                }
                int i = 1;
                while (i < w.Length)
                {
                    if (char.IsUpper(w[i]))
                    {
                        return false;
                    }
                    i++;
                }
            }
            return true;
        }
        private void LoadData()
        {
            using (var db = new DrinkAllContext(Program.ConnectionString))
            {
                cbCat.DataSource = db.Categories.ToList();
                cbCat.DisplayMember = "Name";
                cbCat.ValueMember = "Id";
            }
        }
    }
}
