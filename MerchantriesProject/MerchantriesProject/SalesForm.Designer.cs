namespace MerchantriesProject
{
    partial class SalesForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScarch = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnScarch = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.PId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvseles = new System.Windows.Forms.DataGridView();
            this.lblAmmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.txtOrderInvoice = new System.Windows.Forms.TextBox();
            this.lblsaler = new System.Windows.Forms.Label();
            this.txtSelerName = new System.Windows.Forms.TextBox();
            this.dtpSalesDate = new System.Windows.Forms.DateTimePicker();
            this.merchantriesDataSet2 = new MerchantriesProject.MerchantriesDataSet2();
            this.sPSALESINFOSHOWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_SALES_INFO_SHOWTableAdapter = new MerchantriesProject.MerchantriesDataSet2TableAdapters.SP_SALES_INFO_SHOWTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selerDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ammountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvseles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantriesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSALESINFOSHOWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(387, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Information";
            // 
            // txtScarch
            // 
            this.txtScarch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtScarch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScarch.Location = new System.Drawing.Point(170, 96);
            this.txtScarch.Name = "txtScarch";
            this.txtScarch.Size = new System.Drawing.Size(240, 30);
            this.txtScarch.TabIndex = 1;
            this.txtScarch.TextChanged += new System.EventHandler(this.txtScarch_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProductName.Enabled = false;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(170, 176);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(240, 30);
            this.txtProductName.TabIndex = 2;
            // 
            // btnScarch
            // 
            this.btnScarch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnScarch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScarch.Location = new System.Drawing.Point(170, 132);
            this.btnScarch.Name = "btnScarch";
            this.btnScarch.Size = new System.Drawing.Size(240, 37);
            this.btnScarch.TabIndex = 3;
            this.btnScarch.Text = "Scarch";
            this.btnScarch.UseVisualStyleBackColor = true;
            this.btnScarch.Click += new System.EventHandler(this.btnScarch_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(170, 253);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(240, 30);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(170, 215);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(240, 30);
            this.txtPrice.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(170, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 37);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity";
            // 
            // dgvProduct
            // 
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(41, 356);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(369, 323);
            this.dgvProduct.TabIndex = 10;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PId,
            this.PName,
            this.PPrice,
            this.PQuantity,
            this.PTotal});
            this.dgvOrder.Location = new System.Drawing.Point(447, 96);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(708, 231);
            this.dgvOrder.TabIndex = 11;
            // 
            // PId
            // 
            this.PId.HeaderText = "Id";
            this.PId.Name = "PId";
            // 
            // PName
            // 
            this.PName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PName.HeaderText = "Name";
            this.PName.Name = "PName";
            // 
            // PPrice
            // 
            this.PPrice.HeaderText = "Price";
            this.PPrice.Name = "PPrice";
            // 
            // PQuantity
            // 
            this.PQuantity.HeaderText = "Quantity";
            this.PQuantity.Name = "PQuantity";
            // 
            // PTotal
            // 
            this.PTotal.HeaderText = "Total";
            this.PTotal.Name = "PTotal";
            // 
            // dgvseles
            // 
            this.dgvseles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvseles.AutoGenerateColumns = false;
            this.dgvseles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvseles.ColumnHeadersVisible = false;
            this.dgvseles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.selerNameDataGridViewTextBoxColumn,
            this.selerDateDataGridViewTextBoxColumn,
            this.ammountDataGridViewTextBoxColumn});
            this.dgvseles.DataSource = this.sPSALESINFOSHOWBindingSource;
            this.dgvseles.Location = new System.Drawing.Point(447, 432);
            this.dgvseles.Name = "dgvseles";
            this.dgvseles.RowTemplate.Height = 24;
            this.dgvseles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvseles.Size = new System.Drawing.Size(708, 247);
            this.dgvseles.TabIndex = 12;
            // 
            // lblAmmount
            // 
            this.lblAmmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAmmount.AutoSize = true;
            this.lblAmmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmount.ForeColor = System.Drawing.Color.White;
            this.lblAmmount.Location = new System.Drawing.Point(1047, 343);
            this.lblAmmount.Name = "lblAmmount";
            this.lblAmmount.Size = new System.Drawing.Size(34, 25);
            this.lblAmmount.TabIndex = 13;
            this.lblAmmount.Text = "00";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(1015, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(23, 25);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(776, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sales Info";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(983, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "৳";
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(640, 392);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(119, 34);
            this.btnOrder.TabIndex = 17;
            this.btnOrder.Text = "Save";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblSellerName
            // 
            this.lblSellerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSellerName.AutoSize = true;
            this.lblSellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerName.ForeColor = System.Drawing.Color.White;
            this.lblSellerName.Location = new System.Drawing.Point(24, 30);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(82, 25);
            this.lblSellerName.TabIndex = 18;
            this.lblSellerName.Text = "Log Out";
            this.lblSellerName.Click += new System.EventHandler(this.lblSellerName_Click);
            // 
            // txtOrderInvoice
            // 
            this.txtOrderInvoice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOrderInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderInvoice.Location = new System.Drawing.Point(447, 393);
            this.txtOrderInvoice.Name = "txtOrderInvoice";
            this.txtOrderInvoice.Size = new System.Drawing.Size(187, 30);
            this.txtOrderInvoice.TabIndex = 19;
            this.txtOrderInvoice.TextChanged += new System.EventHandler(this.txtOrderInvoice_TextChanged);
            // 
            // lblsaler
            // 
            this.lblsaler.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblsaler.AutoSize = true;
            this.lblsaler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaler.ForeColor = System.Drawing.Color.White;
            this.lblsaler.Location = new System.Drawing.Point(644, 357);
            this.lblsaler.Name = "lblsaler";
            this.lblsaler.Size = new System.Drawing.Size(115, 25);
            this.lblsaler.TabIndex = 23;
            this.lblsaler.Text = "Seler Name";
            // 
            // txtSelerName
            // 
            this.txtSelerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSelerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelerName.Location = new System.Drawing.Point(447, 354);
            this.txtSelerName.Name = "txtSelerName";
            this.txtSelerName.Size = new System.Drawing.Size(187, 30);
            this.txtSelerName.TabIndex = 22;
            // 
            // dtpSalesDate
            // 
            this.dtpSalesDate.Location = new System.Drawing.Point(0, -1);
            this.dtpSalesDate.Name = "dtpSalesDate";
            this.dtpSalesDate.Size = new System.Drawing.Size(32, 22);
            this.dtpSalesDate.TabIndex = 24;
            this.dtpSalesDate.Visible = false;
            // 
            // merchantriesDataSet2
            // 
            this.merchantriesDataSet2.DataSetName = "MerchantriesDataSet2";
            this.merchantriesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPSALESINFOSHOWBindingSource
            // 
            this.sPSALESINFOSHOWBindingSource.DataMember = "SP_SALES_INFO_SHOW";
            this.sPSALESINFOSHOWBindingSource.DataSource = this.merchantriesDataSet2;
            // 
            // sP_SALES_INFO_SHOWTableAdapter
            // 
            this.sP_SALES_INFO_SHOWTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // selerNameDataGridViewTextBoxColumn
            // 
            this.selerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.selerNameDataGridViewTextBoxColumn.DataPropertyName = "SelerName";
            this.selerNameDataGridViewTextBoxColumn.HeaderText = "SelerName";
            this.selerNameDataGridViewTextBoxColumn.Name = "selerNameDataGridViewTextBoxColumn";
            // 
            // selerDateDataGridViewTextBoxColumn
            // 
            this.selerDateDataGridViewTextBoxColumn.DataPropertyName = "SelerDate";
            this.selerDateDataGridViewTextBoxColumn.HeaderText = "SelerDate";
            this.selerDateDataGridViewTextBoxColumn.Name = "selerDateDataGridViewTextBoxColumn";
            // 
            // ammountDataGridViewTextBoxColumn
            // 
            this.ammountDataGridViewTextBoxColumn.DataPropertyName = "Ammount";
            this.ammountDataGridViewTextBoxColumn.HeaderText = "Ammount";
            this.ammountDataGridViewTextBoxColumn.Name = "ammountDataGridViewTextBoxColumn";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1191, 712);
            this.Controls.Add(this.dtpSalesDate);
            this.Controls.Add(this.lblsaler);
            this.Controls.Add(this.txtSelerName);
            this.Controls.Add(this.txtOrderInvoice);
            this.Controls.Add(this.lblSellerName);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAmmount);
            this.Controls.Add(this.dgvseles);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnScarch);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtScarch);
            this.Controls.Add(this.label1);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvseles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantriesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSALESINFOSHOWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScarch;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnScarch;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridView dgvseles;
        private System.Windows.Forms.Label lblAmmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn PId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTotal;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.TextBox txtOrderInvoice;
        private System.Windows.Forms.Label lblsaler;
        private System.Windows.Forms.TextBox txtSelerName;
        private System.Windows.Forms.DateTimePicker dtpSalesDate;
        private MerchantriesDataSet2 merchantriesDataSet2;
        private System.Windows.Forms.BindingSource sPSALESINFOSHOWBindingSource;
        private MerchantriesDataSet2TableAdapters.SP_SALES_INFO_SHOWTableAdapter sP_SALES_INFO_SHOWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selerDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ammountDataGridViewTextBoxColumn;
    }
}