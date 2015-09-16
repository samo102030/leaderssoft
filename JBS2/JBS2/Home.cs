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
        public Home_Page()
        {
            InitializeComponent();
            this.الاصنافToolStripMenuItem.Enabled = false;
            this.الطلبياتToolStripMenuItem.Enabled = false;
            this.عملاءوموردينToolStripMenuItem.Enabled = false;
            this.المصانعToolStripMenuItem.Enabled = false;
            this.المخازنToolStripMenuItem.Enabled = false;
            this.تقاريربيعToolStripMenuItem.Enabled = false;
            this.الخزينةToolStripMenuItem.Enabled = false;
            this.الموظفينToolStripMenuItem.Enabled = false;
            this.مساعدةToolStripMenuItem.Enabled = false;
            this.إنشاءنسخةإحتياطيةToolStripMenuItem.Enabled = false;
            this.إسترجاعنسخةنحفوظةToolStripMenuItem.Enabled = false;
            
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

        TestBills tbs;
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
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

        private

void  tbs_FormClosed(object sender, FormClosedEventArgs e)
{
    tbs = null;
 //	throw new NotImplementedException();
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

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login nwlogin = new login();
            nwlogin.ShowDialog();
        }

        
      
    }
}
