using Repo.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PRN_TShop
{
    public partial class Buy : Form
    {
        private int proID;
        public Buy(int prodID)
        {
            InitializeComponent();
            proID = prodID;
            LoadData();
            GetName(prodID);
        }
        private void LoadData()
        {
            using (var db = new DrinkAllContext(Program.ConnectionString))
            {
                cbOrder.DataSource = db.Orders.Where(o => o.Status == 1).ToList();
                cbOrder.DisplayMember = "Id";
                cbOrder.ValueMember = "Id";
            }
        }
        private void GetName(int prodID)
        {
            using (var db = new DrinkAllContext(Program.ConnectionString))
            {
                var prod = db.Products.Where(p => p.Id == prodID).FirstOrDefault();
                txtProd.Text = prod.Name;
            }
        }

        private void btBuy_Click(object sender, EventArgs e)
        {
            using (var db = new DrinkAllContext(Program.ConnectionString))
            {
                var prod = db.Products.Where(p => p.Id == proID).FirstOrDefault();
                var od = new OrderDetail()
                {
                    ProductId = proID,
                    OrderId = int.Parse(cbOrder.SelectedValue.ToString()),
                    Quantity = (int)txtQuan.Value,
                    Price = prod.Price * (int)txtQuan.Value,
                    Status = 1
                };
                db.OrderDetails.Add(od);
                db.SaveChanges();
                this.Close();
            }
        }
    }
}
