namespace JBS2
{
    partial class Items_show
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.johnDataSet = new JBS2.johnDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new JBS2.johnDataSetTableAdapters.ItemsTableAdapter();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itembrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcoastsaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemstoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemprivatesaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemgenralsaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_item = new System.Windows.Forms.Button();
            this.show_items = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoGenerateColumns = false;
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
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemMinDataGridViewTextBoxColumn,
            this.itembrandDataGridViewTextBoxColumn,
            this.itemamountDataGridViewTextBoxColumn,
            this.itemcoastsaleDataGridViewTextBoxColumn,
            this.itemstoreDataGridViewTextBoxColumn,
            this.itemprivatesaleDataGridViewTextBoxColumn,
            this.itemgenralsaleDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.itemsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Location = new System.Drawing.Point(12, 236);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Size = new System.Drawing.Size(938, 237);
            this.dataGridView2.TabIndex = 27;
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
            // update_item
            // 
            this.update_item.Location = new System.Drawing.Point(379, 197);
            this.update_item.Name = "update_item";
            this.update_item.Size = new System.Drawing.Size(108, 24);
            this.update_item.TabIndex = 29;
            this.update_item.Text = "تعديل بينات صنف";
            this.update_item.UseVisualStyleBackColor = true;
            // 
            // show_items
            // 
            this.show_items.Location = new System.Drawing.Point(504, 198);
            this.show_items.Name = "show_items";
            this.show_items.Size = new System.Drawing.Size(81, 25);
            this.show_items.TabIndex = 28;
            this.show_items.Text = "عرض الاصناف";
            this.show_items.UseVisualStyleBackColor = true;
            this.show_items.Click += new System.EventHandler(this.show_items_Click);
            // 
            // Items_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 558);
            this.Controls.Add(this.update_item);
            this.Controls.Add(this.show_items);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Items_show";
            this.Text = "Items_show";
            this.Load += new System.EventHandler(this.Items_show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
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
        private System.Windows.Forms.Button update_item;
        private System.Windows.Forms.Button show_items;
    }
}