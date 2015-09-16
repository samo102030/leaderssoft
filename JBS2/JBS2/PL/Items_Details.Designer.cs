namespace JBS2
{
    partial class Items_Details2
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
            System.Windows.Forms.Label item_IDLabel;
            System.Windows.Forms.Label item_NameLabel;
            System.Windows.Forms.Label item_MinLabel;
            System.Windows.Forms.Label item_brandLabel;
            System.Windows.Forms.Label item_amountLabel;
            System.Windows.Forms.Label item_coast_saleLabel;
            System.Windows.Forms.Label item_storeLabel;
            System.Windows.Forms.Label item_private_saleLabel;
            System.Windows.Forms.Label item_genral_saleLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itembrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcoastsaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemstoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemprivatesaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemgenralsaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.johnDataSet = new JBS2.johnDataSet();
            this.itemsTableAdapter = new JBS2.johnDataSetTableAdapters.ItemsTableAdapter();
            this.tableAdapterManager = new JBS2.johnDataSetTableAdapters.TableAdapterManager();
            this.item_IDTextBox = new System.Windows.Forms.TextBox();
            this.item_NameTextBox = new System.Windows.Forms.TextBox();
            this.item_MinTextBox = new System.Windows.Forms.TextBox();
            this.item_amountTextBox = new System.Windows.Forms.TextBox();
            this.item_coast_saleTextBox = new System.Windows.Forms.TextBox();
            this.item_private_saleTextBox = new System.Windows.Forms.TextBox();
            this.item_genral_saleTextBox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            item_IDLabel = new System.Windows.Forms.Label();
            item_NameLabel = new System.Windows.Forms.Label();
            item_MinLabel = new System.Windows.Forms.Label();
            item_brandLabel = new System.Windows.Forms.Label();
            item_amountLabel = new System.Windows.Forms.Label();
            item_coast_saleLabel = new System.Windows.Forms.Label();
            item_storeLabel = new System.Windows.Forms.Label();
            item_private_saleLabel = new System.Windows.Forms.Label();
            item_genral_saleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // item_IDLabel
            // 
            item_IDLabel.AutoSize = true;
            item_IDLabel.Location = new System.Drawing.Point(29, 49);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(47, 13);
            item_IDLabel.TabIndex = 1;
            item_IDLabel.Text = "Item ID:";
            // 
            // item_NameLabel
            // 
            item_NameLabel.AutoSize = true;
            item_NameLabel.Location = new System.Drawing.Point(29, 75);
            item_NameLabel.Name = "item_NameLabel";
            item_NameLabel.Size = new System.Drawing.Size(63, 13);
            item_NameLabel.TabIndex = 3;
            item_NameLabel.Text = "Item Name:";
            // 
            // item_MinLabel
            // 
            item_MinLabel.AutoSize = true;
            item_MinLabel.Location = new System.Drawing.Point(29, 101);
            item_MinLabel.Name = "item_MinLabel";
            item_MinLabel.Size = new System.Drawing.Size(52, 13);
            item_MinLabel.TabIndex = 5;
            item_MinLabel.Text = "Item Min:";
            // 
            // item_brandLabel
            // 
            item_brandLabel.AutoSize = true;
            item_brandLabel.Location = new System.Drawing.Point(29, 127);
            item_brandLabel.Name = "item_brandLabel";
            item_brandLabel.Size = new System.Drawing.Size(64, 13);
            item_brandLabel.TabIndex = 7;
            item_brandLabel.Text = "Item brand:";
            // 
            // item_amountLabel
            // 
            item_amountLabel.AutoSize = true;
            item_amountLabel.Location = new System.Drawing.Point(344, 27);
            item_amountLabel.Name = "item_amountLabel";
            item_amountLabel.Size = new System.Drawing.Size(72, 13);
            item_amountLabel.TabIndex = 9;
            item_amountLabel.Text = "Item amount:";
            // 
            // item_coast_saleLabel
            // 
            item_coast_saleLabel.AutoSize = true;
            item_coast_saleLabel.Location = new System.Drawing.Point(344, 53);
            item_coast_saleLabel.Name = "item_coast_saleLabel";
            item_coast_saleLabel.Size = new System.Drawing.Size(84, 13);
            item_coast_saleLabel.TabIndex = 11;
            item_coast_saleLabel.Text = "Item coast sale:";
            // 
            // item_storeLabel
            // 
            item_storeLabel.AutoSize = true;
            item_storeLabel.Location = new System.Drawing.Point(344, 79);
            item_storeLabel.Name = "item_storeLabel";
            item_storeLabel.Size = new System.Drawing.Size(61, 13);
            item_storeLabel.TabIndex = 13;
            item_storeLabel.Text = "Item store:";
            // 
            // item_private_saleLabel
            // 
            item_private_saleLabel.AutoSize = true;
            item_private_saleLabel.Location = new System.Drawing.Point(344, 105);
            item_private_saleLabel.Name = "item_private_saleLabel";
            item_private_saleLabel.Size = new System.Drawing.Size(92, 13);
            item_private_saleLabel.TabIndex = 15;
            item_private_saleLabel.Text = "Item private sale:";
            // 
            // item_genral_saleLabel
            // 
            item_genral_saleLabel.AutoSize = true;
            item_genral_saleLabel.Location = new System.Drawing.Point(344, 131);
            item_genral_saleLabel.Name = "item_genral_saleLabel";
            item_genral_saleLabel.Size = new System.Drawing.Size(88, 13);
            item_genral_saleLabel.TabIndex = 17;
            item_genral_saleLabel.Text = "Item genral sale:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemMinDataGridViewTextBoxColumn,
            this.itembrandDataGridViewTextBoxColumn,
            this.itemamountDataGridViewTextBoxColumn,
            this.itemcoastsaleDataGridViewTextBoxColumn,
            this.itemstoreDataGridViewTextBoxColumn,
            this.itemprivatesaleDataGridViewTextBoxColumn,
            this.itemgenralsaleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(855, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "Item_ID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Item_ID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item_Name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemMinDataGridViewTextBoxColumn
            // 
            this.itemMinDataGridViewTextBoxColumn.DataPropertyName = "Item_Min";
            this.itemMinDataGridViewTextBoxColumn.HeaderText = "Item_Min";
            this.itemMinDataGridViewTextBoxColumn.Name = "itemMinDataGridViewTextBoxColumn";
            // 
            // itembrandDataGridViewTextBoxColumn
            // 
            this.itembrandDataGridViewTextBoxColumn.DataPropertyName = "Item_brand";
            this.itembrandDataGridViewTextBoxColumn.HeaderText = "Item_brand";
            this.itembrandDataGridViewTextBoxColumn.Name = "itembrandDataGridViewTextBoxColumn";
            // 
            // itemamountDataGridViewTextBoxColumn
            // 
            this.itemamountDataGridViewTextBoxColumn.DataPropertyName = "Item_amount";
            this.itemamountDataGridViewTextBoxColumn.HeaderText = "Item_amount";
            this.itemamountDataGridViewTextBoxColumn.Name = "itemamountDataGridViewTextBoxColumn";
            // 
            // itemcoastsaleDataGridViewTextBoxColumn
            // 
            this.itemcoastsaleDataGridViewTextBoxColumn.DataPropertyName = "Item_coast_sale";
            this.itemcoastsaleDataGridViewTextBoxColumn.HeaderText = "Item_coast_sale";
            this.itemcoastsaleDataGridViewTextBoxColumn.Name = "itemcoastsaleDataGridViewTextBoxColumn";
            // 
            // itemstoreDataGridViewTextBoxColumn
            // 
            this.itemstoreDataGridViewTextBoxColumn.DataPropertyName = "Item_store";
            this.itemstoreDataGridViewTextBoxColumn.HeaderText = "Item_store";
            this.itemstoreDataGridViewTextBoxColumn.Name = "itemstoreDataGridViewTextBoxColumn";
            // 
            // itemprivatesaleDataGridViewTextBoxColumn
            // 
            this.itemprivatesaleDataGridViewTextBoxColumn.DataPropertyName = "Item_private_sale";
            this.itemprivatesaleDataGridViewTextBoxColumn.HeaderText = "Item_private_sale";
            this.itemprivatesaleDataGridViewTextBoxColumn.Name = "itemprivatesaleDataGridViewTextBoxColumn";
            // 
            // itemgenralsaleDataGridViewTextBoxColumn
            // 
            this.itemgenralsaleDataGridViewTextBoxColumn.DataPropertyName = "Item_genral_sale";
            this.itemgenralsaleDataGridViewTextBoxColumn.HeaderText = "Item_genral_sale";
            this.itemgenralsaleDataGridViewTextBoxColumn.Name = "itemgenralsaleDataGridViewTextBoxColumn";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.johnDataSet;
            // 
            // johnDataSet
            // 
            this.johnDataSet.DataSetName = "johnDataSet";
            this.johnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.CurrencyTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.Dameged_ItemTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
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
            // item_IDTextBox
            // 
            this.item_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_ID", true));
            this.item_IDTextBox.Location = new System.Drawing.Point(127, 46);
            this.item_IDTextBox.Name = "item_IDTextBox";
            this.item_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.item_IDTextBox.TabIndex = 2;
            // 
            // item_NameTextBox
            // 
            this.item_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_Name", true));
            this.item_NameTextBox.Location = new System.Drawing.Point(127, 72);
            this.item_NameTextBox.Name = "item_NameTextBox";
            this.item_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.item_NameTextBox.TabIndex = 4;
            // 
            // item_MinTextBox
            // 
            this.item_MinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_Min", true));
            this.item_MinTextBox.Location = new System.Drawing.Point(127, 98);
            this.item_MinTextBox.Name = "item_MinTextBox";
            this.item_MinTextBox.Size = new System.Drawing.Size(100, 20);
            this.item_MinTextBox.TabIndex = 6;
            // 
            // item_amountTextBox
            // 
            this.item_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_amount", true));
            this.item_amountTextBox.Location = new System.Drawing.Point(442, 24);
            this.item_amountTextBox.Name = "item_amountTextBox";
            this.item_amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.item_amountTextBox.TabIndex = 10;
            // 
            // item_coast_saleTextBox
            // 
            this.item_coast_saleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_coast_sale", true));
            this.item_coast_saleTextBox.Location = new System.Drawing.Point(442, 50);
            this.item_coast_saleTextBox.Name = "item_coast_saleTextBox";
            this.item_coast_saleTextBox.Size = new System.Drawing.Size(100, 20);
            this.item_coast_saleTextBox.TabIndex = 12;
            // 
            // item_private_saleTextBox
            // 
            this.item_private_saleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_private_sale", true));
            this.item_private_saleTextBox.Location = new System.Drawing.Point(442, 102);
            this.item_private_saleTextBox.Name = "item_private_saleTextBox";
            this.item_private_saleTextBox.Size = new System.Drawing.Size(100, 20);
            this.item_private_saleTextBox.TabIndex = 16;
            // 
            // item_genral_saleTextBox
            // 
            this.item_genral_saleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_genral_sale", true));
            this.item_genral_saleTextBox.Location = new System.Drawing.Point(442, 128);
            this.item_genral_saleTextBox.Name = "item_genral_saleTextBox";
            this.item_genral_saleTextBox.Size = new System.Drawing.Size(100, 20);
            this.item_genral_saleTextBox.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(442, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "Item_brand", true));
            this.comboBox1.DataSource = this.itemsBindingSource1;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.johnDataSet;
            // 
            // Items_Details2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 358);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(item_IDLabel);
            this.Controls.Add(this.item_IDTextBox);
            this.Controls.Add(item_NameLabel);
            this.Controls.Add(this.item_NameTextBox);
            this.Controls.Add(item_MinLabel);
            this.Controls.Add(this.item_MinTextBox);
            this.Controls.Add(item_brandLabel);
            this.Controls.Add(item_amountLabel);
            this.Controls.Add(this.item_amountTextBox);
            this.Controls.Add(item_coast_saleLabel);
            this.Controls.Add(this.item_coast_saleTextBox);
            this.Controls.Add(item_storeLabel);
            this.Controls.Add(item_private_saleLabel);
            this.Controls.Add(this.item_private_saleTextBox);
            this.Controls.Add(item_genral_saleLabel);
            this.Controls.Add(this.item_genral_saleTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Items_Details2";
            this.Text = "Items_Details";
            this.Load += new System.EventHandler(this.Items_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private johnDataSet johnDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private johnDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itembrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcoastsaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemstoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemprivatesaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemgenralsaleDataGridViewTextBoxColumn;
        private johnDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox item_IDTextBox;
        private System.Windows.Forms.TextBox item_NameTextBox;
        private System.Windows.Forms.TextBox item_MinTextBox;
        private System.Windows.Forms.TextBox item_amountTextBox;
        private System.Windows.Forms.TextBox item_coast_saleTextBox;
        private System.Windows.Forms.TextBox item_private_saleTextBox;
        private System.Windows.Forms.TextBox item_genral_saleTextBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
    }
}