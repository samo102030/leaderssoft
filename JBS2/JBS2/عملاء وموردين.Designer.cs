namespace JBS2
{
    partial class customer
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
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label customer_nameLabel;
            System.Windows.Forms.Label cUST_Personal_IDLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label company_nameLabel;
            System.Windows.Forms.Label accountLabel;
            System.Windows.Forms.Label supplier_idLabel;
            System.Windows.Forms.Label supplier_nameLabel;
            System.Windows.Forms.Label sup_Personal_IDLabel;
            System.Windows.Forms.Label addressLabel1;
            System.Windows.Forms.Label phoneLabel1;
            System.Windows.Forms.Label mobileLabel1;
            System.Windows.Forms.Label e_mailLabel1;
            System.Windows.Forms.Label agentLabel;
            System.Windows.Forms.Label agent_mobileLabel;
            System.Windows.Forms.Label accountLabel1;
            this.johnDataSet = new JBS2.johnDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new JBS2.johnDataSetTableAdapters.ItemsTableAdapter();
            this.tableAdapterManager = new JBS2.johnDataSetTableAdapters.TableAdapterManager();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new JBS2.johnDataSetTableAdapters.customersTableAdapter();
            this.customer_idTextBox = new System.Windows.Forms.TextBox();
            this.customer_nameTextBox = new System.Windows.Forms.TextBox();
            this.cUST_Personal_IDTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.company_nameTextBox = new System.Windows.Forms.TextBox();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new JBS2.johnDataSetTableAdapters.supplierTableAdapter();
            this.supplier_idTextBox = new System.Windows.Forms.TextBox();
            this.supplier_nameTextBox = new System.Windows.Forms.TextBox();
            this.sup_Personal_IDTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox1 = new System.Windows.Forms.TextBox();
            this.phoneTextBox1 = new System.Windows.Forms.TextBox();
            this.mobileTextBox1 = new System.Windows.Forms.TextBox();
            this.e_mailTextBox1 = new System.Windows.Forms.TextBox();
            this.agentTextBox = new System.Windows.Forms.TextBox();
            this.agent_mobileTextBox = new System.Windows.Forms.TextBox();
            this.accountTextBox1 = new System.Windows.Forms.TextBox();
            customer_idLabel = new System.Windows.Forms.Label();
            customer_nameLabel = new System.Windows.Forms.Label();
            cUST_Personal_IDLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            company_nameLabel = new System.Windows.Forms.Label();
            accountLabel = new System.Windows.Forms.Label();
            supplier_idLabel = new System.Windows.Forms.Label();
            supplier_nameLabel = new System.Windows.Forms.Label();
            sup_Personal_IDLabel = new System.Windows.Forms.Label();
            addressLabel1 = new System.Windows.Forms.Label();
            phoneLabel1 = new System.Windows.Forms.Label();
            mobileLabel1 = new System.Windows.Forms.Label();
            e_mailLabel1 = new System.Windows.Forms.Label();
            agentLabel = new System.Windows.Forms.Label();
            agent_mobileLabel = new System.Windows.Forms.Label();
            accountLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // johnDataSet
            // 
            this.johnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.johnDataSet;
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
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.johnDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(277, 59);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(58, 13);
            customer_idLabel.TabIndex = 0;
            customer_idLabel.Text = "رقم العميل";
            // 
            // customer_idTextBox
            // 
            this.customer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Customer_id", true));
            this.customer_idTextBox.Location = new System.Drawing.Point(156, 59);
            this.customer_idTextBox.Name = "customer_idTextBox";
            this.customer_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.customer_idTextBox.TabIndex = 1;
            // 
            // customer_nameLabel
            // 
            customer_nameLabel.AutoSize = true;
            customer_nameLabel.Location = new System.Drawing.Point(277, 85);
            customer_nameLabel.Name = "customer_nameLabel";
            customer_nameLabel.Size = new System.Drawing.Size(63, 13);
            customer_nameLabel.TabIndex = 2;
            customer_nameLabel.Text = "اسم العميل";
            // 
            // customer_nameTextBox
            // 
            this.customer_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "customer_name", true));
            this.customer_nameTextBox.Location = new System.Drawing.Point(156, 85);
            this.customer_nameTextBox.Name = "customer_nameTextBox";
            this.customer_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.customer_nameTextBox.TabIndex = 3;
            // 
            // cUST_Personal_IDLabel
            // 
            cUST_Personal_IDLabel.AutoSize = true;
            cUST_Personal_IDLabel.Location = new System.Drawing.Point(277, 111);
            cUST_Personal_IDLabel.Name = "cUST_Personal_IDLabel";
            cUST_Personal_IDLabel.Size = new System.Drawing.Size(59, 13);
            cUST_Personal_IDLabel.TabIndex = 4;
            cUST_Personal_IDLabel.Text = "رقم البطاقة";
            // 
            // cUST_Personal_IDTextBox
            // 
            this.cUST_Personal_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CUST_Personal_ID", true));
            this.cUST_Personal_IDTextBox.Location = new System.Drawing.Point(156, 111);
            this.cUST_Personal_IDTextBox.Name = "cUST_Personal_IDTextBox";
            this.cUST_Personal_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.cUST_Personal_IDTextBox.TabIndex = 5;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(277, 137);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(38, 13);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "العنوان";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(156, 137);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 7;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(277, 163);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(35, 13);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "الهاتف";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(156, 163);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 9;
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Location = new System.Drawing.Point(277, 189);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(46, 13);
            mobileLabel.TabIndex = 10;
            mobileLabel.Text = "المحمول";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Mobile", true));
            this.mobileTextBox.Location = new System.Drawing.Point(156, 189);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(100, 20);
            this.mobileTextBox.TabIndex = 11;
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(277, 215);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(81, 13);
            e_mailLabel.TabIndex = 12;
            e_mailLabel.Text = "البريد الالكترونى";
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "E_mail", true));
            this.e_mailTextBox.Location = new System.Drawing.Point(156, 215);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(100, 20);
            this.e_mailTextBox.TabIndex = 13;
            // 
            // company_nameLabel
            // 
            company_nameLabel.AutoSize = true;
            company_nameLabel.Location = new System.Drawing.Point(277, 241);
            company_nameLabel.Name = "company_nameLabel";
            company_nameLabel.Size = new System.Drawing.Size(66, 13);
            company_nameLabel.TabIndex = 14;
            company_nameLabel.Text = "اسم الشركة";
            // 
            // company_nameTextBox
            // 
            this.company_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "company_name", true));
            this.company_nameTextBox.Location = new System.Drawing.Point(156, 241);
            this.company_nameTextBox.Name = "company_nameTextBox";
            this.company_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.company_nameTextBox.TabIndex = 15;
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.Location = new System.Drawing.Point(277, 267);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new System.Drawing.Size(44, 13);
            accountLabel.TabIndex = 16;
            accountLabel.Text = "الحساب";
            // 
            // accountTextBox
            // 
            this.accountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "account", true));
            this.accountTextBox.Location = new System.Drawing.Point(156, 267);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(100, 20);
            this.accountTextBox.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customer_idTextBox);
            this.groupBox1.Controls.Add(customer_idLabel);
            this.groupBox1.Controls.Add(this.accountTextBox);
            this.groupBox1.Controls.Add(accountLabel);
            this.groupBox1.Controls.Add(customer_nameLabel);
            this.groupBox1.Controls.Add(this.company_nameTextBox);
            this.groupBox1.Controls.Add(this.customer_nameTextBox);
            this.groupBox1.Controls.Add(company_nameLabel);
            this.groupBox1.Controls.Add(cUST_Personal_IDLabel);
            this.groupBox1.Controls.Add(this.e_mailTextBox);
            this.groupBox1.Controls.Add(this.cUST_Personal_IDTextBox);
            this.groupBox1.Controls.Add(e_mailLabel);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.mobileTextBox);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(mobileLabel);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Location = new System.Drawing.Point(529, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 471);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملاء";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(supplier_idLabel);
            this.groupBox2.Controls.Add(this.supplier_idTextBox);
            this.groupBox2.Controls.Add(supplier_nameLabel);
            this.groupBox2.Controls.Add(this.supplier_nameTextBox);
            this.groupBox2.Controls.Add(sup_Personal_IDLabel);
            this.groupBox2.Controls.Add(this.sup_Personal_IDTextBox);
            this.groupBox2.Controls.Add(addressLabel1);
            this.groupBox2.Controls.Add(this.addressTextBox1);
            this.groupBox2.Controls.Add(phoneLabel1);
            this.groupBox2.Controls.Add(this.phoneTextBox1);
            this.groupBox2.Controls.Add(mobileLabel1);
            this.groupBox2.Controls.Add(this.mobileTextBox1);
            this.groupBox2.Controls.Add(e_mailLabel1);
            this.groupBox2.Controls.Add(this.e_mailTextBox1);
            this.groupBox2.Controls.Add(agentLabel);
            this.groupBox2.Controls.Add(this.agentTextBox);
            this.groupBox2.Controls.Add(agent_mobileLabel);
            this.groupBox2.Controls.Add(this.agent_mobileTextBox);
            this.groupBox2.Controls.Add(accountLabel1);
            this.groupBox2.Controls.Add(this.accountTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(60, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 471);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "موردين";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.johnDataSet;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // supplier_idLabel
            // 
            supplier_idLabel.AutoSize = true;
            supplier_idLabel.Location = new System.Drawing.Point(269, 56);
            supplier_idLabel.Name = "supplier_idLabel";
            supplier_idLabel.Size = new System.Drawing.Size(54, 13);
            supplier_idLabel.TabIndex = 0;
            supplier_idLabel.Text = "رقم المورد";
            // 
            // supplier_idTextBox
            // 
            this.supplier_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_id", true));
            this.supplier_idTextBox.Location = new System.Drawing.Point(153, 56);
            this.supplier_idTextBox.Name = "supplier_idTextBox";
            this.supplier_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.supplier_idTextBox.TabIndex = 1;
            // 
            // supplier_nameLabel
            // 
            supplier_nameLabel.AutoSize = true;
            supplier_nameLabel.Location = new System.Drawing.Point(269, 82);
            supplier_nameLabel.Name = "supplier_nameLabel";
            supplier_nameLabel.Size = new System.Drawing.Size(59, 13);
            supplier_nameLabel.TabIndex = 2;
            supplier_nameLabel.Text = "اسم المورد";
            // 
            // supplier_nameTextBox
            // 
            this.supplier_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_name", true));
            this.supplier_nameTextBox.Location = new System.Drawing.Point(153, 82);
            this.supplier_nameTextBox.Name = "supplier_nameTextBox";
            this.supplier_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.supplier_nameTextBox.TabIndex = 3;
            // 
            // sup_Personal_IDLabel
            // 
            sup_Personal_IDLabel.AutoSize = true;
            sup_Personal_IDLabel.Location = new System.Drawing.Point(269, 108);
            sup_Personal_IDLabel.Name = "sup_Personal_IDLabel";
            sup_Personal_IDLabel.Size = new System.Drawing.Size(59, 13);
            sup_Personal_IDLabel.TabIndex = 4;
            sup_Personal_IDLabel.Text = "رقم البطاقة";
            // 
            // sup_Personal_IDTextBox
            // 
            this.sup_Personal_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Sup_Personal_ID", true));
            this.sup_Personal_IDTextBox.Location = new System.Drawing.Point(153, 108);
            this.sup_Personal_IDTextBox.Name = "sup_Personal_IDTextBox";
            this.sup_Personal_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.sup_Personal_IDTextBox.TabIndex = 5;
            // 
            // addressLabel1
            // 
            addressLabel1.AutoSize = true;
            addressLabel1.Location = new System.Drawing.Point(269, 134);
            addressLabel1.Name = "addressLabel1";
            addressLabel1.Size = new System.Drawing.Size(38, 13);
            addressLabel1.TabIndex = 6;
            addressLabel1.Text = "العنوان";
            // 
            // addressTextBox1
            // 
            this.addressTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "address", true));
            this.addressTextBox1.Location = new System.Drawing.Point(153, 134);
            this.addressTextBox1.Name = "addressTextBox1";
            this.addressTextBox1.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox1.TabIndex = 7;
            // 
            // phoneLabel1
            // 
            phoneLabel1.AutoSize = true;
            phoneLabel1.Location = new System.Drawing.Point(269, 160);
            phoneLabel1.Name = "phoneLabel1";
            phoneLabel1.Size = new System.Drawing.Size(35, 13);
            phoneLabel1.TabIndex = 8;
            phoneLabel1.Text = "الهاتف";
            // 
            // phoneTextBox1
            // 
            this.phoneTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "phone", true));
            this.phoneTextBox1.Location = new System.Drawing.Point(153, 160);
            this.phoneTextBox1.Name = "phoneTextBox1";
            this.phoneTextBox1.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox1.TabIndex = 9;
            // 
            // mobileLabel1
            // 
            mobileLabel1.AutoSize = true;
            mobileLabel1.Location = new System.Drawing.Point(269, 186);
            mobileLabel1.Name = "mobileLabel1";
            mobileLabel1.Size = new System.Drawing.Size(46, 13);
            mobileLabel1.TabIndex = 10;
            mobileLabel1.Text = "المحمول";
            // 
            // mobileTextBox1
            // 
            this.mobileTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Mobile", true));
            this.mobileTextBox1.Location = new System.Drawing.Point(153, 186);
            this.mobileTextBox1.Name = "mobileTextBox1";
            this.mobileTextBox1.Size = new System.Drawing.Size(100, 20);
            this.mobileTextBox1.TabIndex = 11;
            // 
            // e_mailLabel1
            // 
            e_mailLabel1.AutoSize = true;
            e_mailLabel1.Location = new System.Drawing.Point(269, 212);
            e_mailLabel1.Name = "e_mailLabel1";
            e_mailLabel1.Size = new System.Drawing.Size(81, 13);
            e_mailLabel1.TabIndex = 12;
            e_mailLabel1.Text = "البريد الالكترونى";
            // 
            // e_mailTextBox1
            // 
            this.e_mailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "E_mail", true));
            this.e_mailTextBox1.Location = new System.Drawing.Point(153, 212);
            this.e_mailTextBox1.Name = "e_mailTextBox1";
            this.e_mailTextBox1.Size = new System.Drawing.Size(100, 20);
            this.e_mailTextBox1.TabIndex = 13;
            // 
            // agentLabel
            // 
            agentLabel.AutoSize = true;
            agentLabel.Location = new System.Drawing.Point(269, 238);
            agentLabel.Name = "agentLabel";
            agentLabel.Size = new System.Drawing.Size(44, 13);
            agentLabel.TabIndex = 14;
            agentLabel.Text = "المندوب";
            // 
            // agentTextBox
            // 
            this.agentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "agent", true));
            this.agentTextBox.Location = new System.Drawing.Point(153, 238);
            this.agentTextBox.Name = "agentTextBox";
            this.agentTextBox.Size = new System.Drawing.Size(100, 20);
            this.agentTextBox.TabIndex = 15;
            // 
            // agent_mobileLabel
            // 
            agent_mobileLabel.AutoSize = true;
            agent_mobileLabel.Location = new System.Drawing.Point(269, 264);
            agent_mobileLabel.Name = "agent_mobileLabel";
            agent_mobileLabel.Size = new System.Drawing.Size(80, 13);
            agent_mobileLabel.TabIndex = 16;
            agent_mobileLabel.Text = "تيلبفون المندوب";
            // 
            // agent_mobileTextBox
            // 
            this.agent_mobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "agent_mobile", true));
            this.agent_mobileTextBox.Location = new System.Drawing.Point(153, 264);
            this.agent_mobileTextBox.Name = "agent_mobileTextBox";
            this.agent_mobileTextBox.Size = new System.Drawing.Size(100, 20);
            this.agent_mobileTextBox.TabIndex = 17;
            // 
            // accountLabel1
            // 
            accountLabel1.AutoSize = true;
            accountLabel1.Location = new System.Drawing.Point(269, 290);
            accountLabel1.Name = "accountLabel1";
            accountLabel1.Size = new System.Drawing.Size(44, 13);
            accountLabel1.TabIndex = 18;
            accountLabel1.Text = "الحساب";
            // 
            // accountTextBox1
            // 
            this.accountTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "account", true));
            this.accountTextBox1.Location = new System.Drawing.Point(153, 290);
            this.accountTextBox1.Name = "accountTextBox1";
            this.accountTextBox1.Size = new System.Drawing.Size(100, 20);
            this.accountTextBox1.TabIndex = 19;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 556);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "customer";
            this.Text = "العملاء والموردين";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private johnDataSet johnDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private johnDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private johnDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private johnDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private System.Windows.Forms.TextBox customer_idTextBox;
        private System.Windows.Forms.TextBox customer_nameTextBox;
        private System.Windows.Forms.TextBox cUST_Personal_IDTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.TextBox company_nameTextBox;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private johnDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.TextBox supplier_idTextBox;
        private System.Windows.Forms.TextBox supplier_nameTextBox;
        private System.Windows.Forms.TextBox sup_Personal_IDTextBox;
        private System.Windows.Forms.TextBox addressTextBox1;
        private System.Windows.Forms.TextBox phoneTextBox1;
        private System.Windows.Forms.TextBox mobileTextBox1;
        private System.Windows.Forms.TextBox e_mailTextBox1;
        private System.Windows.Forms.TextBox agentTextBox;
        private System.Windows.Forms.TextBox agent_mobileTextBox;
        private System.Windows.Forms.TextBox accountTextBox1;
    }
}