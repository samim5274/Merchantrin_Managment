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
    public partial class MotherForm : Form
    {
        
        public MotherForm()
        {
            InitializeComponent();
        }

        private void manufactureDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new ManufactureForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void categoryDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new CatrgoryForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void productDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new ProductForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void salesOfProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new SalesForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void createNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new CreateNewUserForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you went do logout this Application?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void salesOfProduct2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new SalesForm2();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
