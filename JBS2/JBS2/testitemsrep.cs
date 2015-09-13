using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace JBS2
{
    public partial class testitemsrep : Form
    {

        string connectionString = "Data Source=localhost;Initial Catalog=john;Integrated Security=True";
        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter a;
        DataTable ds = new DataTable();
        CrystalReport3 crp = new CrystalReport3();

        public testitemsrep()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
            a = new SqlDataAdapter("SELECT     customers.customer_name, Employee.emp_name, Items.Item_Name, Order_Out.Bill_out_Date, Order_Out_Details.amount,Order_Out_Details.Item_sale_Price FROM customers INNER JOIN Order_Out ON customers.Customer_id = Order_Out.Cus_ID INNER JOIN Employee ON Order_Out.Emp_ID = Employee.emp_ID INNER JOIN Order_Out_Details ON Order_Out.Bill_out_ID = Order_Out_Details.Bill_ID INNER JOIN Items ON Order_Out_Details.Item_ID = Items.Item_ID WHERE(Order_Out.Bill_out_ID = 22)", con);

            con.Open();
            
            a.Fill(ds);
            
            crp.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crp;
            crystalReportViewer1.Refresh();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            a = new SqlDataAdapter("Select * from items where item_id = '"+textBox1.Text+"'", con);

            con.Open();
            ds.Clear();

            a.Fill(ds);
            crp.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crp;
            crystalReportViewer1.Refresh();
            con.Close();
        }
    }
}
