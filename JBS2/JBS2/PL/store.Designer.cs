namespace JBS2
{
    partial class add_store
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
            System.Windows.Forms.Label store_IDLabel;
            System.Windows.Forms.Label store_NameLabel;
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.johnDataSet = new JBS2.johnDataSet();
            this.store_IDTextBox = new System.Windows.Forms.TextBox();
            this.store_NameTextBox = new System.Windows.Forms.TextBox();
            this.add_stores = new System.Windows.Forms.Button();
            this.storeTableAdapter = new JBS2.johnDataSetTableAdapters.StoreTableAdapter();
            this.tableAdapterManager = new JBS2.johnDataSetTableAdapters.TableAdapterManager();
            this.storeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.johnDataSet2 = new JBS2.johnDataSet();
            this.storeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.storeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.home_back = new System.Windows.Forms.Button();
            this.store_delete = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            store_IDLabel = new System.Windows.Forms.Label();
            store_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // store_IDLabel
            // 
            store_IDLabel.AutoSize = true;
            store_IDLabel.Location = new System.Drawing.Point(338, 126);
            store_IDLabel.Name = "store_IDLabel";
            store_IDLabel.Size = new System.Drawing.Size(59, 13);
            store_IDLabel.TabIndex = 1;
            store_IDLabel.Text = "رقم المخزن";
            // 
            // store_NameLabel
            // 
            store_NameLabel.AutoSize = true;
            store_NameLabel.Location = new System.Drawing.Point(338, 152);
            store_NameLabel.Name = "store_NameLabel";
            store_NameLabel.Size = new System.Drawing.Size(64, 13);
            store_NameLabel.TabIndex = 3;
            store_NameLabel.Text = "اسم المخزن";
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "Store";
            this.storeBindingSource.DataSource = this.johnDataSet;
            // 
            // johnDataSet
            // 
            this.johnDataSet.DataSetName = "johnDataSet";
            this.johnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // store_IDTextBox
            // 
            this.store_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource, "Store_ID", true));
            this.store_IDTextBox.Location = new System.Drawing.Point(232, 123);
            this.store_IDTextBox.Name = "store_IDTextBox";
            this.store_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.store_IDTextBox.TabIndex = 2;
            // 
            // store_NameTextBox
            // 
            this.store_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource, "Store_Name", true));
            this.store_NameTextBox.Location = new System.Drawing.Point(140, 149);
            this.store_NameTextBox.Name = "store_NameTextBox";
            this.store_NameTextBox.Size = new System.Drawing.Size(192, 20);
            this.store_NameTextBox.TabIndex = 4;
            // 
            // add_stores
            // 
            this.add_stores.Location = new System.Drawing.Point(47, 62);
            this.add_stores.Name = "add_stores";
            this.add_stores.Size = new System.Drawing.Size(85, 28);
            this.add_stores.TabIndex = 6;
            this.add_stores.Text = "اضافة";
            this.add_stores.UseVisualStyleBackColor = true;
            this.add_stores.Click += new System.EventHandler(this.add_stores_Click);
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
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
            this.tableAdapterManager.StoreTableAdapter = this.storeTableAdapter;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.typesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JBS2.johnDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // storeBindingSource1
            // 
            this.storeBindingSource1.DataMember = "Store";
            // 
            // johnDataSet2
            // 
            this.johnDataSet2.DataSetName = "johnDataSet";
            this.johnDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeBindingSource2
            // 
            this.storeBindingSource2.DataMember = "Store";
            this.storeBindingSource2.DataSource = this.johnDataSet2;
            // 
            // storeBindingSource3
            // 
            this.storeBindingSource3.DataMember = "Store";
            this.storeBindingSource3.DataSource = this.johnDataSet2;
            // 
            // home_back
            // 
            this.home_back.Location = new System.Drawing.Point(206, 19);
            this.home_back.Name = "home_back";
            this.home_back.Size = new System.Drawing.Size(126, 28);
            this.home_back.TabIndex = 8;
            this.home_back.Text = "الصفحة الرئيسية";
            this.home_back.UseVisualStyleBackColor = true;
            this.home_back.Click += new System.EventHandler(this.home_back_Click);
            // 
            // store_delete
            // 
            this.store_delete.Location = new System.Drawing.Point(20, 96);
            this.store_delete.Name = "store_delete";
            this.store_delete.Size = new System.Drawing.Size(112, 28);
            this.store_delete.TabIndex = 9;
            this.store_delete.Text = "عرض المخازن";
            this.store_delete.UseVisualStyleBackColor = true;
            this.store_delete.Click += new System.EventHandler(this.store_delete_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 219);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(243, 278);
            this.dataGridView2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "تعديل بيانات مخزن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.home_back);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.store_NameTextBox);
            this.groupBox1.Controls.Add(store_NameLabel);
            this.groupBox1.Controls.Add(this.store_delete);
            this.groupBox1.Controls.Add(this.add_stores);
            this.groupBox1.Controls.Add(this.store_IDTextBox);
            this.groupBox1.Controls.Add(store_IDLabel);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 198);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المخازن";
            // 
            // add_store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "add_store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مخزن جديد";
            this.Load += new System.EventHandler(this.add_store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private johnDataSet johnDataSet;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private johnDataSetTableAdapters.StoreTableAdapter storeTableAdapter;
        private johnDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox store_IDTextBox;
        private System.Windows.Forms.TextBox store_NameTextBox;
        private System.Windows.Forms.Button add_stores;
        private System.Windows.Forms.BindingSource storeBindingSource1;
        
        private johnDataSet johnDataSet2;
        private System.Windows.Forms.BindingSource storeBindingSource2;
        private System.Windows.Forms.BindingSource storeBindingSource3;
        private System.Windows.Forms.Button home_back;
        private System.Windows.Forms.Button store_delete;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}