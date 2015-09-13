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
    public partial class CUP : Form
    {
        public CUP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            johnDataSetTableAdapters.EmployeeTableAdapter up_pass = new johnDataSetTableAdapters.EmployeeTableAdapter();
            up_pass.Empl_pass_UpdateQuery(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
        }

    }
}
