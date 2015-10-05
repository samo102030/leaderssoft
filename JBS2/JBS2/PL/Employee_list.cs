using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JBS2.PL
{
    public partial class Employee_list : Form
    {
        BL.Employee All_Emp = new BL.Employee();
        public Employee_list()
        {
            InitializeComponent();
            this.DG_Employee.DataSource = All_Emp.Get_all_employee();
            this.DG_Employee.Columns[0].Visible = false;
            this.DG_Employee.Columns[3].Visible = false;
            this.DG_Employee.Columns[4].Visible = false;
            this.DG_Employee.Columns[7].Visible = false;
            this.DG_Employee.Columns[8].Visible = false;
            this.DG_Employee.Columns[10].Visible = false;
            this.DG_Employee.Columns[12].Visible = false;
            this.DG_Employee.Columns[13].Visible = false;
            this.DG_Employee.Columns[14].Visible = false;
            this.DG_Employee.Columns[1].HeaderText = "أسم الموظف";
            this.DG_Employee.Columns[2].HeaderText = "الرقم القومى";
            this.DG_Employee.Columns[5].HeaderText = "تاريخ التعيين";
            this.DG_Employee.Columns[6].HeaderText = "المرتب";
            this.DG_Employee.Columns[9].HeaderText = "المحمول";
            this.DG_Employee.Columns[11].HeaderText = "عدد أيام الغياب";
            this.DG_Employee.Columns[15].HeaderText = "أسم المستخدم";
            this.DG_Employee.Columns[16].HeaderText = "كلمة المرور";
        }

        private void DG_Employee_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
