using Repo.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PRN_TShop
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var db = new DrinkAllContext(Program.ConnectionString))
            {
                dgvNot.AutoGenerateColumns = false;
                dgvNot.DataSource = db.Orders.Where(p => p.Status == 1).ToList();
                dgvDone.AutoGenerateColumns = false;
                dgvDone.DataSource = db.Orders.Where(p => p.Status == 2).ToList();
                dgvDel.AutoGenerateColumns = false;
                dgvDel.DataSource = db.Orders.Where(p => p.Status == 0).ToList();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            CreateOrder order = new CreateOrder();
            order.ShowDialog();
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this order?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (dgvNot.SelectedRows.Count > 0)
                {
                    int oID = int.Parse(dgvNot.SelectedRows[0].Cells[0].Value.ToString());
                    using (var db = new DrinkAllContext(Program.ConnectionString))
                    {
                        var delO = db.Orders.Find(oID);
                        delO.Status = 0;
                        db.Orders.Update(delO);
                        db.SaveChanges();
                    }
                }
            }
            LoadData();
        }

        private void btRe_Click(object sender, EventArgs e)
        {
            if (dgvDel.SelectedRows.Count > 0)
            {
                int oID = int.Parse(dgvDel.SelectedRows[0].Cells[0].Value.ToString());
                using (var db = new DrinkAllContext(Program.ConnectionString))
                {
                    var reO = db.Orders.Find(oID);
                    reO.Status = 1;
                    db.Orders.Update(reO);
                    db.SaveChanges();
                    MessageBox.Show("Restock successful!");
                }
            }
            LoadData();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
