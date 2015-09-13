namespace JBS2
{
    partial class brands
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
            System.Windows.Forms.Label brand_nameLabel;
            this.brand_nameTextBox = new System.Windows.Forms.TextBox();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.johnDataSet = new JBS2.johnDataSet();
            this.add_brand = new System.Windows.Forms.Button();
            this.brandTableAdapter = new JBS2.johnDataSetTableAdapters.BrandTableAdapter();
            this.tableAdapterManager = new JBS2.johnDataSetTableAdapters.TableAdapterManager();
            brand_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // brand_nameLabel
            // 
            brand_nameLabel.AutoSize = true;
            brand_nameLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            brand_nameLabel.Location = new System.Drawing.Point(260, 52);
            brand_nameLabel.Name = "brand_nameLabel";
            brand_nameLabel.Size = new System.Drawing.Size(127, 23);
            brand_nameLabel.TabIndex = 3;
            brand_nameLabel.Text = "اسم المصنع ";
            // 
            // brand_nameTextBox
            // 
            this.brand_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brandBindingSource, "Brand_name", true));
            this.brand_nameTextBox.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.brand_nameTextBox.Location = new System.Drawing.Point(38, 52);
            this.brand_nameTextBox.Name = "brand_nameTextBox";
            this.brand_nameTextBox.Size = new System.Drawing.Size(195, 30);
            this.brand_nameTextBox.TabIndex = 4;
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "Brand";
            this.brandBindingSource.DataSource = this.johnDataSet;
            // 
            // johnDataSet
            // 
            this.johnDataSet.DataSetName = "johnDataSet";
            this.johnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // add_brand
            // 
            this.add_brand.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.add_brand.Location = new System.Drawing.Point(134, 106);
            this.add_brand.Name = "add_brand";
            this.add_brand.Size = new System.Drawing.Size(170, 62);
            this.add_brand.TabIndex = 5;
            this.add_brand.Text = "حفظ";
            this.add_brand.UseVisualStyleBackColor = true;
            this.add_brand.Click += new System.EventHandler(this.add_brand_Click);
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = this.brandTableAdapter;
            this.tableAdapterManager.CurrencyTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.Dameged_ItemTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.Order_in_detailesTableAdapter = null;
            this.tableAdapterManager.Order_Out_DetailsTableAdapter = null;
            this.tableAdapterManager.Order_OutTableAdapter = null;
            this.tableAdapterManager.Orders_inTableAdapter = null;
            this.tableAdapterManager.paid_customerTableAdapter = null;
            this.tableAdapterManager.paid_to_supplierTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.typesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JBS2.johnDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // brands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 190);
            this.Controls.Add(this.add_brand);
            this.Controls.Add(brand_nameLabel);
            this.Controls.Add(this.brand_nameTextBox);
            this.Name = "brands";
            this.Text = " اضافة مصنع";
            this.Load += new System.EventHandler(this.brands_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private johnDataSet johnDataSet;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private johnDataSetTableAdapters.BrandTableAdapter brandTableAdapter;
        private johnDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox brand_nameTextBox;
        private System.Windows.Forms.Button add_brand;

    }
}