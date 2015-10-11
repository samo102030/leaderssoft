using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JBS2
{
    public partial class employee : Form
    {

        BL.Employee show_emp = new BL.Employee();


        public employee()
        {
            InitializeComponent();

        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (emp_nameTextBox.MaxLength > 14 | emp_nameTextBox.MaxLength < 14)
                {
                    MessageBox.Show("رجاء ادخال الرقم القومى الصحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                return;
            }
            try
            {
                if (hire_dateDateTimePicker.Value >= DateTime.Today)
                {
                    MessageBox.Show("برجاء إدخال تاريخ التعيين الصحيح فلا يجب ان يكون فى المستقبل سيدى", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch
            {
                return;
            }
        //    try
        //    {
        //        if (emp_pictureBox.Image == null)
        //        {
        //            MessageBox.Show("سيتم الأضافة دون وضع صورة", "انتبه", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        //            johnDataSetTableAdapters.EmployeeTableAdapter Add_without_image = new johnDataSetTableAdapters.EmployeeTableAdapter();
        //            Add_without_image.Employee_wzout_img_Insert(emp_nameTextBox.Text, emp_Personal_IDTextBox.Text,
        //                                                     birthdateDateTimePicker.Value, emp_AddTextBox.Text
        //                                                    , hire_dateDateTimePicker.Value, float.Parse(sallaryTextBox.Text),
        //                                                    float.Parse(bounusTextBox.Text), phoneTextBox.Text, mobileTextBox.Text
        //                                                    , e_mailTextBox.Text, int.Parse(peneltis_day_textBox.Text),
        //            int.Parse(available_peneltis_day_textBox.Text), Notes_textBox.Text, user_NameTextBox.Text, passwordTextBox.Text, emp_type_comboBox.Text);
        //            MessageBox.Show("لقد تمت الأضافة بنجاح", "عملية الأضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        }
        //    }
        //    catch
        //    {
        //        return;
        //    }

        //    MemoryStream ms = new MemoryStream();
        //    emp_pictureBox.Image.Save(ms, emp_pictureBox.Image.RawFormat);
        //    byte[] byte_image = ms.ToArray();// the toarray function enable us to convert data stream to binary data 0,1

        //    johnDataSetTableAdapters.EmployeeTableAdapter addemp = new johnDataSetTableAdapters.EmployeeTableAdapter();
        //    addemp.Employee_AddQuery(emp_nameTextBox.Text, emp_Personal_IDTextBox.Text,
        //           birthdateDateTimePicker.Value, emp_AddTextBox.Text
        //        , hire_dateDateTimePicker.Value, float.Parse(sallaryTextBox.Text),
        //        float.Parse(bounusTextBox.Text), phoneTextBox.Text, mobileTextBox.Text
        //        , e_mailTextBox.Text, int.Parse(peneltis_day_textBox.Text),
        //        int.Parse(available_peneltis_day_textBox.Text), byte_image,
        //        Notes_textBox.Text, user_NameTextBox.Text, passwordTextBox.Text, emp_type_comboBox.Text);

        //    MessageBox.Show("لقد تمت الأضافة بنجاح", "عملية الأضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'johnDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.johnDataSet1.Employee);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login cp = new login();
            cp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void browse_emp_pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.jpg; *.png; *GIF; *PMB;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                emp_pictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.Employee_bindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.johnDataSet1);

        }

        private void delete_Click(object sender, EventArgs e)
        {
            emp_nameTextBox.Clear();
            emp_AddTextBox.Clear();
            emp_Personal_IDTextBox.Clear();
            Notes_textBox.Clear();
            mobileTextBox.Clear();
            phoneTextBox.Clear();
            peneltis_day_textBox.Clear();
            available_peneltis_day_textBox.Clear();
            e_mailTextBox.Clear();
            birthdateDateTimePicker.ResetText();
            hire_dateDateTimePicker.ResetText();

        }

        private void emp_Personal_IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // هنا بنقوله اقفلى كل لوحة المفاتيح والحروف ماعدا الارقام فقط دى الى تخليها مفتوحة  &&  
            // الجزء التانى بتاع ال 8 معناهيخلى زرار الباكسبيس متاح بحيث لو دخل رقم غلط يقدر  يمسحه تانى
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void sallaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void bounusTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void peneltis_day_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void available_peneltis_day_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void sallaryTextBox_TextChanged(object sender, EventArgs e)
        {
            double.Parse(sallaryTextBox.Text);
        }

        private void bounusTextBox_TextChanged(object sender, EventArgs e)
        {
            double.Parse(bounusTextBox.Text);
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void mobileTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

    }
}
