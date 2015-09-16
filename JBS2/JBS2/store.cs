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
    public partial class add_store : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public add_store()
        {
            InitializeComponent();
        }

        private void storeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void add_stores_Click(object sender, EventArgs e)
        {
            //johnDataSetTableAdapters.StoreTableAdapter addst = new johnDataSetTableAdapters.StoreTableAdapter();
            //addst.store_InsertQuery(int.Parse(store_IDTextBox.Text), store_NameTextBox.Text);
            //string store_num = store_IDTextBox .Text;
            //string store_name = store_NameTextBox.Text;
            //string[] row = { store_num, store_name };
            //store_view.Rows.Add(row);

            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=john;Integrated Security=True");
            sda = new SqlDataAdapter(@"select Store_ID,Store_Name
                                       from Store", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
          
        }

        private void select_store_Click(object sender, EventArgs e)
        {
         
            //johnDataSetTableAdapters.StoreTableAdapter selst = new johnDataSetTableAdapters.StoreTableAdapter();


            //loading_dgv.DataSource = storeBindingSource;
            //get("select * from john.store");
        
        }

        private void get(string p)
        {
            //throw new NotImplementedException();
        }

        private void fill_storeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
             //   this.storeTableAdapter.fill_store(this.johnDataSet.Store);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void add_store_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'johnDataSet2.Store' table. You can move, or remove it, as needed.
            this.storeTableAdapter.Fill(this.johnDataSet2.Store);
            // TODO: This line of code loads data into the 'johnDataSet2.Store' table. You can move, or remove it, as needed.
            this.storeTableAdapter.Fill(this.johnDataSet2.Store);
            // TODO: This line of code loads data into the 'johnDataSet1.Store' table. You can move, or remove it, as needed.
          

        }

        private void loading_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //loading_dgv.Rows.Equals(storeIDDataGridViewTextBoxColumn);
        }

        private void home_back_Click(object sender, EventArgs e)
        {
            home h2 = new home();
            h2.Show();
        }

        private void store_delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=john;Integrated Security=True");
            sda =new SqlDataAdapter(@"select Store_ID,Store_Name
                                       from Store",conn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }
    }
}
