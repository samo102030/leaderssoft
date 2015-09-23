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
    public partial class Items : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=john;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        SqlCommand scm = new SqlCommand();
        DataTable dt;

        public Items()
        {
            InitializeComponent();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.johnDataSet);

        }

        private void Items_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'johnDataSet.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.johnDataSet.Brand);
            // TODO: This line of code loads data into the 'johnDataSet.Store' table. You can move, or remove it, as needed.
            this.storeTableAdapter.Fill(this.johnDataSet.Store);
            // TODO: This line of code loads data into the 'johnDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.johnDataSet.Items);
            scm.Connection = con;
            timer1.Start();

        }

        private void add_item_Click(object sender, EventArgs e)
        {
            //johnDataSetTableAdapters.ItemsTableAdapter additem = new johnDataSetTableAdapters.ItemsTableAdapter();
            //additem.test_item_InsertQuery(item_NameTextBox.Text, int.Parse(item_MinTextBox.Text), double.Parse(item_coast_saleTextBox.Text), int.Parse(item_amountTextBox.Text), double.Parse(item_private_saleTextBox.Text), double.Parse(item_genral_saleTextBox.Text));
            //johnDataSetTableAdapters.ItemsTableAdapter addite = new johnDataSetTableAdapters.ItemsTableAdapter();
            //addite.items_add_InsertQuery(item_NameTextBox1.Text, int.Parse(item_MinTextBox.Text), double.Parse(item_coast_saleTextBox.Text), comboBox1.Text, int.Parse(item_amountTextBox.Text), comboBox2.Text, double.Parse(item_private_saleTextBox.Text), double.Parse(c.Text));


//            SqlConnection conec = new SqlConnection(@"Data Source=localhost;Initial Catalog=john;Integrated Security=True");
//            sda = new SqlDataAdapter(@"select item_id, item_name, item_min, item_brand, item_amount, item_coast_sale,item_store,item_private_sale,item_genral_sale
//                                       from items", conec);

//            dt = new DataTable();
//            sda.Fill(dt);
//            dataGridView2.DataSource = dt;

//            con.Open();
//            scm.CommandText = (@"insert into items( item_name, item_min, item_brand, item_amount, item_coast_sale,item_store,item_private_sale,
//                                item_genral_sale) values(N'" + item_NameTextBox1.Text + "','" + item_MinTextBox.Text + "','" + comboBox1.Text + "','" + item_amountTextBox.Text + "','" + float.Parse(item_coast_saleTextBox.Text) + "','" + comboBox2.Text + "','" + float.Parse(item_private_saleTextBox.Text) + "','" + float.Parse(item_genral_saleTextBox.Text) + "')");
//            scm.ExecuteNonQuery();
//            scm.Clone();
//            con.Close();


            //scm.CommandType=(""
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = "Storedprocedure";

            

        }

        private void show_items_Click(object sender, EventArgs e)
        {
            SqlConnection conec = new SqlConnection("Data Source=localhost;Initial Catalog=john;Integrated Security=True");
//            sda = new SqlDataAdapter(@"select item_id, item_name, item_min, item_brand, item_amount, item_coast_sale,item_store,item_private_sale,item_genral_sale
//                                       from items", conec);
            sda = new SqlDataAdapter(@"select *
                                       from items", conec);
            

            dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            
            
                                      
        }

        private void update_item_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count = itemsBindingSource.Count;
            label1.Text = " عدد الاصناف"+count.ToString() ;
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                item_IDTextBox.Text = row.Cells[0].Value.ToString();
                item_NameTextBox1.Text = row.Cells[1].Value.ToString();
                item_MinTextBox.Text = row.Cells[2].Value.ToString();
                item_coast_saleTextBox.Text = row.Cells[3].Value.ToString();
                comboBox1.Text = row.Cells[4].Value.ToString();
                item_amountTextBox.Text = row.Cells[5].Value.ToString();
                comboBox2.Text = row.Cells[6].Value.ToString();
                item_private_saleTextBox.Text = row.Cells[7].Value.ToString();
                item_private_saleTextBox.Text = row.Cells[8].Value.ToString();

            }
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
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
        }

       

     
     
    }
}