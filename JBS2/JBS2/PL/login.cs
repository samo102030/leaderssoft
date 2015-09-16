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
                MessageBox.Show("لقد تم تسجيل الدخول بنجاح");
            }
            else
            {
                MessageBox.Show("فشل فى تسجيل الدخول ");
            }
        }

    }
}
