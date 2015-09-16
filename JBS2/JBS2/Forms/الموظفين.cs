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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            johnDataSetTableAdapters.EmployeeTableAdapter addemp = new johnDataSetTableAdapters.EmployeeTableAdapter();
            addemp.Employee_InsertQuery(emp_nameTextBox.Text, emp_Personal_IDTextBox.Text, birthdateDateTimePicker.Value, emp_AddTextBox.Text, hire_dateDateTimePicker.Value, double.Parse(sallaryTextBox.Text), double.Parse(bounusTextBox.Text), phoneTextBox.Text, mobileTextBox.Text, e_mailTextBox.Text, int.Parse(penalties_DaysTextBox.Text), int.Parse(avaliable_Absence_DaysTextBox.Text), emp_CVTextBox.Text, notesTextBox.Text, user_NameTextBox.Text);
        }

        private void employee_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CUP cp = new CUP();
            cp.Show();
        }
    }
}
