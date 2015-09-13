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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'johnDataSet.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.johnDataSet.supplier);
            // TODO: This line of code loads data into the 'johnDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.johnDataSet.customers);

        }
    }
}
