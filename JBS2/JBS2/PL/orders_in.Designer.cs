namespace JBS2
{
    partial class orders_in
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
            System.Windows.Forms.Label bill_imageLabel;
            System.Windows.Forms.Label bill_NotesLabel;
            System.Windows.Forms.Label bill_Cost_RemainLabel;
            System.Windows.Forms.Label bill_cost_paidLabel;
            System.Windows.Forms.Label bill_in_CostLabel;
            System.Windows.Forms.Label addational_Cost_NotesLabel;
            System.Windows.Forms.Label addational_CostLabel;
            System.Windows.Forms.Label bill_DateLabel;
            System.Windows.Forms.Label supplier_IDLabel;
            System.Windows.Forms.Label emp_IDLabel;
            System.Windows.Forms.Label bill_in_IDLabel1;
            System.Windows.Forms.Label item_IDLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label item_amount_In_stokeLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.bill_imageTextBox = new System.Windows.Forms.TextBox();
            this.closedCheckBox = new System.Windows.Forms.CheckBox();
            this.bill_NotesTextBox = new System.Windows.Forms.TextBox();
            this.is_returnCheckBox = new System.Windows.Forms.CheckBox();
            this.bill_Cost_RemainTextBox = new System.Windows.Forms.TextBox();
            this.bill_cost_paidTextBox = new System.Windows.Forms.TextBox();
            this.bill_in_CostTextBox = new System.Windows.Forms.TextBox();
            this.addational_Cost_NotesTextBox = new System.Windows.Forms.TextBox();
            this.addational_CostTextBox = new System.Windows.Forms.TextBox();
            this.bill_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.johnDataSet = new JBS2.johnDataSet();
            this.order_in_detailesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_in_detailesTableAdapter = new JBS2.johnDataSetTableAdapters.Order_in_detailesTableAdapter();
            this.tableAdapterManager = new JBS2.johnDataSetTableAdapters.TableAdapterManager();
            this.itemsTableAdapter = new JBS2.johnDataSetTableAdapters.ItemsTableAdapter();
            this.supplierTableAdapter = new JBS2.johnDataSetTableAdapters.supplierTableAdapter();
            this.bill_in_IDTextBox1 = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.item_amount_In_stokeTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.johnDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Items_comboBox = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderindetailesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.code_textBox = new System.Windows.Forms.TextBox();
            this.remove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.save_bill = new System.Windows.Forms.Button();
            this.add_item = new System.Windows.Forms.Button();
            this.nw_order = new System.Windows.Forms.Button();
            bill_imageLabel = new System.Windows.Forms.Label();
            bill_NotesLabel = new System.Windows.Forms.Label();
            bill_Cost_RemainLabel = new System.Windows.Forms.Label();
            bill_cost_paidLabel = new System.Windows.Forms.Label();
            bill_in_CostLabel = new System.Windows.Forms.Label();
            addational_Cost_NotesLabel = new System.Windows.Forms.Label();
            addational_CostLabel = new System.Windows.Forms.Label();
            bill_DateLabel = new System.Windows.Forms.Label();
            supplier_IDLabel = new System.Windows.Forms.Label();
            emp_IDLabel = new System.Windows.Forms.Label();
            bill_in_IDLabel1 = new System.Windows.Forms.Label();
            item_IDLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            item_amount_In_stokeLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_in_detailesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderindetailesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bill_imageLabel
            // 
            bill_imageLabel.AutoSize = true;
            bill_imageLabel.Location = new System.Drawing.Point(365, 199);
            bill_imageLabel.Name = "bill_imageLabel";
            bill_imageLabel.Size = new System.Drawing.Size(65, 13);
            bill_imageLabel.TabIndex = 50;
            bill_imageLabel.Text = "صورة الفاتورة";
            // 
            // bill_NotesLabel
            // 
            bill_NotesLabel.AutoSize = true;
            bill_NotesLabel.Location = new System.Drawing.Point(322, 143);
            bill_NotesLabel.Name = "bill_NotesLabel";
            bill_NotesLabel.Size = new System.Drawing.Size(108, 13);
            bill_NotesLabel.TabIndex = 46;
            bill_NotesLabel.Text = "ملاحظات على الفاتورة";
            // 
            // bill_Cost_RemainLabel
            // 
            bill_Cost_RemainLabel.AutoSize = true;
            bill_Cost_RemainLabel.Location = new System.Drawing.Point(442, 519);
            bill_Cost_RemainLabel.Name = "bill_Cost_RemainLabel";
            bill_Cost_RemainLabel.Size = new System.Drawing.Size(102, 13);
            bill_Cost_RemainLabel.TabIndex = 42;
            bill_Cost_RemainLabel.Text = "المتبقى من الحساب";
            // 
            // bill_cost_paidLabel
            // 
            bill_cost_paidLabel.AutoSize = true;
            bill_cost_paidLabel.Location = new System.Drawing.Point(452, 489);
            bill_cost_paidLabel.Name = "bill_cost_paidLabel";
            bill_cost_paidLabel.Size = new System.Drawing.Size(43, 13);
            bill_cost_paidLabel.TabIndex = 40;
            bill_cost_paidLabel.Text = "المدفوع";
            // 
            // bill_in_CostLabel
            // 
            bill_in_CostLabel.AutoSize = true;
            bill_in_CostLabel.Location = new System.Drawing.Point(679, 486);
            bill_in_CostLabel.Name = "bill_in_CostLabel";
            bill_in_CostLabel.Size = new System.Drawing.Size(76, 13);
            bill_in_CostLabel.TabIndex = 38;
            bill_in_CostLabel.Text = "اجمالى الفاتورة";
            // 
            // addational_Cost_NotesLabel
            // 
            addational_Cost_NotesLabel.AutoSize = true;
            addational_Cost_NotesLabel.Location = new System.Drawing.Point(785, 143);
            addational_Cost_NotesLabel.Name = "addational_Cost_NotesLabel";
            addational_Cost_NotesLabel.Size = new System.Drawing.Size(85, 13);
            addational_Cost_NotesLabel.TabIndex = 36;
            addational_Cost_NotesLabel.Text = "تفاصيل المصاريف";
            // 
            // addational_CostLabel
            // 
            addational_CostLabel.AutoSize = true;
            addational_CostLabel.Location = new System.Drawing.Point(792, 117);
            addational_CostLabel.Name = "addational_CostLabel";
            addational_CostLabel.Size = new System.Drawing.Size(78, 13);
            addational_CostLabel.TabIndex = 34;
            addational_CostLabel.Text = " مصاريف اضافية";
            // 
            // bill_DateLabel
            // 
            bill_DateLabel.AutoSize = true;
            bill_DateLabel.Location = new System.Drawing.Point(371, 31);
            bill_DateLabel.Name = "bill_DateLabel";
            bill_DateLabel.Size = new System.Drawing.Size(59, 13);
            bill_DateLabel.TabIndex = 32;
            bill_DateLabel.Text = "تاريخ التوريد";
            // 
            // supplier_IDLabel
            // 
            supplier_IDLabel.AutoSize = true;
            supplier_IDLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            supplier_IDLabel.Location = new System.Drawing.Point(809, 61);
            supplier_IDLabel.Name = "supplier_IDLabel";
            supplier_IDLabel.Size = new System.Drawing.Size(61, 15);
            supplier_IDLabel.TabIndex = 30;
            supplier_IDLabel.Text = "اسم المورد";
            // 
            // emp_IDLabel
            // 
            emp_IDLabel.AutoSize = true;
            emp_IDLabel.Location = new System.Drawing.Point(801, 245);
            emp_IDLabel.Name = "emp_IDLabel";
            emp_IDLabel.Size = new System.Drawing.Size(67, 13);
            emp_IDLabel.TabIndex = 28;
            emp_IDLabel.Text = "اسم الموظف";
            // 
            // bill_in_IDLabel1
            // 
            bill_in_IDLabel1.AutoSize = true;
            bill_in_IDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            bill_in_IDLabel1.Location = new System.Drawing.Point(811, 31);
            bill_in_IDLabel1.Name = "bill_in_IDLabel1";
            bill_in_IDLabel1.Size = new System.Drawing.Size(61, 15);
            bill_in_IDLabel1.TabIndex = 54;
            bill_in_IDLabel1.Text = "رقم الفاتورة";
            // 
            // item_IDLabel
            // 
            item_IDLabel.AutoSize = true;
            item_IDLabel.Location = new System.Drawing.Point(809, 85);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(61, 13);
            item_IDLabel.TabIndex = 56;
            item_IDLabel.Text = "اسم الصنف";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(394, 90);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(36, 13);
            amountLabel.TabIndex = 62;
            amountLabel.Text = "الكمية";
            // 
            // item_amount_In_stokeLabel
            // 
            item_amount_In_stokeLabel.AutoSize = true;
            item_amount_In_stokeLabel.Location = new System.Drawing.Point(365, 117);
            item_amount_In_stokeLabel.Name = "item_amount_In_stokeLabel";
            item_amount_In_stokeLabel.Size = new System.Drawing.Size(65, 13);
            item_amount_In_stokeLabel.TabIndex = 64;
            item_amount_In_stokeLabel.Text = "الكمية الكلية";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(133, 86);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 13);
            label2.TabIndex = 70;
            label2.Text = "نسبة الخصم";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(680, 519);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 13);
            label3.TabIndex = 40;
            label3.Text = "نسبة الخصم";
            // 
            // bill_imageTextBox
            // 
            this.bill_imageTextBox.Location = new System.Drawing.Point(67, 196);
            this.bill_imageTextBox.Name = "bill_imageTextBox";
            this.bill_imageTextBox.Size = new System.Drawing.Size(249, 20);
            this.bill_imageTextBox.TabIndex = 51;
            // 
            // closedCheckBox
            // 
            this.closedCheckBox.Location = new System.Drawing.Point(67, 222);
            this.closedCheckBox.Name = "closedCheckBox";
            this.closedCheckBox.Size = new System.Drawing.Size(64, 24);
            this.closedCheckBox.TabIndex = 49;
            this.closedCheckBox.Text = "closed";
            this.closedCheckBox.UseVisualStyleBackColor = true;
            this.closedCheckBox.CheckedChanged += new System.EventHandler(this.closedCheckBox_CheckedChanged);
            // 
            // bill_NotesTextBox
            // 
            this.bill_NotesTextBox.Location = new System.Drawing.Point(67, 140);
            this.bill_NotesTextBox.Multiline = true;
            this.bill_NotesTextBox.Name = "bill_NotesTextBox";
            this.bill_NotesTextBox.Size = new System.Drawing.Size(249, 50);
            this.bill_NotesTextBox.TabIndex = 47;
            // 
            // is_returnCheckBox
            // 
            this.is_returnCheckBox.Location = new System.Drawing.Point(67, 108);
            this.is_returnCheckBox.Name = "is_returnCheckBox";
            this.is_returnCheckBox.Size = new System.Drawing.Size(63, 24);
            this.is_returnCheckBox.TabIndex = 45;
            this.is_returnCheckBox.Text = "مرتجع";
            this.is_returnCheckBox.UseVisualStyleBackColor = true;
            // 
            // bill_Cost_RemainTextBox
            // 
            this.bill_Cost_RemainTextBox.Enabled = false;
            this.bill_Cost_RemainTextBox.Location = new System.Drawing.Point(330, 516);
            this.bill_Cost_RemainTextBox.Name = "bill_Cost_RemainTextBox";
            this.bill_Cost_RemainTextBox.Size = new System.Drawing.Size(100, 20);
            this.bill_Cost_RemainTextBox.TabIndex = 43;
            // 
            // bill_cost_paidTextBox
            // 
            this.bill_cost_paidTextBox.Location = new System.Drawing.Point(330, 486);
            this.bill_cost_paidTextBox.Name = "bill_cost_paidTextBox";
            this.bill_cost_paidTextBox.Size = new System.Drawing.Size(100, 20);
            this.bill_cost_paidTextBox.TabIndex = 41;
            // 
            // bill_in_CostTextBox
            // 
            this.bill_in_CostTextBox.Enabled = false;
            this.bill_in_CostTextBox.Location = new System.Drawing.Point(556, 486);
            this.bill_in_CostTextBox.Name = "bill_in_CostTextBox";
            this.bill_in_CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.bill_in_CostTextBox.TabIndex = 39;
            // 
            // addational_Cost_NotesTextBox
            // 
            this.addational_Cost_NotesTextBox.Location = new System.Drawing.Point(513, 140);
            this.addational_Cost_NotesTextBox.Multiline = true;
            this.addational_Cost_NotesTextBox.Name = "addational_Cost_NotesTextBox";
            this.addational_Cost_NotesTextBox.Size = new System.Drawing.Size(249, 95);
            this.addational_Cost_NotesTextBox.TabIndex = 37;
            // 
            // addational_CostTextBox
            // 
            this.addational_CostTextBox.Location = new System.Drawing.Point(662, 114);
            this.addational_CostTextBox.Name = "addational_CostTextBox";
            this.addational_CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.addational_CostTextBox.TabIndex = 35;
            // 
            // bill_DateDateTimePicker
            // 
            this.bill_DateDateTimePicker.Location = new System.Drawing.Point(67, 31);
            this.bill_DateDateTimePicker.Name = "bill_DateDateTimePicker";
            this.bill_DateDateTimePicker.Size = new System.Drawing.Size(249, 20);
            this.bill_DateDateTimePicker.TabIndex = 33;
            // 
            // johnDataSet
            // 
            this.johnDataSet.DataSetName = "johnDataSet";
            this.johnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_in_detailesBindingSource
            // 
            this.order_in_detailesBindingSource.DataMember = "Order_in_detailes";
            this.order_in_detailesBindingSource.DataSource = this.johnDataSet;
            // 
            // order_in_detailesTableAdapter
            // 
            this.order_in_detailesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Order_in_detailesTableAdapter = this.order_in_detailesTableAdapter;
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
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // bill_in_IDTextBox1
            // 
            this.bill_in_IDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_in_detailesBindingSource, "Bill_in_ID", true));
            this.bill_in_IDTextBox1.Enabled = false;
            this.bill_in_IDTextBox1.Location = new System.Drawing.Point(662, 31);
            this.bill_in_IDTextBox1.Name = "bill_in_IDTextBox1";
            this.bill_in_IDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.bill_in_IDTextBox1.TabIndex = 55;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_in_detailesBindingSource, "amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(216, 86);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 63;
            // 
            // item_amount_In_stokeTextBox
            // 
            this.item_amount_In_stokeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_in_detailesBindingSource, "item_amount_In_stoke", true));
            this.item_amount_In_stokeTextBox.Location = new System.Drawing.Point(216, 114);
            this.item_amount_In_stokeTextBox.Name = "item_amount_In_stokeTextBox";
            this.item_amount_In_stokeTextBox.Size = new System.Drawing.Size(100, 20);
            this.item_amount_In_stokeTextBox.TabIndex = 65;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.supplierBindingSource;
            this.comboBox1.DisplayMember = "supplier_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(513, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 21);
            this.comboBox1.TabIndex = 66;
            this.comboBox1.ValueMember = "supplier_name";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.johnDataSetBindingSource;
            // 
            // johnDataSetBindingSource
            // 
            this.johnDataSetBindingSource.DataSource = this.johnDataSet;
            this.johnDataSetBindingSource.Position = 0;
            // 
            // Items_comboBox
            // 
            this.Items_comboBox.DataSource = this.itemsBindingSource;
            this.Items_comboBox.DisplayMember = "Item_Name";
            this.Items_comboBox.FormattingEnabled = true;
            this.Items_comboBox.Location = new System.Drawing.Point(615, 82);
            this.Items_comboBox.Name = "Items_comboBox";
            this.Items_comboBox.Size = new System.Drawing.Size(147, 21);
            this.Items_comboBox.TabIndex = 67;
            this.Items_comboBox.ValueMember = "Item_Name";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.johnDataSetBindingSource;
            // 
            // orderindetailesBindingSource
            // 
            this.orderindetailesBindingSource.DataMember = "Order_in_detailes";
            this.orderindetailesBindingSource.DataSource = this.johnDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(787, 143);
            this.dataGridView1.TabIndex = 68;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_in_detailesBindingSource, "amount", true));
            this.textBox1.Location = new System.Drawing.Point(67, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 71;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.supplierBindingSource;
            this.comboBox3.DisplayMember = "supplier_name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(513, 245);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(249, 21);
            this.comboBox3.TabIndex = 72;
            this.comboBox3.ValueMember = "supplier_name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(556, 516);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 41;
            // 
            // code_textBox
            // 
            this.code_textBox.Location = new System.Drawing.Point(513, 82);
            this.code_textBox.Name = "code_textBox";
            this.code_textBox.Size = new System.Drawing.Size(63, 20);
            this.code_textBox.TabIndex = 74;
            this.code_textBox.TextChanged += new System.EventHandler(this.code_textBox_TextChanged);
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(650, 275);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(112, 40);
            this.remove.TabIndex = 86;
            this.remove.Text = "حذف الصنف";
            this.remove.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(180, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 40);
            this.button1.TabIndex = 85;
            this.button1.Text = "طباعة الفاتورة";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // save_bill
            // 
            this.save_bill.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_bill.Location = new System.Drawing.Point(323, 275);
            this.save_bill.Name = "save_bill";
            this.save_bill.Size = new System.Drawing.Size(126, 40);
            this.save_bill.TabIndex = 83;
            this.save_bill.Text = "حفظ الفاتورة";
            this.save_bill.UseVisualStyleBackColor = true;
            // 
            // add_item
            // 
            this.add_item.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_item.Location = new System.Drawing.Point(482, 275);
            this.add_item.Name = "add_item";
            this.add_item.Size = new System.Drawing.Size(126, 40);
            this.add_item.TabIndex = 84;
            this.add_item.Text = "اضـــافـة";
            this.add_item.UseVisualStyleBackColor = true;
            // 
            // nw_order
            // 
            this.nw_order.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nw_order.Location = new System.Drawing.Point(49, 272);
            this.nw_order.Name = "nw_order";
            this.nw_order.Size = new System.Drawing.Size(125, 43);
            this.nw_order.TabIndex = 87;
            this.nw_order.Text = "فاتورة جديدة";
            this.nw_order.UseVisualStyleBackColor = true;
            // 
            // orders_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 570);
            this.Controls.Add(this.nw_order);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.save_bill);
            this.Controls.Add(this.add_item);
            this.Controls.Add(this.code_textBox);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Items_comboBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(bill_in_IDLabel1);
            this.Controls.Add(this.bill_in_IDTextBox1);
            this.Controls.Add(item_IDLabel);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(item_amount_In_stokeLabel);
            this.Controls.Add(this.item_amount_In_stokeTextBox);
            this.Controls.Add(emp_IDLabel);
            this.Controls.Add(this.bill_imageTextBox);
            this.Controls.Add(bill_imageLabel);
            this.Controls.Add(supplier_IDLabel);
            this.Controls.Add(this.closedCheckBox);
            this.Controls.Add(bill_DateLabel);
            this.Controls.Add(this.bill_NotesTextBox);
            this.Controls.Add(this.bill_DateDateTimePicker);
            this.Controls.Add(bill_NotesLabel);
            this.Controls.Add(addational_CostLabel);
            this.Controls.Add(this.is_returnCheckBox);
            this.Controls.Add(this.addational_CostTextBox);
            this.Controls.Add(addational_Cost_NotesLabel);
            this.Controls.Add(this.bill_Cost_RemainTextBox);
            this.Controls.Add(this.addational_Cost_NotesTextBox);
            this.Controls.Add(bill_Cost_RemainLabel);
            this.Controls.Add(bill_in_CostLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bill_cost_paidTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.bill_in_CostTextBox);
            this.Controls.Add(bill_cost_paidLabel);
            this.Name = "orders_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orders_in";
            this.Load += new System.EventHandler(this.orders_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_in_detailesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderindetailesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bill_imageTextBox;
        private System.Windows.Forms.CheckBox closedCheckBox;
        private System.Windows.Forms.TextBox bill_NotesTextBox;
        private System.Windows.Forms.CheckBox is_returnCheckBox;
        private System.Windows.Forms.TextBox bill_Cost_RemainTextBox;
        private System.Windows.Forms.TextBox bill_cost_paidTextBox;
        private System.Windows.Forms.TextBox bill_in_CostTextBox;
        private System.Windows.Forms.TextBox addational_Cost_NotesTextBox;
        private System.Windows.Forms.TextBox addational_CostTextBox;
        private System.Windows.Forms.DateTimePicker bill_DateDateTimePicker;
        private johnDataSet johnDataSet;
        private System.Windows.Forms.BindingSource order_in_detailesBindingSource;
        private johnDataSetTableAdapters.Order_in_detailesTableAdapter order_in_detailesTableAdapter;
        private johnDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private johnDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.TextBox bill_in_IDTextBox1;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox item_amount_In_stokeTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource johnDataSetBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private johnDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.ComboBox Items_comboBox;
        private System.Windows.Forms.BindingSource orderindetailesBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox code_textBox;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button save_bill;
        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.Button nw_order;
    }
}