namespace BindingDataGridView
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle cellStylePrice = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyleTax = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyleDiscount = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyleTotal = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCurrent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnQuantity,
            this.columnPrice,
            this.columnTax,
            this.columnDiscount,
            this.columnTotal});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // columnName
            // 
            this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnName.DataPropertyName = "Name";
            this.columnName.HeaderText = "Nombre";
            this.columnName.Name = "columnName";
            // 
            // columnQuantity
            // 
            this.columnQuantity.DataPropertyName = "Quantity";
            this.columnQuantity.HeaderText = "Cantidad";
            this.columnQuantity.Name = "columnQuantity";
            this.columnQuantity.Width = 80;
            // 
            // columnPrice
            // 
            this.columnPrice.DataPropertyName = "Price";
            cellStylePrice.Format = "C";
            this.columnPrice.DefaultCellStyle = cellStylePrice;
            this.columnPrice.HeaderText = "Precio";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.Width = 80;
            // 
            // columnTax
            // 
            this.columnTax.DataPropertyName = "Tax";
            cellStyleTax.Format = "N2";
            cellStyleTax.NullValue = "00.00";
            this.columnTax.DefaultCellStyle = cellStyleTax;
            this.columnTax.HeaderText = "IVA";
            this.columnTax.Name = "columnTax";
            this.columnTax.Width = 80;
            // 
            // columnDiscount
            // 
            this.columnDiscount.DataPropertyName = "Discount";
            cellStyleDiscount.Format = "N2";
            this.columnDiscount.DefaultCellStyle = cellStyleDiscount;
            this.columnDiscount.HeaderText = "Descuento";
            this.columnDiscount.Name = "columnDiscount";
            this.columnDiscount.Width = 80;
            // 
            // columnTotal
            // 
            this.columnTotal.DataPropertyName = "Total";
            cellStyleTotal.Format = "C";
            this.columnTotal.DefaultCellStyle = cellStyleTotal;
            this.columnTotal.HeaderText = "Total";
            this.columnTotal.Name = "columnTotal";
            this.columnTotal.Width = 80;
            // 
            // buttonCurrent
            // 
            this.buttonCurrent.Location = new System.Drawing.Point(12, 12);
            this.buttonCurrent.Name = "buttonCurrent";
            this.buttonCurrent.Size = new System.Drawing.Size(119, 23);
            this.buttonCurrent.TabIndex = 1;
            this.buttonCurrent.Text = "Producto actual";
            this.buttonCurrent.UseVisualStyleBackColor = true;
            this.buttonCurrent.Click += new System.EventHandler(this.buttonCurrent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 345);
            this.Controls.Add(this.buttonCurrent);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Uso de BindingSource en DataGridView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotal;
        private System.Windows.Forms.Button buttonCurrent;
    }
}

