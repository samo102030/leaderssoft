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
    public partial class Items_show : Form
    {
        public Items_show()
        {
            InitializeComponent();
        }

        private void Items_show_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'johnDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.johnDataSet.Items);

        }

        private void show_items_Click(object sender, EventArgs e)
        {

        }
    }
}
