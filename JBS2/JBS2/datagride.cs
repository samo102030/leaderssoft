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
    public partial class datagride : Form
    {
        public datagride()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataGridView idt = new DataGridView();
            //idt.Container.Add(itemsdataGridView, nametextBox1.Text);
            //itemsdataGridView.Rows[0].Cells["name"].Value = nametextBox1.Text;
            //itemsdataGridView.Rows[0].Cells["adress"].Value = nametextBox2.Text;
            string n1 = nametextBox1.Text;
            string adr = nametextBox2.Text;
            string[] row = { n1, adr };
            itemsdataGridView.Rows.Add(row);
        }
    }
}
