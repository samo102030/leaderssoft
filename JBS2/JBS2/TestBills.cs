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
    public partial class TestBills : Form
    {
        public TestBills()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //int first = 0;
            //int second = 0;
            //if (Int32.TryParse(textBox2.Text, out second) && Int32.TryParse(textBox1.Text, out first))
            //    textBox3.Text = (first * second).ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox4.Text))
                textBox3.Text = ((Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)) * Convert.ToInt32(textBox4.Text)).ToString ();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox4.Text))
                textBox3.Text = ((Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)) * Convert.ToInt32(textBox4.Text)).ToString ();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox4.Text))
                textBox3.Text = ((Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)) *  Convert.ToInt32(textBox4.Text)).ToString ();
        }
    }
}
