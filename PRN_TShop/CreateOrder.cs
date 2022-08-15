using Repo.Models;
using System;
using System.Windows.Forms;

namespace PRN_TShop
{
    public partial class CreateOrder : Form
    {
        public CreateOrder()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using (var db = new DrinkAllContext(Program.ConnectionString))
                {
                    var order = new Order()
                    {
                        CustomerName = txtName.Text,
                        Address = txtAddress.Text,
                        OrderDate = DateTime.Now.Date,
                        Status = 1
                    };
                    db.Orders.Add(order);
                    db.SaveChanges();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Your input is not valid!");
            }
        }
        private bool IsValid()
        {
            if (txtName.Text == "" || txtName.Text.Length < 2) return false;
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
            if (txtAddress.Text == "" || txtAddress.Text.Length < 2) return false;
            return true;
        }
    }
}
