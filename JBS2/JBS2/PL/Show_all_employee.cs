using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JBS2.PL
{
    public partial class Show_all_employee : Form
    {
        BL.Employee Get_emp = new BL.Employee();
        public Show_all_employee()
        {
            InitializeComponent();
            Employee_comboBox.DataSource = Get_emp.Get_all_employee();
            Employee_comboBox.DisplayMember = "emp_name";
            Employee_comboBox.ValueMember = "emp_ID";


        }



        private void Show_all_employee_Load(object sender, EventArgs e)
        {
            //    // TODO: This line of code loads data into the 'johnDataSet.Employee' table. You can move, or remove it, as needed.
            //    this.employeeTableAdapter.Fill(this.johnDataSet.Employee);
            //    // TODO: This line of code loads data into the 'johnDataSet.Employee' table. You can move, or remove it, as needed.
            //    this.employeeTableAdapter.Fill(this.johnDataSet.Employee);

        }

        private void brows_empPic_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.jpg; *.png; *GIF; *PMB;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Emp_pictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void Choose_emp_button_Click(object sender, EventArgs e)
        {
            Employee_list Emp_l = new Employee_list();
            Emp_l.ShowDialog();
            if (Emp_l.DG_Employee.CurrentRow.Cells[13].Value is DBNull)
            {
                MessageBox.Show("هذاالموظف ليس له صورة", "خطأ فى تحميل الصورة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.emp_IDTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[0].Value.ToString();
                this.emp_nameTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[1].Value.ToString();
                this.emp_Personal_IDTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[2].Value.ToString();
                this.birthdateDateTimePicker.Text = Emp_l.DG_Employee.CurrentRow.Cells[3].Value.ToString();
                this.emp_AddTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[4].Value.ToString();
                this.hire_dateDateTimePicker.Text = Emp_l.DG_Employee.CurrentRow.Cells[5].Value.ToString();
                this.sallaryTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[6].Value.ToString();
                this.bounusTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[7].Value.ToString();
                this.phoneTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[8].Value.ToString();
                this.mobileTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[9].Value.ToString();
                this.e_mailTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[10].Value.ToString();
                this.penalties_DaysTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[11].Value.ToString();
                this.avaliable_Absence_DaysTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[12].Value.ToString();
                this.notesTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[14].Value.ToString();
                this.emp_User_nameTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[15].Value.ToString();
                this.user_PwdTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[16].Value.ToString();
                //this.emp_typeTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[17].Value.ToString();
                Emp_pictureBox.Image = null;
                return;
            }

            this.emp_IDTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[0].Value.ToString();
            this.emp_nameTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[1].Value.ToString();
            this.emp_Personal_IDTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[2].Value.ToString();
            this.birthdateDateTimePicker.Text = Emp_l.DG_Employee.CurrentRow.Cells[3].Value.ToString();
            this.emp_AddTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[4].Value.ToString();
            this.hire_dateDateTimePicker.Text = Emp_l.DG_Employee.CurrentRow.Cells[5].Value.ToString();
            this.sallaryTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[6].Value.ToString();
            this.bounusTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[7].Value.ToString();
            this.phoneTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[8].Value.ToString();
            this.mobileTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[9].Value.ToString();
            this.e_mailTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[10].Value.ToString();
            this.penalties_DaysTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[11].Value.ToString();
            this.avaliable_Absence_DaysTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[12].Value.ToString();
            byte[] Emp_pic = (byte[])Emp_l.DG_Employee.CurrentRow.Cells[13].Value;
            MemoryStream ms = new MemoryStream(Emp_pic);
            Emp_pictureBox.Image = Image.FromStream(ms);

            this.notesTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[14].Value.ToString();
            this.emp_User_nameTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[15].Value.ToString();
            this.user_PwdTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[16].Value.ToString();
            // this.emp_typeTextBox.Text = Emp_l.DG_Employee.CurrentRow.Cells[17].Value.ToString();


        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
           DialogResult close_windo= MessageBox.Show("هل تريد الخروج من هذه النافذة", "استعلام", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
           if (close_windo == DialogResult.OK)
           {
               Close();
           }
           else
               return;
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            int ID;
            ID = int.Parse(emp_IDTextBox.Text);

            //try
            //{
            //    byte[] Emp_pic;
            //    if (Emp_pictureBox.Image == null)
            //    {
            //        Emp_pic = new byte[0];
                   
            //        DialogResult update_dialoge=MessageBox.Show("سيتم التعديل دون وضع صورة", "انتبه", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //        if (update_dialoge == DialogResult.OK)
            //        {

            //            johnDataSetTableAdapters.EmployeeTableAdapter edit_emp = new johnDataSetTableAdapters.EmployeeTableAdapter();
            //            edit_emp.Update_emp_without_image(emp_nameTextBox.Text, emp_Personal_IDTextBox.Text, birthdateDateTimePicker.Value,
            //                emp_AddTextBox.Text, hire_dateDateTimePicker.Value, double.Parse(sallaryTextBox.Text), double.Parse(bounusTextBox.Text),
            //                phoneTextBox.Text, mobileTextBox.Text, e_mailTextBox.Text, int.Parse(penalties_DaysTextBox.Text), int.Parse(avaliable_Absence_DaysTextBox.Text),
            //                notesTextBox.Text, emp_User_nameTextBox.Text, user_PwdTextBox.Text, Type_comboBox.Text, ID);

            //            MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            Employee_list Empl = new Employee_list();
            //            Empl.DG_Employee.DataSource = Get_emp.Get_all_employee();
            //        }
            //        else
            //            return;
            //    }

            //    //}
            //    //}
            //    else
            //    {
            //        MemoryStream ms = new MemoryStream();
            //        Emp_pictureBox.Image.Save(ms, Emp_pictureBox.Image.RawFormat);
            //        Emp_pic = ms.ToArray();// the toarray function enable us to convert data stream to binary data 0,1

            //        johnDataSetTableAdapters.EmployeeTableAdapter edit_emp = new johnDataSetTableAdapters.EmployeeTableAdapter();
            //        edit_emp.Updet_emp_wz_img(emp_nameTextBox.Text, emp_Personal_IDTextBox.Text, birthdateDateTimePicker.Value,
            //            emp_AddTextBox.Text, hire_dateDateTimePicker.Value, double.Parse(sallaryTextBox.Text),
            //            double.Parse(bounusTextBox.Text), phoneTextBox.Text, mobileTextBox.Text, e_mailTextBox.Text, int.Parse(penalties_DaysTextBox.Text),
            //            int.Parse(avaliable_Absence_DaysTextBox.Text), Emp_pic, notesTextBox.Text, emp_User_nameTextBox.Text, user_PwdTextBox.Text,
            //            Type_comboBox.Text, ID);

            //        MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        Employee_list Empl = new Employee_list();
            //        Empl.DG_Employee.DataSource = Get_emp.Get_all_employee();
            //    }
            //}
            //catch
            //{
            //    return;
            //}

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {

            DialogResult result;
            result = MessageBox.Show("هل تريد فعلا حذف " + "\n" + "أ/" + emp_nameTextBox.Text, "حذف موظف", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //if (result == DialogResult.OK)
            //{
            //    johnDataSetTableAdapters.EmployeeTableAdapter del_emp = new johnDataSetTableAdapters.EmployeeTableAdapter();

            //    del_emp.Employee_Delete(int.Parse(emp_IDTextBox.Text));
            //    Emp_pictureBox.Image = null;
            //    emp_IDTextBox.Clear();
            //    emp_nameTextBox.Clear();
            //    emp_Personal_IDTextBox.Clear();
            //    birthdateDateTimePicker.ResetText();
            //    emp_AddTextBox.Clear();
            //    hire_dateDateTimePicker.ResetText();
            //    sallaryTextBox.Clear();
            //    bounusTextBox.Clear();
            //    phoneTextBox.Clear();
            //    mobileTextBox.Clear();
            //    e_mailTextBox.Clear();
            //    penalties_DaysTextBox.Clear();
            //    avaliable_Absence_DaysTextBox.Clear();
            //    notesTextBox.Clear();
            //    user_PwdTextBox.Clear();
            //    emp_User_nameTextBox.Clear();
            //    Type_comboBox.ResetText();
            //    MessageBox.Show("لقد تمت عملية الحذف بنجاح ", "حذف موظف", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            //}
            //else
            //{
            //    return;
            //}
        }

    }
}
    

