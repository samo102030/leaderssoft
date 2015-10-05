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
    public partial class login : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public login()
        {
            InitializeComponent();
        }


        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {

            DataTable Dt = log.LOGIN(tex_User_Name.Text, tex_userpwd.Text);
            if (Dt.Rows.Count > 0)
            {
                MessageBox.Show("مرحبا " + tex_User_Name.Text +"\n"+"لقد تم تسجيلك بنجاح "); //it was for test the button and now we didn't need it any more
                this.Close();
                
                Home_Page.get_home_page.الاصنافToolStripMenuItem.Available = true;
                Home_Page.get_home_page.الخزينةToolStripMenuItem.Available = true;
                Home_Page.get_home_page.الصادرةToolStripMenuItem.Available = true;
                Home_Page.get_home_page.الطلبياتToolStripMenuItem.Available = true;
                Home_Page.get_home_page.المخازنToolStripMenuItem.Available = true;
                Home_Page.get_home_page.المصانعToolStripMenuItem.Available = true;
                Home_Page.get_home_page.الموظفينToolStripMenuItem.Available = true;
                Home_Page.get_home_page.الواردةToolStripMenuItem.Available = true;
                Home_Page.get_home_page.تسجيلالدخولToolStripMenuItem.Available = true;
                Home_Page.get_home_page.ملفToolStripMenuItem.Available = true;
                Home_Page.get_home_page.مساعدةToolStripMenuItem.Available = true;
                Home_Page.get_home_page.إنشاءنسخةإحتياطيةToolStripMenuItem.Available = true;
                Home_Page.get_home_page.عملاءوموردينToolStripMenuItem.Available = true;
                Home_Page.get_home_page.إسترجاعنسخةنحفوظةToolStripMenuItem.Available = true;

               
            }
            else
            {
                MessageBox.Show("فشل فى تسجيل الدخول برجاء المحاولة مرة اخرى مع التاكد من اسم المستخدم وكلمة المرور ");
            }
        }

    }
}
