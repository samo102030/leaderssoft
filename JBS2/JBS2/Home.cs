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
    public partial class Home_Page : Form
    {
        private static Home_Page hmp;
        // فى هذه الدلة نتحقق اذا كانت الصفحة مفتوحة ام لا فاذا كانت مفتوحة فتغلق حتى تفتح من جديد
        static void hmp_FormClosed(object Sender, FormClosedEventArgs e)
        {
            hmp = null;
        }
        // هذا حتى يمكننا من التعامل مع الصفحة الرئيسية بسهولة فى اى صفحة اخرى تف البرنامج
        public static Home_Page get_home_page
        {
            get
            {
                if (hmp == null)
                {
                    hmp = new Home_Page();
                    hmp.FormClosed+=new FormClosedEventHandler(hmp_FormClosed);
                }
                return hmp;
            }
        }

        public Home_Page()
        {
            InitializeComponent();
            //this hmp represent the homepage and we will deal with it as the homepage form

            if (hmp == null)
                hmp = this;

            this.الاصنافToolStripMenuItem.Available = false;
            this.الطلبياتToolStripMenuItem.Available = false;
            this.عملاءوموردينToolStripMenuItem.Available = false;
            this.المصانعToolStripMenuItem.Available = false;
            this.المخازنToolStripMenuItem.Available = false;
            this.تقاريربيعToolStripMenuItem.Available = false;
            this.الخزينةToolStripMenuItem.Available = false;
            this.الموظفينToolStripMenuItem.Available = false;
            this.مساعدةToolStripMenuItem.Available = false;
            this.إنشاءنسخةإحتياطيةToolStripMenuItem.Available = false;
            this.إسترجاعنسخةنحفوظةToolStripMenuItem.Available = false;
            this.testToolStripMenuItem.Available = false;
            
        }

        private void brandBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           // this.brandBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.johnDataSet);

        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.johnDataSet);

        }

        private void employeeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.johnDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'johnDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.johnDataSet.Employee);

        }

       
        private void الواردةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            orders_in orn = new orders_in();
            orn.Show();
          orn.Closing += (sende, args) =>
          
              this.Show();
           
        }

        private void اضافةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //add_customers childForm = new add_customers();
            //childForm.Parent = this;
            //childForm.WindowState = FormWindowState.Maximized;
            //childForm.Show(); 
            //this.Hide();
            //add_customers addcu = new add_customers();
            //addcu.Show();
            //addcu.Closing += (sende, args) =>

            // this.Show();
            this.Hide();

            add_customers adcst = new add_customers();
            adcst.Show();
            adcst.Closing += (sende, args) =>

              this.Show();
        }

        private void الصادرةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            orders_out orou = new orders_out();
            orou.Show();
            orou.Closing += (sende, args) =>

             this.Show();

           

        }

        private void اضافةمخزنجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_store addst = new add_store();
            addst.Show();
            addst.Closing += (sende, args) =>

             this.Show();
        }

        private void اضافةصنفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Items addit = new Items();
            addit.Show();
        }

        private void تقريرعنالمخازنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            storereport str = new storereport();
            str.Show();
        }

        private void قائمةبأسعارالاصتافToolStripMenuItem_Click(object sender, EventArgs e)
        {

            testitemsrep tir = new testitemsrep();
            tir.Show();

        }


      

        void عرضالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Items_show itsh = new Items_show();
            itsh.Show();

        }

        private void اضافةمصنعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brands br = new brands();
            br.Show();
        }

        private void عميلاجلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            orders_out orou = new orders_out();
            orou.Show();
            orou.Closing += (sende, args) =>

             this.Show();
        }

   

        private void عرضالفواتيرToolStripMenuItem_Click(object sender, EventArgs e)
        {

            reporting repo = new reporting();
            repo.Show();
            
        }

        login nwlogin;
        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nwlogin == null)
            {
                nwlogin = new login();
                nwlogin.MdiParent = this;
                nwlogin.FormClosed += new FormClosedEventHandler(nwlogin_FormClosed);
                nwlogin.Show();
            }
        }

        void nwlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            nwlogin = null;
        }
        TestBills tbs;
        private void tESTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (tbs == null)
            {
                tbs = new TestBills();
                tbs.MdiParent = this;
                tbs.FormClosed += new FormClosedEventHandler(tbs_FormClosed);

                tbs.Show();
            }
            else
                tbs.Activate();
        }

        private void tbs_FormClosed(object sender, FormClosedEventArgs e)
        {

            tbs = null;
            //	throw new NotImplementedException();
        }
      
    }
}
