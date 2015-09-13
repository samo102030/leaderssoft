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
    public partial class date : Form
    {
        
       // SqlDataAdapter ad;
        DataTable dt;
        public date()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection ssl = new SqlConnection();
            ssl.ConnectionString = @"Data Source=localhost;Initial Catalog=john;Integrated Security=True";
            ssl.Open();
            var a = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            var b = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            SqlDataAdapter ad = new SqlDataAdapter("SELECT Bill_out_ID,Cus_ID, Bill_out_Date FROM order_out WHERE    Bill_out_Date >='" + a + "' AND Bill_out_Date <= '" + b + "'", ssl);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;




        }

        private void date_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'johnDataSet.Order_Out' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'johnDataSet.Order_Out_Details' table. You can move, or remove it, as needed.
            this.order_Out_DetailsTableAdapter.Fill(this.johnDataSet.Order_Out_Details);

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {


            //SqlConnection ssl = new SqlConnection();
            //ssl.ConnectionString = @"Data Source=localhost;Initial Catalog=john;Integrated Security=True";
            //ssl.Open();
            ////var a = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            ////var b = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            //SqlDataAdapter ad = new SqlDataAdapter("SELECT Bill_out_ID,Cus_ID, Bill_out_Date FROM order_out WHERE    Bill_out_Date >='" + a + "' AND Bill_out_Date <= '" + b + "'", ssl);

            //DataTable dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView2.DataSource = dt;
        }
    }
}
