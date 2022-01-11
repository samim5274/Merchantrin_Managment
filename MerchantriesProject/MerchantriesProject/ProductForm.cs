using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerchantriesProject
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            FillManufacture();
            FillCategory();
            FillGrid();
            ClearTextbox();
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnScarch.Enabled = false;
            btnSave.Visible = true;
        }

        private void FillGrid()
        {
            var obj = new ManagerClass();
            var list = obj.GetProductDetail();
            dgvProduct.DataSource = list;
        }

        private void ClearTextbox()
        {
            txtBarCode.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtPurchasePrice.Text = string.Empty;
            txtSalesPrice.Text = string.Empty;
            cbxCategroy.Text = string.Empty;
            cbxmanufacture.Text = string.Empty;
            txtScarch.Text = string.Empty;
            txtScarch.Enabled = true;
        }

        private void FillManufacture()
        {
            var obj = new ManagerClass();
            var list = obj.GetManufacture();
            cbxmanufacture.DisplayMember = "ManufactureName";
            cbxmanufacture.ValueMember = "Id";
            cbxmanufacture.DataSource = list;
        }

        private void FillCategory()
        {
            var obj = new ManagerClass();
            var list = obj.GettCategory();
            cbxCategroy.DisplayMember = "CategoryName";
            cbxCategroy.ValueMember = "Id";
            cbxCategroy.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var MER = new MerchantriesEntities();
                var PRO = new ProductDetail();

                PRO.Barcode = Convert.ToInt32(txtBarCode.Text.Trim());
                PRO.ProductName = txtProductName.Text.Trim();
                PRO.ManufactureId = Convert.ToInt32(cbxmanufacture.SelectedValue);
                PRO.CategoryId = Convert.ToInt32(cbxCategroy.SelectedValue);
                PRO.PurchasePrice = Convert.ToInt32(txtPurchasePrice.Text.Trim());
                PRO.SalesPrice = Convert.ToInt32(txtSalesPrice.Text.Trim());
                MER.ProductDetails.Add(PRO);
                MER.SaveChanges();
                MessageBox.Show(@"Product Saved Successfully.");
                ClearTextbox();
                FillGrid();
            }
            catch
            {
                MessageBox.Show(@"Cann't save product.Please try again.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextbox();
            btnScarch.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Visible = true;
        }

        private void txtBarCode_TextChanged(object sender, EventArgs e)
        {
            if (txtBarCode.Text == "")
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true; 
            }
        }

        private void txtScarch_TextChanged(object sender, EventArgs e)
        {
            if (txtScarch.Text == "")
            {
                btnScarch.Enabled = false;
                btnSave.Enabled = false;
                btnSave.Visible = true;
            }
            else
            {
                btnScarch.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void btnScarch_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Visible = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                var MER = new MerchantriesEntities();
                var edit = MER.ProductDetails.ToList().Where(x => x.Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();
                txtBarCode.Text = edit.Barcode.ToString();
                txtProductName.Text = edit.ProductName;
                cbxmanufacture.SelectedValue = edit.ManufactureId;
                cbxCategroy.SelectedValue = edit.CategoryId;
                txtPurchasePrice.Text = edit.PurchasePrice.ToString();
                txtSalesPrice.Text = edit.SalesPrice.ToString();
            }
            catch
            {
                MessageBox.Show(@"Result not found.Please try again.Tank you !");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you went do update this information?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    btnSave.Visible = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    txtScarch.Enabled = false;

                    var MER = new MerchantriesEntities();
                    var edit = MER.ProductDetails.ToList().Where(x => x.Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();
                    edit.Barcode = Convert.ToInt32(txtBarCode.Text.Trim());
                    edit.ProductName = txtProductName.Text.Trim();
                    edit.ManufactureId = Convert.ToInt32(cbxmanufacture.SelectedValue);
                    edit.CategoryId = Convert.ToInt32(cbxCategroy.SelectedValue);
                    edit.PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text.Trim());
                    edit.SalesPrice = Convert.ToDecimal(txtSalesPrice.Text.Trim());
                    MER.SaveChanges();
                    MessageBox.Show(@"Product Edit Successfully.");
                    ClearTextbox();
                    FillGrid();
                }
                catch
                {
                    MessageBox.Show(@"Product update cann't possible.Please try again.Tank you !");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you went do delete this information?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    btnSave.Visible = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    txtScarch.Enabled = false;

                    var MER = new MerchantriesEntities();
                    var delete = MER.ProductDetails.ToList().Where(x => x.Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();
                    MER.ProductDetails.Remove(delete);
                    MER.SaveChanges();
                    MessageBox.Show(@"Product Edit Successfully.");
                    ClearTextbox();
                    FillGrid();
                }
                catch
                {
                    MessageBox.Show(@"Product delete cann't possible.Please try again.Tank you !");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var obj = new ManufactureForm();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FillManufacture();
            ClearTextbox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var obj = new CatrgoryForm();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FillCategory();
            ClearTextbox();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var obj = new ManufactureForm();
            obj.Show();
        }
    }
}
