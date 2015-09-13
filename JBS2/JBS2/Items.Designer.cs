namespace JBS2
{
    partial class Items
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
            System.Windows.Forms.Label item_NameLabel;
            System.Windows.Forms.Label item_MinLabel;
            System.Windows.Forms.Label item_brandLabel;
            System.Windows.Forms.Label item_amountLabel;
            System.Windows.Forms.Label item_coast_saleLabel;
            System.Windows.Forms.Label item_storeLabel;
            System.Windows.Forms.Label item_private_saleLabel;
            System.Windows.Forms.Label item_genral_saleLabel;
            System.Windows.Forms.Label item_IDLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.johnDataSet = new JBS2.johnDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new JBS2.johnDataSetTableAdapters.ItemsTableAdapter();
            this.tableAdapterManager = new JBS2.johnDataSetTableAdapters.TableAdapterManager();
            this.brandTableAdapter = new JBS2.johnDataSetTableAdapters.BrandTableAdapter();
            this.storeTableAdapter = new JBS2.johnDataSetTableAdapters.StoreTableAdapter();
            this.item_MinTextBox = new System.Windows.Forms.TextBox();
            this.item_amountTextBox = new System.Windows.Forms.TextBox();
            this.item_coast_saleTextBox = new System.Windows.Forms.TextBox();
            this.item_private_saleTextBox = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.item_NameTextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.add_item = new System.Windows.Forms.Button();
            this.show_items = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.update_item = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.item_IDTextBox = new System.Windows.Forms.TextBox();
            item_NameLabel = new System.Windows.Forms.Label();
            item_MinLabel = new System.Windows.Forms.Label();
            item_brandLabel = new System.Windows.Forms.Label();
            item_amountLabel = new System.Windows.Forms.Label();
            item_coast_saleLabel = new System.Windows.Forms.Label();
            item_storeLabel = new System.Windows.Forms.Label();
            item_private_saleLabel = new System.Windows.Forms.Label();
            item_genral_saleLabel = new System.Windows.Forms.Label();
            item_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // item_NameLabel
            // 
            item_NameLabel.AutoSize = true;
            item_NameLabel.Location = new System.Drawing.Point(312, 19);
            item_NameLabel.Name = "item_NameLabel";
            item_NameLabel.Size = new System.Drawing.Size(61, 13);
            item_NameLabel.TabIndex = 3;
            item_NameLabel.Text = "اسم الصنف";
            // 
            // item_MinLabel
            // 
            item_MinLabel.AutoSize = true;
            item_MinLabel.Location = new System.Drawing.Point(266, 48);
            item_MinLabel.Name = "item_MinLabel";
            item_MinLabel.Size = new System.Drawing.Size(107, 13);
            item_MinLabel.TabIndex = 5;
            item_MinLabel.Text = "الحد الادنى من الصنف";
            // 
            // item_brandLabel
            // 
            item_brandLabel.AutoSize = true;
            item_brandLabel.Location = new System.Drawing.Point(293, 71);
            item_brandLabel.Name = "item_brandLabel";
            item_brandLabel.Size = new System.Drawing.Size(80, 13);
            item_brandLabel.TabIndex = 7;
            item_brandLabel.Text = "المصنع او المورد";
            // 
            // item_amountLabel
            // 
            item_amountLabel.AutoSize = true;
            item_amountLabel.Location = new System.Drawing.Point(206, 45);
            item_amountLabel.Name = "item_amountLabel";
            item_amountLabel.Size = new System.Drawing.Size(61, 13);
            item_amountLabel.TabIndex = 9;
            item_amountLabel.Text = "كمية الصنف";
            // 
            // item_coast_saleLabel
            // 
            item_coast_saleLabel.AutoSize = true;
            item_coast_saleLabel.Location = new System.Drawing.Point(167, 19);
            item_coast_saleLabel.Name = "item_coast_saleLabel";
            item_coast_saleLabel.Size = new System.Drawing.Size(96, 13);
            item_coast_saleLabel.TabIndex = 11;
            item_coast_saleLabel.Text = "سعر التوريد للقطعة";
            // 
            // item_storeLabel
            // 
            item_storeLabel.AutoSize = true;
            item_storeLabel.Location = new System.Drawing.Point(334, 101);
            item_storeLabel.Name = "item_storeLabel";
            item_storeLabel.Size = new System.Drawing.Size(39, 13);
            item_storeLabel.TabIndex = 13;
            item_storeLabel.Text = "المخزن";
            // 
            // item_private_saleLabel
            // 
            item_private_saleLabel.AutoSize = true;
            item_private_saleLabel.Location = new System.Drawing.Point(189, 71);
            item_private_saleLabel.Name = "item_private_saleLabel";
            item_private_saleLabel.Size = new System.Drawing.Size(78, 13);
            item_private_saleLabel.TabIndex = 15;
            item_private_saleLabel.Text = "سعر بيع الجملة";
            // 
            // item_genral_saleLabel
            // 
            item_genral_saleLabel.AutoSize = true;
            item_genral_saleLabel.Location = new System.Drawing.Point(159, 97);
            item_genral_saleLabel.Name = "item_genral_saleLabel";
            item_genral_saleLabel.Size = new System.Drawing.Size(108, 13);
            item_genral_saleLabel.TabIndex = 17;
            item_genral_saleLabel.Text = "سعر البيع لللمستهلك";
            // 
            // item_IDLabel
            // 
            item_IDLabel.AutoSize = true;
            item_IDLabel.Location = new System.Drawing.Point(870, 165);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(54, 13);
            item_IDLabel.TabIndex = 28;
            item_IDLabel.Text = "كود الصنف";
            // 
            // johnDataSet
            // 
            this.johnDataSet.DataSetName = "johnDataSet";
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
            this.tableAdapterManager.BrandTableAdapter = this.brandTableAdapter;
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
            this.tableAdapterManager.StoreTableAdapter = this.storeTableAdapter;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.typesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JBS2.johnDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // item_MinTextBox
            // 
            this.item_MinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_Min", true));
            this.item_MinTextBox.Location = new System.Drawing.Point(153, 45);
            this.item_MinTextBox.Name = "item_MinTextBox";
            this.item_MinTextBox.Size = new System.Drawing.Size(69, 20);
            this.item_MinTextBox.TabIndex = 6;
            // 
            // item_amountTextBox
            // 
            this.item_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_amount", true));
            this.item_amountTextBox.Location = new System.Drawing.Point(16, 45);
            this.item_amountTextBox.Name = "item_amountTextBox";
            this.item_amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.item_amountTextBox.TabIndex = 10;
            // 
            // item_coast_saleTextBox
            // 
            this.item_coast_saleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_coast_sale", true));
            this.item_coast_saleTextBox.Location = new System.Drawing.Point(16, 19);
            this.item_coast_saleTextBox.Name = "item_coast_saleTextBox";
            this.item_coast_saleTextBox.Size = new System.Drawing.Size(100, 20);
            this.item_coast_saleTextBox.TabIndex = 12;
            // 
            // item_private_saleTextBox
            // 
            this.item_private_saleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_private_sale", true));
            this.item_private_saleTextBox.Location = new System.Drawing.Point(16, 71);
            this.item_private_saleTextBox.Name = "item_private_saleTextBox";
            this.item_private_saleTextBox.Size = new System.Drawing.Size(100, 20);
            this.item_private_saleTextBox.TabIndex = 16;
            // 
            // c
            // 
            this.c.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_genral_sale", true));
            this.c.Location = new System.Drawing.Point(16, 97);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 20);
            this.c.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.brandBindingSource;
            this.comboBox1.DisplayMember = "Brand_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "Brand_name";
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "Brand";
            this.brandBindingSource.DataSource = this.johnDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.storeBindingSource;
            this.comboBox2.DisplayMember = "Store_Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(19, 98);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 21);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.ValueMember = "Store_Name";
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "Store";
            this.storeBindingSource.DataSource = this.johnDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.item_NameTextBox1);
            this.groupBox1.Controls.Add(item_storeLabel);
            this.groupBox1.Controls.Add(item_NameLabel);
            this.groupBox1.Controls.Add(item_brandLabel);
            this.groupBox1.Controls.Add(this.item_MinTextBox);
            this.groupBox1.Controls.Add(item_MinLabel);
            this.groupBox1.Location = new System.Drawing.Point(543, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 131);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // item_NameTextBox1
            // 
            this.item_NameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_Name", true));
            this.item_NameTextBox1.Location = new System.Drawing.Point(19, 19);
            this.item_NameTextBox1.Name = "item_NameTextBox1";
            this.item_NameTextBox1.Size = new System.Drawing.Size(203, 20);
            this.item_NameTextBox1.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(item_coast_saleLabel);
            this.groupBox2.Controls.Add(this.item_amountTextBox);
            this.groupBox2.Controls.Add(this.item_coast_saleTextBox);
            this.groupBox2.Controls.Add(item_amountLabel);
            this.groupBox2.Controls.Add(item_private_saleLabel);
            this.groupBox2.Controls.Add(this.item_private_saleTextBox);
            this.groupBox2.Controls.Add(item_genral_saleLabel);
            this.groupBox2.Controls.Add(this.c);
            this.groupBox2.Location = new System.Drawing.Point(92, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(278, 131);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // add_item
            // 
            this.add_item.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.add_item.Location = new System.Drawing.Point(490, 187);
            this.add_item.Name = "add_item";
            this.add_item.Size = new System.Drawing.Size(116, 49);
            this.add_item.TabIndex = 24;
            this.add_item.Text = "اضافة الصنف";
            this.add_item.UseVisualStyleBackColor = true;
            this.add_item.Click += new System.EventHandler(this.add_item_Click);
            // 
            // show_items
            // 
            this.show_items.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.show_items.Location = new System.Drawing.Point(345, 187);
            this.show_items.Name = "show_items";
            this.show_items.Size = new System.Drawing.Size(122, 50);
            this.show_items.TabIndex = 25;
            this.show_items.Text = "عرض الاصناف";
            this.show_items.UseVisualStyleBackColor = true;
            this.show_items.Click += new System.EventHandler(this.show_items_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Location = new System.Drawing.Point(10, 261);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Size = new System.Drawing.Size(938, 237);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            this.dataGridView2.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView2_RowPostPaint);
            // 
            // update_item
            // 
            this.update_item.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.update_item.Location = new System.Drawing.Point(175, 187);
            this.update_item.Name = "update_item";
            this.update_item.Size = new System.Drawing.Size(149, 50);
            this.update_item.TabIndex = 27;
            this.update_item.Text = "تعديل بينات صنف";
            this.update_item.UseVisualStyleBackColor = true;
            this.update_item.Click += new System.EventHandler(this.update_item_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(808, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "label1";
            // 
            // item_IDTextBox
            // 
            this.item_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_ID", true));
            this.item_IDTextBox.Enabled = false;
            this.item_IDTextBox.Location = new System.Drawing.Point(665, 165);
            this.item_IDTextBox.Name = "item_IDTextBox";
            this.item_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.item_IDTextBox.TabIndex = 29;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(968, 536);
            this.Controls.Add(item_IDLabel);
            this.Controls.Add(this.item_IDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update_item);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.show_items);
            this.Controls.Add(this.add_item);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Items";
            this.Text = "الاصناف";
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private johnDataSet johnDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private johnDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private johnDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox item_MinTextBox;
        private System.Windows.Forms.TextBox item_amountTextBox;
        private System.Windows.Forms.TextBox item_coast_saleTextBox;
        private System.Windows.Forms.TextBox item_private_saleTextBox;
        private System.Windows.Forms.TextBox c;
        private johnDataSetTableAdapters.StoreTableAdapter storeTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private johnDataSetTableAdapters.BrandTableAdapter brandTableAdapter;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.Button show_items;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button update_item;
        private System.Windows.Forms.TextBox item_NameTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox item_IDTextBox;
    }
}