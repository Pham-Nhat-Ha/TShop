using Repo.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PRN_TShop
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
            LoadData();
            ShowAll();
        }
        private void LoadData()
        {
            using (var db = new DrinkAllContext(Program.ConnectionString))
            {
                cbOrder.DataSource = db.Orders.Where(o => o.Status == 1).ToList();
                cbOrder.DisplayMember = "Id";
                cbOrder.ValueMember = "Id";
                dgvDetail.AutoGenerateColumns = false;
                dgvDetail.DataSource = db.OrderDetails.Where(d => d.OrderId == int.Parse(cbOrder.SelectedValue.ToString())).ToList();
            }
        }
        private void ShowAll()
        {
            int oID = int.Parse(cbOrder.SelectedValue.ToString());
            using (var db = new DrinkAllContext(Program.ConnectionString))
            {
                var order = db.Orders.Find(oID);
                txtName.Text = order.CustomerName;
                txtAddress.Text = order.Address;
                var sum = 0;
                for (int r = 0; r < dgvDetail.Rows.Count; r++)
                {
                    int price = int.Parse(dgvDetail.Rows[r].Cells[2].Value.ToString());
                    sum = sum + price;
                }
                if (sum > 0)
                {
                    txtTotal.Text = sum.ToString();
                }
                else
                {
                    txtTotal.Text = "0";
                }
            }
        }
        private void btBuy_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtTotal.Text) > 0)
            {
                using (var db = new DrinkAllContext(Program.ConnectionString))
                {
                    var order = db.Orders.Where(o => o.Id == int.Parse(cbOrder.SelectedValue.ToString())).FirstOrDefault();
                    order.Price = int.Parse(txtTotal.Text);
                    order.Status = 2;
                    db.Update(order);
                    db.SaveChanges();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Bill is empty, please buy some more!");
            }
        }

        private void btView_Click(object sender, EventArgs e)
        {
            using (var db = new DrinkAllContext(Program.ConnectionString))
            {
                dgvDetail.AutoGenerateColumns = false;
                dgvDetail.DataSource = db.OrderDetails.Where(d => d.OrderId == int.Parse(cbOrder.SelectedValue.ToString())).ToList();
            }
            ShowAll();
        }
    }
}
