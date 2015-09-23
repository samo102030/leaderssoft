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
    public partial class Items_Details2 : Form
    {
        public Items_Details2()
        {
            InitializeComponent();
        }

        private void Items_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'johnDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.johnDataSet.Items);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //johnDataSetTableAdapters.ItemsTableAdapter get_brand = new johnDataSetTableAdapters.ItemsTableAdapter();
            //get_brand.Fill(itemsBindingSource1);
        }
    }
}
