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
    public partial class SalesForm2 : Form
    {
        public SalesForm2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you went do Exit this Application?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SalesForm2_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.Day.ToString() + " / " + DateTime.Today.Month.ToString() + " / " + DateTime.Today.Year.ToString();
            dtpSalesofProduct.Value = DateTime.Now;
            FillProduct();
            ClearText();
        }

        private void ClearText()
        {
            cbxProduct.Text = string.Empty;
        }

        private void FillProduct()
        {
            var obj = new ManagerClass();
            var list = obj.GetAllProduct();
            cbxProduct.DisplayMember = "ProductName";
            cbxProduct.ValueMember = "Id";
            cbxProduct.DataSource = list;
        }
    }
}
