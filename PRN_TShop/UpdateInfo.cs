using Repo.Models;
using System.Linq;
using System.Windows.Forms;

namespace PRN_TShop
{
    public partial class UpdateInfo : Form
    {
        private static int prodId;
        public UpdateInfo(int prodID)
        {
            InitializeComponent();
            LoadData();
            Show(prodID);
            prodId = prodID;
        }
        private void Show(int prodID)
        {
            using (var db = new DrinkAllContext(Program.ConnectionString))
            {
                var prod = db.Products.Where(p => p.Id == prodID).FirstOrDefault();
                txtProd.Text = prod.Name;
                txtPrice.Value = (int)prod.Price;
                cbCat.SelectedValue = prod.CategoryId;
            }
        }
        private void btUpdate_Click(object sender, System.EventArgs e)
        {
            using (var db = new DrinkAllContext(Program.ConnectionString))
            {
                var upProd = db.Products.Find(prodId);
                if (upProd != null)
                {
                    upProd.Price = (int)txtPrice.Value;
                    upProd.CategoryId = int.Parse(cbCat.SelectedValue.ToString());
                    db.Update(upProd);
                    db.SaveChanges();
                    this.Close();
                }
            }
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
