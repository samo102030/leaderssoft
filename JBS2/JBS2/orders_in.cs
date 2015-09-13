using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JBS2
{
    public partial class orders_in : Form
    {
        public orders_in()
        {
            InitializeComponent();
        }

        private void order_in_detailesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.order_in_detailesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.johnDataSet);

        }

        private void orders_in_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'johnDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.johnDataSet.Items);
            // TODO: This line of code loads data into the 'johnDataSet.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.johnDataSet.supplier);
            // TODO: This line of code loads data into the 'johnDataSet.Order_in_detailes' table. You can move, or remove it, as needed.
            this.order_in_detailesTableAdapter.Fill(this.johnDataSet.Order_in_detailes);

        }

        private void closedCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void item_Buy_PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void item_sale_PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void item_sale_PriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void item_Buy_PriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
           // johnDataSetTableAdapters.Order_in_detailesTableAdapter add_item = new johnDataSetTableAdapters.Order_in_detailesTableAdapter();

        }

        private void code_textBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             
        }

    }
}
