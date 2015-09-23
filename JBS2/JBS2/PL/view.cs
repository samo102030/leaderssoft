using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JBS2
{
    public partial class view : Form
    {
        int x;
        SqlConnection con = new SqlConnection();
        public view()
        {
            InitializeComponent();
        }
        public view(string x)
        {
            InitializeComponent();
            this.x = int.Parse(x);
        }

        private void view_Load(object sender, EventArgs e)
        {
            //con.ConnectionString = @"Data Source=localhost;Initial Catalog=john;Integrated Security=True";
            //string sql = "SELECT Order_Out.Bill_out_ID, Employee.emp_name, customers.customer_name, Order_Out.Bill_out_Date, Items.Item_Name, Brand.Brand_name, Order_Out_Details.Item_sale_Price, Order_Out_Details.amount, Order_Out_Details.Item_sale_Price * Order_Out_Details.amount AS total FROM Employee INNER JOIN customers INNER JOIN Order_Out_Details INNER JOIN Items ON Order_Out_Details.Item_ID = Items.Item_ID INNER JOIN Order_Out ON Order_Out_Details.Bill_ID = Order_Out.Bill_out_ID ON customers.Customer_id = Order_Out.Cus_ID ON Employee.emp_ID = Order_Out.Emp_ID CROSS JOIN Brand WHERE(Order_Out.Bill_out_ID =" + x;
            //DataSet1 ds = new DataSet1();
            //SqlDataAdapter dad = new SqlDataAdapter(sql, con);
            //dad.Fill(ds.Tables["orders"]);
            //order ord = new order();
            //ord.Load(@"C:\Users\sam\Documents\Visual Studio 2010\Projects\JBS2\JBS2\order.rpt");
            //ord.SetDataSource(ds.Tables["orders"]);
            //crystalReportViewer1.ReportSource = ord;
            //crystalReportViewer1.Refresh();
        }
    }
}
