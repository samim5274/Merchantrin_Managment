using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerchantriesProject
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void btnScarch_Click(object sender, EventArgs e)
        {
            try
            {
                var MER = new MerchantriesEntities();
                var edit = MER.ProductDetails.ToList().Where(x => x.Barcode == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();
                txtProductName.Text = edit.ProductName;
                txtPrice.Text = edit.SalesPrice.ToString();


                //allow only alfabet and number
                //string obj = txtPrice.Text;
                //Regex rgx = new Regex("[^a-zA-Z0-9]");
                //txtTest.Text = rgx.Replace(obj, "");
            }
            catch
            {
                MessageBox.Show(@"Input Erorr !!");
            }            
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'merchantriesDataSet2.SP_SALES_INFO_SHOW' table. You can move, or remove it, as needed.
            this.sP_SALES_INFO_SHOWTableAdapter.Fill(this.merchantriesDataSet2.SP_SALES_INFO_SHOW);
            ClearText();
            dtpSalesDate.Value = DateTime.Now;
            btnAdd.Enabled = false;
            btnScarch.Enabled = false;
            lblDate.Text = DateTime.Today.Day.ToString() + " / " + DateTime.Today.Month.ToString() + " / " + DateTime.Today.Year.ToString();
            FillProductDetail();
            FillSalesGrid();
            btnOrder.Enabled = false;      
        }

        private void FillSalesGrid()
        {
            var obj = new ManagerClass();
            var list = obj.GetAllSalesInfo();
            dgvseles.DataSource = list;
        }

        private void FillProductDetail()
        {
            var obj = new ManagerClass();
            var list = obj.GetProductDetail();
            dgvProduct.DataSource = list;
        }

        private void ClearText()
        {
            txtQuantity.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtScarch.Text = string.Empty;
            txtSelerName.Text = string.Empty;
            txtOrderInvoice.Text = string.Empty;                        
        }

        int n = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {            
            //int Total = Convert.ToInt32(txtTest.Text) * Convert.ToInt32(txtQuantity.Text);
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dgvOrder);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = txtProductName.Text;
            newRow.Cells[2].Value = txtPrice.Text;
            newRow.Cells[3].Value = txtQuantity.Text;
            newRow.Cells[4].Value = Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtQuantity.Text);
            dgvOrder.Rows.Add(newRow);
            n++;
            lblAmmount.Text = "0";
            for (int i = 0; i < dgvOrder.Rows.Count; i++)
            {
                lblAmmount.Text = 
                    Convert.ToString(double.Parse(lblAmmount.Text) + double.Parse(dgvOrder.Rows[i].Cells[4].Value.ToString()));
            }
            ClearText();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void txtScarch_TextChanged(object sender, EventArgs e)
        {
            if (txtScarch.Text == "")
            {
                btnScarch.Enabled = false;
            }
            else
            {
                btnScarch.Enabled = true;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var MER = new MerchantriesEntities();
                var SI = new SalesInfo();
                SI.Id = Convert.ToInt32(txtOrderInvoice.Text.Trim());
                SI.SelerName = txtSelerName.Text.Trim();
                SI.SelerDate = Convert.ToDateTime(dtpSalesDate.Value);
                SI.Ammount = Convert.ToInt32(lblAmmount.Text);
                MER.SalesInfoes.Add(SI);
                MER.SaveChanges();
                MessageBox.Show("Order Add Successfylly..!");
                ClearText();
                FillSalesGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lblSellerName_Click(object sender, EventArgs e)
        {
            var obj = new LoginForm();
            obj.Show();
            this.Hide();
        }

        private void txtOrderInvoice_TextChanged(object sender, EventArgs e)
        {
            if (txtOrderInvoice.Text == " ")
            {
                btnOrder.Enabled = false;
            }
            else
            {
                btnOrder.Enabled = true;
            }
        }
    }
}
