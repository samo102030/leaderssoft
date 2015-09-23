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
    public partial class brands : Form
    {
        public brands()
        {
            InitializeComponent();
        }

        private void brandBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brandBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.johnDataSet);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.brand_InsertQueryTableAdapter.Fill(this.johnDataSet.Brand_InsertQuery, brand_nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void brands_Load(object sender, EventArgs e)
        {

        }

        private void add_brand_Click(object sender, EventArgs e)
        {
            //johnDataSetTableAdapters.BrandTableAdapter addbr = new johnDataSetTableAdapters.BrandTableAdapter();
            //addbr.Brand_InsertQuery(brand_nameTextBox.Text);
        }
    }
}
