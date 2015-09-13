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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
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

        private void emp_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void emp_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emp_nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void emp_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emp_Personal_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void emp_Personal_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthdateLabel_Click(object sender, EventArgs e)
        {

        }

        private void birthdateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void emp_AddLabel_Click(object sender, EventArgs e)
        {

        }

        private void emp_AddTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hire_dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void hire_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sallaryLabel_Click(object sender, EventArgs e)
        {

        }

        private void sallaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bounusLabel_Click(object sender, EventArgs e)
        {

        }

        private void bounusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mobileLabel_Click(object sender, EventArgs e)
        {

        }

        private void mobileTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void e_mailLabel_Click(object sender, EventArgs e)
        {

        }

        private void e_mailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void penalties_DaysLabel_Click(object sender, EventArgs e)
        {

        }

        private void penalties_DaysTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void avaliable_Absence_DaysLabel_Click(object sender, EventArgs e)
        {

        }

        private void avaliable_Absence_DaysTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emp_CVLabel_Click(object sender, EventArgs e)
        {

        }

        private void emp_CVTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void notesLabel_Click(object sender, EventArgs e)
        {

        }

        private void notesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void user_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void الموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            employee em = new employee();
            em.Show();
            em.Closing += (sende, args) =>

               this.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
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

         

        private void testToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void عرضالفواتيرToolStripMenuItem_Click(object sender, EventArgs e)
        {

            reporting repo = new reporting();
            repo.Show();
            
        }

      
    }
}
