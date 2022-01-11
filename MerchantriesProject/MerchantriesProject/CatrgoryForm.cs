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
    public partial class CatrgoryForm : Form
    {
        public CatrgoryForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var MER = new MerchantriesEntities();
            var CAT = new CategoryDetail();
            CAT.CategoryName = txtCategory.Text.Trim();
            MER.CategoryDetails.Add(CAT);
            MER.SaveChanges();
            MessageBox.Show(@"Category Saved Successfully.");
            FillCategoryGrid();
        }

        private void CatrgoryForm_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            FillCategoryGrid();
        }

        private void FillCategoryGrid()
        {
            var obj = new ManagerClass();
            var list = obj.GettCategory();
            dgvCategory.DataSource = list;
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            if (txtCategory.Text == "")
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
            txtCategory.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvCategory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnSave.Visible = false;
            txtCategory.Text = dgvCategory.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnScarch_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            var MER = new MerchantriesEntities();
            var edit = MER.CategoryDetails.ToList().Where(x => x.Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();
            txtCategory.Text = edit.CategoryName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you went do update this information?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var MER = new MerchantriesEntities();
                var update = MER.CategoryDetails.ToList().Where(x => x.Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();
                update.CategoryName = txtCategory.Text.Trim();
                MER.SaveChanges();
                txtCategory.Text = string.Empty;
                txtScarch.Text = string.Empty;
                FillCategoryGrid();
            }                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you went do delete this information?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var MER = new MerchantriesEntities();
                var delete = MER.CategoryDetails.ToList().Where(x => x.Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();
                MER.CategoryDetails.Remove(delete);
                MER.SaveChanges();
                FillCategoryGrid();
            }
                
        }
    }
}
