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
    public partial class ManufactureForm : Form
    {
        public ManufactureForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var MER = new MerchantriesEntities();
            var Men = new ManufactureDetail();
            Men.ManufactureName = txtMenufacture.Text.Trim();
            MER.ManufactureDetails.Add(Men);
            MER.SaveChanges();
            MessageBox.Show(@"Menufacture Saved Successfully.");
            FillMenufactureGrid();
        }

        private void txtMenufacture_TextChanged(object sender, EventArgs e)
        {
            if (txtMenufacture.Text == "")
            {
                btnSave.Enabled = false;
                btnSave.Visible = true;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMenufacture.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManufactureForm_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            FillMenufactureGrid();
        }

        private void FillMenufactureGrid()
        {
            var obj = new ManagerClass();
            var list = obj.GetManufacture();
            dgvManufacture.DataSource = list;
        }

        private void dgvManufacture_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnSave.Visible = false;
            txtMenufacture.Text = dgvManufacture.SelectedRows[0].Cells[1].Value.ToString();
        }


        private void btnScarch_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            var MER = new MerchantriesEntities();
            var edit = MER.ManufactureDetails.ToList().Where(x => x.Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();
            txtMenufacture.Text = edit.ManufactureName;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you went do update this information?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var MER = new MerchantriesEntities();
                var update = MER.ManufactureDetails.ToList().Where(x => x.Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();
                update.ManufactureName = txtMenufacture.Text.Trim();
                MER.SaveChanges();
                txtMenufacture.Text = string.Empty;
                txtScarch.Text = string.Empty;
                FillMenufactureGrid();
            }
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you went do delete this information?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var MER = new MerchantriesEntities();
                var delete = MER.ManufactureDetails.ToList().Where(x => x.Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();
                MER.ManufactureDetails.Remove(delete);
                MER.SaveChanges();
                FillMenufactureGrid();
            }
                
        }

        private void txtScarch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
