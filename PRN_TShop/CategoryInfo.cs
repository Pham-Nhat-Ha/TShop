using Repo.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PRN_TShop
{
    public partial class CategoryInfo : Form
    {
        public CategoryInfo()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (IsDuplicate(txtName.Text))
                {
                    MessageBox.Show("Product!");
                }
                else
                {
                    using (var db = new DrinkAllContext(Program.ConnectionString))
                    {
                        var cat = new Category()
                        {
                            Name = txtName.Text,
                            Status = 1
                        };
                        db.Categories.Add(cat);
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
                var cat = db.Categories.Where(c => c.Name.Equals(name)).FirstOrDefault();
                if (cat == null)
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsValid()
        {
            if (txtName.Text == "") return false;
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
    }
}
