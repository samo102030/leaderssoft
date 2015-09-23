using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace JBS2
{
    public partial class add_customers : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public add_customers()
        {
            InitializeComponent();
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridView1_RowPostPaint);
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.johnDataSet);

        }

        private void customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'johnDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.johnDataSet.customers);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.customer_UpdateQueryTableAdapter.Fill(this.johnDataSet.Customer_UpdateQuery, customer_nameToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(cUST_Personal_IDToolStripTextBox.Text, typeof(int))))), addressToolStripTextBox.Text, phoneToolStripTextBox.Text, mobileToolStripTextBox.Text, e_mailToolStripTextBox.Text, company_nameToolStripTextBox.Text, new System.Nullable<double>(((double)(System.Convert.ChangeType(accountToolStripTextBox.Text, typeof(double))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(customer_idToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void show_cust_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=john;Integrated Security=True");
            sda = new SqlDataAdapter(@"select customer_id, customer_name, CUST_Personal_ID, address, phone, Mobile, E_mail, company_name,account
                                       from customers", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void add_cust_Click(object sender, EventArgs e)
        {
            //johnDataSetTableAdapters.customersTableAdapter addcst = new johnDataSetTableAdapters.customersTableAdapter();
            //addcst.customers_InsertQuery(customer_nameTextBox.Text, int.Parse(cUST_Personal_IDTextBox.Text), addressTextBox.Text, phoneTextBox.Text, mobileTextBox.Text, e_mailTextBox.Text, company_nameTextBox.Text, double.Parse(accountTextBox.Text));
        }

        private void edite_cust_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void remove_cust_Click(object sender, EventArgs e)
        {
            //johnDataSetTableAdapters.customersTableAdapter delcu = new johnDataSetTableAdapters.customersTableAdapter();

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);


            foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(dr);
            }

            //delcu.cust_DeleteQuery(int.Parse
        }
            private void DataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            //{
            //    e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            //}

            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var rightformat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            };

            var headerBounds = new Rectangle(e.RowBounds.Right + e.RowBounds.Left - grid.RowHeadersWidth, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, rightformat);
            
 
            //var headerBounds As Rectangle = New Rectangle(e.RowBounds.Left + e.RowBounds.Right - grid.RowHeadersWidth, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
            //e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void company_nameLabel_Click(object sender, EventArgs e)
        {

        }

       

        
    }
}
