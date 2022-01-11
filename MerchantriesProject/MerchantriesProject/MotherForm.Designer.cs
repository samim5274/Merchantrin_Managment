namespace MerchantriesProject
{
    partial class MotherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manufactureDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOfProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOfProduct2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.aboutProductToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.userToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1197, 36);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manufactureDetailToolStripMenuItem,
            this.categoryDetailToolStripMenuItem});
            this.generalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(91, 32);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // manufactureDetailToolStripMenuItem
            // 
            this.manufactureDetailToolStripMenuItem.Name = "manufactureDetailToolStripMenuItem";
            this.manufactureDetailToolStripMenuItem.Size = new System.Drawing.Size(256, 32);
            this.manufactureDetailToolStripMenuItem.Text = "Manufacture Detail";
            this.manufactureDetailToolStripMenuItem.Click += new System.EventHandler(this.manufactureDetailToolStripMenuItem_Click);
            // 
            // categoryDetailToolStripMenuItem
            // 
            this.categoryDetailToolStripMenuItem.Name = "categoryDetailToolStripMenuItem";
            this.categoryDetailToolStripMenuItem.Size = new System.Drawing.Size(256, 32);
            this.categoryDetailToolStripMenuItem.Text = "Category Detail";
            this.categoryDetailToolStripMenuItem.Click += new System.EventHandler(this.categoryDetailToolStripMenuItem_Click);
            // 
            // aboutProductToolStripMenuItem
            // 
            this.aboutProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productDetailToolStripMenuItem});
            this.aboutProductToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutProductToolStripMenuItem.Name = "aboutProductToolStripMenuItem";
            this.aboutProductToolStripMenuItem.Size = new System.Drawing.Size(153, 32);
            this.aboutProductToolStripMenuItem.Text = "About Product";
            // 
            // productDetailToolStripMenuItem
            // 
            this.productDetailToolStripMenuItem.Name = "productDetailToolStripMenuItem";
            this.productDetailToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.productDetailToolStripMenuItem.Text = "Product Detail";
            this.productDetailToolStripMenuItem.Click += new System.EventHandler(this.productDetailToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesOfProductToolStripMenuItem,
            this.salesOfProduct2ToolStripMenuItem});
            this.salesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(68, 32);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // salesOfProductToolStripMenuItem
            // 
            this.salesOfProductToolStripMenuItem.Name = "salesOfProductToolStripMenuItem";
            this.salesOfProductToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.salesOfProductToolStripMenuItem.Text = "Sales of Product";
            this.salesOfProductToolStripMenuItem.Click += new System.EventHandler(this.salesOfProductToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewUserToolStripMenuItem});
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(63, 32);
            this.userToolStripMenuItem.Text = "User";
            // 
            // createNewUserToolStripMenuItem
            // 
            this.createNewUserToolStripMenuItem.Name = "createNewUserToolStripMenuItem";
            this.createNewUserToolStripMenuItem.Size = new System.Drawing.Size(234, 32);
            this.createNewUserToolStripMenuItem.Text = "Create New User";
            this.createNewUserToolStripMenuItem.Click += new System.EventHandler(this.createNewUserToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(95, 32);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // salesOfProduct2ToolStripMenuItem
            // 
            this.salesOfProduct2ToolStripMenuItem.Name = "salesOfProduct2ToolStripMenuItem";
            this.salesOfProduct2ToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.salesOfProduct2ToolStripMenuItem.Text = "Sales of Product 2";
            this.salesOfProduct2ToolStripMenuItem.Click += new System.EventHandler(this.salesOfProduct2ToolStripMenuItem_Click);
            // 
            // MotherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1197, 633);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1215, 680);
            this.Name = "MotherForm";
            this.Text = "MotherForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manufactureDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesOfProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesOfProduct2ToolStripMenuItem;
    }
}



