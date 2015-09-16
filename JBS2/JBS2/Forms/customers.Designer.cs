namespace JBS2
{
    partial class add_customers
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
            System.Windows.Forms.Label customer_nameLabel;
            System.Windows.Forms.Label cUST_Personal_IDLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label company_nameLabel;
            System.Windows.Forms.Label accountLabel;
            this.johnDataSet = new JBS2.johnDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new JBS2.johnDataSetTableAdapters.customersTableAdapter();
            this.tableAdapterManager = new JBS2.johnDataSetTableAdapters.TableAdapterManager();
            this.customer_nameTextBox = new System.Windows.Forms.TextBox();
            this.cUST_Personal_IDTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.company_nameTextBox = new System.Windows.Forms.TextBox();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.add_cust = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.edite_cust = new System.Windows.Forms.Button();
            this.remove_cust = new System.Windows.Forms.Button();
            this.show_cust = new System.Windows.Forms.Button();
            this.customer_UpdateQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_UpdateQueryTableAdapter = new JBS2.johnDataSetTableAdapters.Customer_UpdateQueryTableAdapter();
            customer_nameLabel = new System.Windows.Forms.Label();
            cUST_Personal_IDLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            company_nameLabel = new System.Windows.Forms.Label();
            accountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_UpdateQueryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_nameLabel
            // 
            customer_nameLabel.AutoSize = true;
            customer_nameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customer_nameLabel.Location = new System.Drawing.Point(827, 48);
            customer_nameLabel.Name = "customer_nameLabel";
            customer_nameLabel.Size = new System.Drawing.Size(96, 19);
            customer_nameLabel.TabIndex = 3;
            customer_nameLabel.Text = "اسم العميل";
            // 
            // cUST_Personal_IDLabel
            // 
            cUST_Personal_IDLabel.AutoSize = true;
            cUST_Personal_IDLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cUST_Personal_IDLabel.Location = new System.Drawing.Point(822, 74);
            cUST_Personal_IDLabel.Name = "cUST_Personal_IDLabel";
            cUST_Personal_IDLabel.Size = new System.Drawing.Size(107, 19);
            cUST_Personal_IDLabel.TabIndex = 5;
            cUST_Personal_IDLabel.Text = "الرقم القومى";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(839, 103);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(78, 19);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "العنــــوان";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(835, 129);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(86, 19);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "التليفــــون";
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mobileLabel.Location = new System.Drawing.Point(344, 48);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(98, 19);
            mobileLabel.TabIndex = 11;
            mobileLabel.Text = "المحمـــــول";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            e_mailLabel.Location = new System.Drawing.Point(317, 74);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(126, 19);
            e_mailLabel.TabIndex = 13;
            e_mailLabel.Text = "البريد الالكترونى";
            // 
            // company_nameLabel
            // 
            company_nameLabel.AutoSize = true;
            company_nameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            company_nameLabel.Location = new System.Drawing.Point(336, 103);
            company_nameLabel.Name = "company_nameLabel";
            company_nameLabel.Size = new System.Drawing.Size(103, 19);
            company_nameLabel.TabIndex = 15;
            company_nameLabel.Text = "اسم الشركة";
            company_nameLabel.Click += new System.EventHandler(this.company_nameLabel_Click);
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            accountLabel.Location = new System.Drawing.Point(345, 132);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new System.Drawing.Size(93, 19);
            accountLabel.TabIndex = 17;
            accountLabel.Text = "الحســـــاب";
            // 
            // johnDataSet
            // 
            this.johnDataSet.DataSetName = "johnDataSet";
            this.johnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.johnDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.CurrencyTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = this.customersTableAdapter;
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
            // customer_nameTextBox
            // 
            this.customer_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "customer_name", true));
            this.customer_nameTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_nameTextBox.Location = new System.Drawing.Point(543, 48);
            this.customer_nameTextBox.Name = "customer_nameTextBox";
            this.customer_nameTextBox.Size = new System.Drawing.Size(265, 21);
            this.customer_nameTextBox.TabIndex = 4;
            // 
            // cUST_Personal_IDTextBox
            // 
            this.cUST_Personal_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CUST_Personal_ID", true));
            this.cUST_Personal_IDTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cUST_Personal_IDTextBox.Location = new System.Drawing.Point(543, 74);
            this.cUST_Personal_IDTextBox.Name = "cUST_Personal_IDTextBox";
            this.cUST_Personal_IDTextBox.Size = new System.Drawing.Size(265, 21);
            this.cUST_Personal_IDTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(543, 100);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(265, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(543, 126);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(265, 21);
            this.phoneTextBox.TabIndex = 10;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Mobile", true));
            this.mobileTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileTextBox.Location = new System.Drawing.Point(42, 48);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(265, 21);
            this.mobileTextBox.TabIndex = 12;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "E_mail", true));
            this.e_mailTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_mailTextBox.Location = new System.Drawing.Point(42, 74);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(265, 21);
            this.e_mailTextBox.TabIndex = 14;
            // 
            // company_nameTextBox
            // 
            this.company_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "company_name", true));
            this.company_nameTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_nameTextBox.Location = new System.Drawing.Point(42, 100);
            this.company_nameTextBox.Name = "company_nameTextBox";
            this.company_nameTextBox.Size = new System.Drawing.Size(265, 21);
            this.company_nameTextBox.TabIndex = 16;
            // 
            // accountTextBox
            // 
            this.accountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "account", true));
            this.accountTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTextBox.Location = new System.Drawing.Point(190, 126);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(117, 21);
            this.accountTextBox.TabIndex = 18;
            // 
            // add_cust
            // 
            this.add_cust.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cust.Location = new System.Drawing.Point(610, 186);
            this.add_cust.Name = "add_cust";
            this.add_cust.Size = new System.Drawing.Size(126, 39);
            this.add_cust.TabIndex = 19;
            this.add_cust.Text = "اضافة";
            this.add_cust.UseVisualStyleBackColor = true;
            this.add_cust.Click += new System.EventHandler(this.add_cust_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(950, 267);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // edite_cust
            // 
            this.edite_cust.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edite_cust.Location = new System.Drawing.Point(461, 186);
            this.edite_cust.Name = "edite_cust";
            this.edite_cust.Size = new System.Drawing.Size(126, 39);
            this.edite_cust.TabIndex = 19;
            this.edite_cust.Text = "تعديل";
            this.edite_cust.UseVisualStyleBackColor = true;
            this.edite_cust.Click += new System.EventHandler(this.edite_cust_Click);
            // 
            // remove_cust
            // 
            this.remove_cust.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_cust.Location = new System.Drawing.Point(312, 186);
            this.remove_cust.Name = "remove_cust";
            this.remove_cust.Size = new System.Drawing.Size(126, 39);
            this.remove_cust.TabIndex = 19;
            this.remove_cust.Text = "حذف";
            this.remove_cust.UseVisualStyleBackColor = true;
            this.remove_cust.Click += new System.EventHandler(this.remove_cust_Click);
            // 
            // show_cust
            // 
            this.show_cust.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_cust.Location = new System.Drawing.Point(42, 175);
            this.show_cust.Name = "show_cust";
            this.show_cust.Size = new System.Drawing.Size(159, 50);
            this.show_cust.TabIndex = 19;
            this.show_cust.Text = "عرض بيانات العملاء";
            this.show_cust.UseVisualStyleBackColor = true;
            this.show_cust.Click += new System.EventHandler(this.show_cust_Click);
            // 
            // customer_UpdateQueryBindingSource
            // 
            this.customer_UpdateQueryBindingSource.DataMember = "Customer_UpdateQuery";
            this.customer_UpdateQueryBindingSource.DataSource = this.johnDataSet;
            // 
            // customer_UpdateQueryTableAdapter
            // 
            this.customer_UpdateQueryTableAdapter.ClearBeforeFill = true;
            // 
            // add_customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 515);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.show_cust);
            this.Controls.Add(this.remove_cust);
            this.Controls.Add(this.edite_cust);
            this.Controls.Add(this.add_cust);
            this.Controls.Add(customer_nameLabel);
            this.Controls.Add(this.customer_nameTextBox);
            this.Controls.Add(cUST_Personal_IDLabel);
            this.Controls.Add(this.cUST_Personal_IDTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(mobileLabel);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(e_mailLabel);
            this.Controls.Add(this.e_mailTextBox);
            this.Controls.Add(company_nameLabel);
            this.Controls.Add(this.company_nameTextBox);
            this.Controls.Add(accountLabel);
            this.Controls.Add(this.accountTextBox);
            this.Name = "add_customers";
            this.Text = "customers";
            this.Load += new System.EventHandler(this.customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_UpdateQueryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private johnDataSet johnDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private johnDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private johnDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox customer_nameTextBox;
        private System.Windows.Forms.TextBox cUST_Personal_IDTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.TextBox company_nameTextBox;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.Button add_cust;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button edite_cust;
        private System.Windows.Forms.Button remove_cust;
        private System.Windows.Forms.Button show_cust;
        private System.Windows.Forms.BindingSource customer_UpdateQueryBindingSource;
        private johnDataSetTableAdapters.Customer_UpdateQueryTableAdapter customer_UpdateQueryTableAdapter;
    }
}