namespace JBS2
{
    partial class suppliers
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
            System.Windows.Forms.Label supplier_idLabel;
            System.Windows.Forms.Label supplier_nameLabel;
            System.Windows.Forms.Label sup_Personal_IDLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label agentLabel;
            System.Windows.Forms.Label agent_mobileLabel;
            System.Windows.Forms.Label accountLabel;
            this.supplier_idTextBox = new System.Windows.Forms.TextBox();
            this.supplier_nameTextBox = new System.Windows.Forms.TextBox();
            this.sup_Personal_IDTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.agentTextBox = new System.Windows.Forms.TextBox();
            this.agent_mobileTextBox = new System.Windows.Forms.TextBox();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.edite = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.johnDataSet = new JBS2.johnDataSet();
            this.supplierTableAdapter = new JBS2.johnDataSetTableAdapters.supplierTableAdapter();
            this.tableAdapterManager = new JBS2.johnDataSetTableAdapters.TableAdapterManager();
            supplier_idLabel = new System.Windows.Forms.Label();
            supplier_nameLabel = new System.Windows.Forms.Label();
            sup_Personal_IDLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            agentLabel = new System.Windows.Forms.Label();
            agent_mobileLabel = new System.Windows.Forms.Label();
            accountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // supplier_idLabel
            // 
            supplier_idLabel.AutoSize = true;
            supplier_idLabel.Location = new System.Drawing.Point(807, 59);
            supplier_idLabel.Name = "supplier_idLabel";
            supplier_idLabel.Size = new System.Drawing.Size(54, 13);
            supplier_idLabel.TabIndex = 1;
            supplier_idLabel.Text = "رقم المورد";
            // 
            // supplier_nameLabel
            // 
            supplier_nameLabel.AutoSize = true;
            supplier_nameLabel.Location = new System.Drawing.Point(802, 85);
            supplier_nameLabel.Name = "supplier_nameLabel";
            supplier_nameLabel.Size = new System.Drawing.Size(59, 13);
            supplier_nameLabel.TabIndex = 3;
            supplier_nameLabel.Text = "اسم المورد";
            // 
            // sup_Personal_IDLabel
            // 
            sup_Personal_IDLabel.AutoSize = true;
            sup_Personal_IDLabel.Location = new System.Drawing.Point(793, 114);
            sup_Personal_IDLabel.Name = "sup_Personal_IDLabel";
            sup_Personal_IDLabel.Size = new System.Drawing.Size(68, 13);
            sup_Personal_IDLabel.TabIndex = 5;
            sup_Personal_IDLabel.Text = "الرقم القومى";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(823, 140);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(38, 13);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "العنوان";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(823, 163);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(35, 13);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "الهاتف";
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Location = new System.Drawing.Point(408, 59);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(46, 13);
            mobileLabel.TabIndex = 11;
            mobileLabel.Text = "المحمول";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(375, 88);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(81, 13);
            e_mailLabel.TabIndex = 13;
            e_mailLabel.Text = "البريد الالكترونى";
            // 
            // agentLabel
            // 
            agentLabel.AutoSize = true;
            agentLabel.Location = new System.Drawing.Point(385, 111);
            agentLabel.Name = "agentLabel";
            agentLabel.Size = new System.Drawing.Size(69, 13);
            agentLabel.TabIndex = 15;
            agentLabel.Text = "اسم المندوب";
            // 
            // agent_mobileLabel
            // 
            agent_mobileLabel.AutoSize = true;
            agent_mobileLabel.Location = new System.Drawing.Point(390, 137);
            agent_mobileLabel.Name = "agent_mobileLabel";
            agent_mobileLabel.Size = new System.Drawing.Size(64, 13);
            agent_mobileLabel.TabIndex = 17;
            agent_mobileLabel.Text = "رقم المندوب";
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.Location = new System.Drawing.Point(410, 166);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new System.Drawing.Size(44, 13);
            accountLabel.TabIndex = 19;
            accountLabel.Text = "الحساب";
            // 
            // supplier_idTextBox
            // 
            this.supplier_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_id", true));
            this.supplier_idTextBox.Enabled = false;
            this.supplier_idTextBox.Location = new System.Drawing.Point(684, 59);
            this.supplier_idTextBox.Name = "supplier_idTextBox";
            this.supplier_idTextBox.Size = new System.Drawing.Size(94, 20);
            this.supplier_idTextBox.TabIndex = 2;
            // 
            // supplier_nameTextBox
            // 
            this.supplier_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_name", true));
            this.supplier_nameTextBox.Location = new System.Drawing.Point(512, 85);
            this.supplier_nameTextBox.Name = "supplier_nameTextBox";
            this.supplier_nameTextBox.Size = new System.Drawing.Size(266, 20);
            this.supplier_nameTextBox.TabIndex = 4;
            // 
            // sup_Personal_IDTextBox
            // 
            this.sup_Personal_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Sup_Personal_ID", true));
            this.sup_Personal_IDTextBox.Location = new System.Drawing.Point(512, 111);
            this.sup_Personal_IDTextBox.Name = "sup_Personal_IDTextBox";
            this.sup_Personal_IDTextBox.Size = new System.Drawing.Size(266, 20);
            this.sup_Personal_IDTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(512, 137);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(266, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(512, 163);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(266, 20);
            this.phoneTextBox.TabIndex = 10;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Mobile", true));
            this.mobileTextBox.Location = new System.Drawing.Point(92, 59);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(266, 20);
            this.mobileTextBox.TabIndex = 12;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "E_mail", true));
            this.e_mailTextBox.Location = new System.Drawing.Point(92, 85);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(266, 20);
            this.e_mailTextBox.TabIndex = 14;
            // 
            // agentTextBox
            // 
            this.agentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "agent", true));
            this.agentTextBox.Location = new System.Drawing.Point(92, 111);
            this.agentTextBox.Name = "agentTextBox";
            this.agentTextBox.Size = new System.Drawing.Size(266, 20);
            this.agentTextBox.TabIndex = 16;
            // 
            // agent_mobileTextBox
            // 
            this.agent_mobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "agent_mobile", true));
            this.agent_mobileTextBox.Location = new System.Drawing.Point(264, 134);
            this.agent_mobileTextBox.Name = "agent_mobileTextBox";
            this.agent_mobileTextBox.Size = new System.Drawing.Size(94, 20);
            this.agent_mobileTextBox.TabIndex = 18;
            // 
            // accountTextBox
            // 
            this.accountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "account", true));
            this.accountTextBox.Location = new System.Drawing.Point(264, 163);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(94, 20);
            this.accountTextBox.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 245);
            this.dataGridView1.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(289, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 34);
            this.button4.TabIndex = 26;
            this.button4.Text = "حفظ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 34);
            this.button3.TabIndex = 24;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // edite
            // 
            this.edite.Location = new System.Drawing.Point(565, 218);
            this.edite.Name = "edite";
            this.edite.Size = new System.Drawing.Size(106, 34);
            this.edite.TabIndex = 22;
            this.edite.Text = "تعديل";
            this.edite.UseVisualStyleBackColor = true;
            this.edite.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "اضافة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.johnDataSet;
            // 
            // johnDataSet
            // 
            this.johnDataSet.DataSetName = "johnDataSet";
            this.johnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager.typesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JBS2.johnDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 560);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.edite);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(supplier_idLabel);
            this.Controls.Add(this.supplier_idTextBox);
            this.Controls.Add(supplier_nameLabel);
            this.Controls.Add(this.supplier_nameTextBox);
            this.Controls.Add(sup_Personal_IDLabel);
            this.Controls.Add(this.sup_Personal_IDTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(mobileLabel);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(e_mailLabel);
            this.Controls.Add(this.e_mailTextBox);
            this.Controls.Add(agentLabel);
            this.Controls.Add(this.agentTextBox);
            this.Controls.Add(agent_mobileLabel);
            this.Controls.Add(this.agent_mobileTextBox);
            this.Controls.Add(accountLabel);
            this.Controls.Add(this.accountTextBox);
            this.Name = "suppliers";
            this.Text = "supp_iers";
            this.Load += new System.EventHandler(this.supp_iers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private johnDataSet johnDataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private johnDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private johnDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox supplier_idTextBox;
        private System.Windows.Forms.TextBox supplier_nameTextBox;
        private System.Windows.Forms.TextBox sup_Personal_IDTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.TextBox agentTextBox;
        private System.Windows.Forms.TextBox agent_mobileTextBox;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button edite;
        private System.Windows.Forms.Button button1;
    }
}