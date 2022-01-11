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
    public partial class CreateNewUserForm : Form
    {
        public CreateNewUserForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                     
            if (MessageBox.Show("Do you went do Save this information?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var MRC = new MerchantriesEntities();
                    var UD = new UserDetail();

                    UD.S_Name = txtName.Text.Trim();
                    UD.S_Address = txtAddress.Text.Trim();
                    UD.S_NID = Convert.ToInt32(txtNID.Text.Trim());
                    UD.S_Phone = Convert.ToInt32(txtPhone.Text.Trim());
                    UD.S_DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Value);
                    UD.S_JoinDate = Convert.ToDateTime(dtpJoinDate.Value);
                    UD.S_Username = txtUsername.Text.Trim();
                    UD.S_Password = txtPassword.Text.Trim();

                    MRC.UserDetails.Add(UD);
                    MRC.SaveChanges();
                    MessageBox.Show(@"Create User Successfully.");
                    clearText();
                    FillGrid();
                }
                catch
                {
                    MessageBox.Show(@"User create cann't possibile.Try again.Thank you !");
                }
            }
        }

        private void CreateNewUserForm_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.Value = DateTime.Now;
            dtpJoinDate.Value = DateTime.Now;
            clearText();
            FillGrid();
            btnSave.Enabled = false;
            btnScarch.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void FillGrid()
        {
            var obj = new ManagerClass();
            var list = obj.GetAllUser();
            dgvUser.DataSource = list;
        }

        private void clearText()
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNID.Text = string.Empty;
            txtPhone.Text = string.Empty;
            dtpDateOfBirth.Value = DateTime.Now;
            dtpJoinDate.Value = DateTime.Now;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtScarch.Text = string.Empty;
            btnSave.Visible = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnScarch_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Visible = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                var MER = new MerchantriesEntities();
                var edit = MER.UserDetails.ToList().Where(x => x.S_Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();
                txtName.Text = edit.S_Name;
                txtAddress.Text = edit.S_Address;
                txtNID.Text = edit.S_NID.ToString();
                txtPhone.Text = edit.S_Phone.ToString();
                dtpDateOfBirth.Value = edit.S_DateOfBirth.Value;
                dtpJoinDate.Value = edit.S_JoinDate.Value;
                txtUsername.Text = edit.S_Username;
                txtPassword.Text = edit.S_Password;                
            }
            catch
            {
                MessageBox.Show(@"Scarch not found.try again !");
                clearText();
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" )
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you went do update this information?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var MER = new MerchantriesEntities();
                    var edit = MER.UserDetails.ToList().Where(x => x.S_Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();
                    edit.S_Name = txtName.Text.Trim();
                    edit.S_Address = txtAddress.Text.Trim();
                    edit.S_NID = Convert.ToInt32(txtNID.Text.Trim());
                    edit.S_Phone = Convert.ToInt32(txtPhone.Text.Trim());
                    edit.S_DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Value);
                    edit.S_JoinDate = Convert.ToDateTime(dtpJoinDate.Value);
                    edit.S_Username = txtUsername.Text.Trim();
                    edit.S_Password = txtPassword.Text.Trim();
                    MER.SaveChanges();
                    MessageBox.Show(@"Update Successfully.");
                    clearText();
                    FillGrid();
                }
                catch
                {
                    MessageBox.Show(@"Update not possibile.Please try again !");
                    clearText();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you went do delete this information?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {                    
                    var MER = new MerchantriesEntities();
                    var delete = MER.UserDetails.ToList().Where(x => x.S_Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();
                    MER.UserDetails.Remove(delete);
                    MER.SaveChanges();
                    MessageBox.Show(@"User Delete Successfully.");
                    clearText();
                    FillGrid();
                }
                catch
                {
                    MessageBox.Show(@"Product delete cann't possible.Please try again.Tank you !");
                }
            }
        }
    }
}
