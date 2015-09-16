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
    public partial class suppliers : Form
    {
        public suppliers()
        {
            InitializeComponent();
        }

        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.johnDataSet);

        }

        private void supp_iers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'johnDataSet.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.johnDataSet.supplier);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                DialogResult addsup = MessageBox.Show("هل تريد اضافة هذا المورد", "Exit", MessageBoxButtons.OKCancel);
            }
            johnDataSetTableAdapters.supplierTableAdapter supist = new johnDataSetTableAdapters.supplierTableAdapter();
            supist.Sub_insert(supplier_nameTextBox.Text, int.Parse(sup_Personal_IDTextBox.Text), addressTextBox.Text, phoneTextBox.Text, mobileTextBox.Text, e_mailTextBox.Text, agentTextBox.Text, agent_mobileTextBox.Text, double.Parse(accountTextBox.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                DialogResult edite = MessageBox.Show("هل تريد تعديل بيانات هذا المورد", "Exit", MessageBoxButtons.OKCancel); 
            }
            johnDataSetTableAdapters.supplierTableAdapter editesp = new johnDataSetTableAdapters.supplierTableAdapter();
            editesp.supplier_UpdateQuery(supplier_nameTextBox.Text, int.Parse(sup_Personal_IDTextBox.Text), addressTextBox.Text, phoneTextBox.Text, mobileTextBox.Text, e_mailTextBox.Text, agentTextBox.Text, agent_mobileTextBox.Text, double.Parse(accountTextBox.Text), int.Parse(supplier_idTextBox.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
