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
    public partial class so7t : Form
    {
        public so7t()
        {
            InitializeComponent();
        }

        private void so7t_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'johnDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.johnDataSet.Employee);

        }
    }
}
