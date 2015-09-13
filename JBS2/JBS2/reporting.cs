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
    public partial class reporting : Form
    {
        public reporting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view v = new view(textBox1.Text);
            v.Show();
        }
    }
}
