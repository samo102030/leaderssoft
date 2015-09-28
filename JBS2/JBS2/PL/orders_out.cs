using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace JBS2
{
    public partial class orders_out : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=john;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public orders_out()
        {
            InitializeComponent();

            cmd.CommandText = "SELECT * FROM Order_Out";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            con.Open();

            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    var loop = true;
                    while (loop)
                    {
                        //1. Here retrive values you need e.g. var myvar = reader.GetBoolean(0);
                        int last_id = reader.GetInt32(0);
                        loop = reader.Read();
                        if (!loop)
                        {
                            //You are on the last record. Use values read in 1.
                            //Do some exceptions
                            bill_out_IDTextBox.Text = (last_id + 1).ToString();
                        }
                        else
                        {
                        }
                    }
                }
            }
            else
            {
                bill_out_IDTextBox.Text = "1";
            }
            //                bill_out_IDTextBox.Text = reader.;
            con.Close();
        }

        DataTable temp;
        DataTable bank;
        private void orders_out_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'johnDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.johnDataSet.Employee);
            // TODO: This line of code loads data into the 'johnDataSet.Order_Out' table. You can move, or remove it, as needed.
            this.order_OutTableAdapter.Fill(this.johnDataSet.Order_Out);
// TODO: This line of code loads data into the 'johnDataSet.customers' table. You can move, or remove it, as needed.
this.customersTableAdapter.Fill(this.johnDataSet.customers);
            // TODO: This line of code loads data into the 'johnDataSet.Order_in_detailes' table. You can move, or remove it, as needed.
            this.order_in_detailesTableAdapter.Fill(this.johnDataSet.Order_in_detailes);
            // TODO: This line of code loads data into the 'johnDataSet.Order_Out_Details' table. You can move, or remove it, as needed.
            this.order_Out_DetailsTableAdapter.Fill(this.johnDataSet.Order_Out_Details);
            // TODO: This line of code loads data into the 'johnDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.johnDataSet.Items);

            //this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.datagridview1_RowPostPaint);

            timer1.Start();
            
            
            //this code make combobox search like google
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;

            customer_nameComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            customer_nameComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

        
            
            //int cellnum = 0;
            //int rownum = 0;
            //foreach(DataGridViewRow row in dataGridView1.Rows)
            //{
            //    cellnum = cellnum +1;
            //    dataGridView1.Rows[rownum].Cells[0].Value = cellnum;
            //    rownum = rownum + 1;
            //}
            }
        

        private void total_sale_prise_TextChanged(object sender, EventArgs e)
        {
            //int first = 0;
            //int second = 0;
            //if (Int32.TryParse(item_genral_saleTextBox.Text, out second) && Int32.TryParse(amountsale.Text, out first))
            //  total_sale_prise.Text = (first * second).ToString();
        }

        private void item_genral_saleTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(item_genral_saleTextBox.Text) && !string.IsNullOrEmpty(amountsale.Text))
            //    total_sale_prise.Text = (Convert.ToInt32(item_genral_saleTextBox.Text) * Convert.ToInt32(amountsale.Text)).ToString();
        }

        private void amountsale_TextChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(item_genral_saleTextBox.Text) && !string.IsNullOrEmpty(amountsale.Text))
            //    total_sale_prise.Text = (Convert.ToInt32(item_genral_saleTextBox.Text) * Convert.ToInt32(amountsale.Text)).ToString();

            if (!string.IsNullOrEmpty(item_genral_saleTextBox.Text) && !string.IsNullOrEmpty(amountsale.Text))
                total_sale_prise.Text = (float.Parse (item_genral_saleTextBox.Text) * Convert.ToInt32(amountsale.Text)).ToString();



            if (!string.IsNullOrEmpty(item_amountTextBox.Text) && !string.IsNullOrEmpty(amountsale.Text))
                stay_amount.Text = (Convert.ToInt32(item_amountTextBox.Text) - Convert.ToInt32(amountsale.Text)).ToString();
        }

        private void item_amountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(item_amountTextBox.Text) && !string.IsNullOrEmpty(amountsale.Text))
                stay_amount.Text = (Convert.ToInt32(item_amountTextBox.Text) - Convert.ToInt32(amountsale.Text)).ToString();
        }

        private void add_item_Click(object sender, EventArgs e)
        {
           // johnDataSetTableAdapters.Order_OutTableAdapter orout= new johnDataSetTableAdapters.Order_OutTableAdapter();
           //orout.Oreder_out_InsertQuery(
           // string store_num = store_IDTextBox.Text;
           // string store_name = store_NameTextBox.Text;
           // string[] row = { store_num, store_name };
           // store_view.Rows.Add(row);

            //for (int s = 0; s < dataGridView1.Rows.Count - 1; s++)
            //{
            //    if (dataGridView1.Rows[s].Cells[0].Value.ToString() == item_IDComboBox.Text)
            //    {
            //        MessageBox.Show("هذا المنتج موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //}

            // to prevent duplicates :D
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (item_IDTextBox.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                     {
                         MessageBox.Show("هذا المنتج موجود مسبقا");
                          return;
                     }
            }


            if (String.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("قم بإختيار المنتج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

           else if (String.IsNullOrEmpty(amountsale.Text) )
            {
                MessageBox.Show("قم بإدخال الكمية المطلوبة","تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(bill_out_DiscountTextBox.Text))
            {
                bill_out_DiscountTextBox.Text = "0";
            }
            //for (int s = 0; s < dataGridView1.Rows.Count - 1; s++)
            //{
            //    if (dataGridView1.Rows[s].Cells[0].Value.ToString() == item_IDTextBox.Text)
            //    {
            //        MessageBox.Show("هذا المنتج موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //}

            {
                //if (!float.Parse(bill_out_DiscountTextBox.Text))
                //{
                    string Item_Id = item_IDTextBox.Text;
                    //string bill_date = bill_out_DateDateTimePicker.Text;
                    string Item_Name = comboBox2.Text;
                    //string Item_buy_price = item_Buy_PriceTextBox.Text;
                    string Item_sale_Price = item_genral_saleTextBox.Text;
                    string amount = amountsale.Text;
                
                    float Total_current_cost;
                    Total_current_cost = (int.Parse(amountsale.Text)) * (float.Parse(item_genral_saleTextBox.Text));

                    //float Total_current_cost_discount = ((int.Parse(amountsale.Text)) * (float.Parse(item_genral_saleTextBox.Text))) * float.Parse(bill_out_DiscountTextBox.Text) / 100;
                    //Total_current_cost -= Total_current_cost_discount;
                    string Total_current_cost1 = Total_current_cost.ToString();
                    //string price_after_disc = Total_current_cost1 - (Total_current_cost1 * (int.Parse(item_disc.Text) / 100));

                    //float Total_current_cost_after_Adding = Total_current_cost + ((int.Parse(amountsale.Text)) * (float.Parse(item_genral_saleTextBox.Text)));
                    //string Total_current_cost_after_Adding2 = Total_current_cost_after_Adding.ToString();

//<<<<<<< HEAD:JBS2/JBS2/orders_out.cs
//                    string[] row = { Item_Id, Item_Name, amount, Item_sale_Price, Total_current_cost1, Total_current_cost };
//                    dataGridView1.Rows.Add(row);
////=======
                    //string[] row = { Item_Id, Item_Name, amount, Item_sale_Price, Total_current_cost1, price_after_disc };
                    //dataGridView1.Rows.Add(row);
//>>>>>>> d310fd31666a2256546d1ff2e4885328ef1b55a8:JBS2/JBS2/PL/orders_out.cs

                    //here we will the sum of all items in this bill
                    double sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
                    bill_out_CostTextBox.Text = sum.ToString();

               
                    
                    //MessageBox.Show(sum.ToString());
                }
               
            
             //amountsale.Text = string.Empty;
            amountsale.Clear();
            bill_out_DiscountTextBox.Clear();
            bill_out_Discount_costTextBox.Clear();
            bill_out_Cost_remainTextBox.Clear();
            bill_out_Cost_paidTextBox.Clear();
            //customer_nameComboBox.ResetText();
            comboBox2.ResetText();
            total_sale_prise.Clear();
            //item_genral_saleTextBox.Clear();
            stay_amount.Clear();
            item_amountTextBox.Clear();
            //item_IDComboBox.ResetText();

            comboBox2.Focus();
        
                
                
            //}
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bill_out_Cost_paidTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(bill_out_Cost_paidTextBox.Text) && string.IsNullOrEmpty(bill_out_Discount_costTextBox.Text))
            {
                bill_out_Discount_costTextBox.Text = "0";
            }
            else
            {
                bill_out_Cost_remainTextBox.Text = (float.Parse(bill_out_Discount_costTextBox.Text) - float.Parse(bill_out_Cost_paidTextBox.Text)).ToString();
            }
        }

        private void bill_out_Discount_costTextBox_TextChanged(object sender, EventArgs e)
        {

            //if (!string.IsNullOrEmpty(bill_out_DiscountTextBox.Text) && !string.IsNullOrEmpty(bill_out_CostTextBox.Text))
            //    bill_out_Discount_costTextBox.Text = ((Convert.ToInt32(bill_out_DiscountTextBox.Text) / 100) * Convert.ToInt32(bill_out_CostTextBox.Text)).ToString();
            
            //double d;
            //double di;
            //double i;
            //d = Convert.ToDouble(dis.Text);
            //i = Convert.ToDouble(prc.Text);
            //di = -((d * 100) / i);
            //net_prc.Text = di.ToString();

        }

    
        private void bill_out_DiscountTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(bill_out_DiscountTextBox.Text) && !string.IsNullOrEmpty(bill_out_CostTextBox.Text))
            //    bill_out_Discount_costTextBox.Text = (Convert.ToInt32(bill_out_CostTextBox.Text) - (Convert.ToInt32(bill_out_DiscountTextBox.Text) / 100.0) * Convert.ToInt32(bill_out_CostTextBox.Text)).ToString();


            if (string.IsNullOrEmpty(bill_out_DiscountTextBox.Text) && !string.IsNullOrEmpty(bill_out_CostTextBox.Text))
            {
                bill_out_DiscountTextBox.Text = "0";
            }
            else
            {
                bill_out_Discount_costTextBox.Text = ((100.0 - float.Parse(bill_out_DiscountTextBox.Text)) * (float.Parse(bill_out_CostTextBox.Text) / 100.0)).ToString();
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("لايوجد اصناف للحذف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(dr);
            }

        }

        private void save_bill_Click(object sender, EventArgs e)
        {
            

             //    // Get the employee ID from login
        //    int Get_Emp_id;
        //    johnDataSetTableAdapters.EmployeeTableAdapter get_ID = new johnDataSetTableAdapters.EmployeeTableAdapter();
        //    Get_Emp_id = Convert.ToInt32(get_ID.Employee_Get_ID_ScalarQuery(emp_nameComboBox.Text));

            // Get the Customer ID from combobox
            int Cust_ID = 0;
            cmd.CommandText = "SELECT * FROM customers where customer_name = '" + customer_nameComboBox.Text + "'";
            con.Open();

            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    var loop = true;
                    while (loop)
                    {
                        //1. Here retrive values you need e.g. var myvar = reader.GetBoolean(0);
                        int customer_id = reader.GetInt32(0);
                        loop = reader.Read();
                        if (!loop)
                        {
                            //You are on the last record. Use values read in 1.
                            //Do some exceptions
                            Cust_ID = customer_id;
                        }
                        else
                        {
                        }
                    }
                }
            }
            else
            {
                 // no row error
            }
            con.Close();

            get_last_id();
        //    //here we will insert in table " order out
        //    // " then we will make procedure to get Max ID in "bill out " table
        //    johnDataSetTableAdapters.Order_OutTableAdapter Add_bill = new johnDataSetTableAdapters.Order_OutTableAdapter();
        //    Add_bill.Order_Out_InsertQuery(Get_Cust_ID, Get_Emp_id, bill_out_DateDateTimePicker.Value, float.Parse(Bill_Out_label.Text), bill_out_DiscountTextBox.Text, float.Parse(bill_out_Discount_costTextBox.Text), float.Parse(bill_out_Cost_paidTextBox.Text), remain, bill_NotesTextBox.Text);

        //    // here we will Get the last ID inserted in order out 
        //    int Get_MAX_ID;
        //    johnDataSetTableAdapters.Order_OutTableAdapter Get_max_ID = new johnDataSetTableAdapters.Order_OutTableAdapter();
        //    Get_MAX_ID = Convert.ToInt32(Get_max_ID.Order_Out_Get_Max_ID_ScalarQuery());

            String query = "INSERT INTO Order_Out ( cus_ID,emp_ID,Bill_out_Date,Bill_out_Cost,Bill_out_Discount,Bill_out_Discount_cost,Bill_out_Cost_paid,Bill_out_Cost_remain,Is_return,Bill_Notes,closed) VALUES(@cus_ID,@emp_ID,@Bill_out_Date,@Bill_out_Cost,@Bill_out_Discount,@Bill_out_Discount_cost,@Bill_out_Cost_paid,@Bill_out_Cost_remain,@Is_return,@Bill_Notes,@closed)";

            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.Add("@cus_ID", Cust_ID);
            command.Parameters.Add("@emp_ID", emp_IDComboBox.Text);
            command.Parameters.Add("@Bill_out_Date", bill_out_DateDateTimePicker.Value.ToShortDateString());
            command.Parameters.Add("@Bill_out_Cost", bill_out_CostTextBox.Text);
            command.Parameters.Add("@Bill_out_Discount", bill_out_DiscountTextBox.Text);
            command.Parameters.Add("@Bill_out_Discount_cost", bill_out_Discount_costTextBox.Text);
            command.Parameters.Add("@Bill_out_Cost_paid", bill_out_Cost_paidTextBox.Text);
            command.Parameters.Add("@Bill_out_Cost_remain", bill_out_Cost_remainTextBox.Text);
            command.Parameters.Add("@Is_return", "false");
            command.Parameters.Add("@Bill_Notes", "false");
            command.Parameters.Add("@closed", "false");
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                // Get item ID by item name
                int current_item_id = get_item_id(dataGridView1.Rows[i].Cells[1].Value.ToString());

                query = "INSERT INTO Order_Out_Details (Bill_ID,Item_ID,Item_sale_Price,Item_Discount_rate,amount, Item_price_after_discount) VALUES(@Bill_ID,@Item_ID,@Item_sale_Price,@Item_Discount_rate,@amount,@Item_price_after_discount)";

                command = new SqlCommand(query, con);

                command.Parameters.Add("@Bill_ID", bill_out_IDTextBox.Text);
                command.Parameters.Add("@Item_ID", current_item_id);
                //check
                command.Parameters.Add("@Item_sale_Price", dataGridView1.Rows[i].Cells[3].Value.ToString());
                command.Parameters.Add("@Item_Discount_rate", dataGridView1.Rows[i].Cells[5].Value.ToString());
                command.Parameters.Add("@amount", dataGridView1.Rows[i].Cells[2].Value.ToString());
                command.Parameters.Add("@Item_price_after_discount", float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()) -(( float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()) *  float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()))/100) );

                con.Open();
                command.ExecuteNonQuery();
                con.Close();


                //        int get_Item_Id;
                //        johnDataSetTableAdapters.ItemsTableAdapter Get_Item_Id = new johnDataSetTableAdapters.ItemsTableAdapter();
                //        get_Item_Id = Convert.ToInt16(Get_Item_Id.Items_Get_ID_ScalarQuery(Items_dataGridView1.Rows[i].Cells["item_Name"].Value.ToString()));

                //        johnDataSetTableAdapters.Order_Out_DetailsTableAdapter Bill_Detalies = new johnDataSetTableAdapters.Order_Out_DetailsTableAdapter();
                //        Bill_Detalies.Order_Out_Details_InsertQuery(Get_MAX_ID, get_Item_Id, float.Parse(Items_dataGridView1.Rows[i].Cells["Item_sale_price"].Value.ToString()), Items_dataGridView1.Rows[i].Cells["Discount_Rate"].Value.ToString(), float.Parse(Items_dataGridView1.Rows[i].Cells["Item_price_after_Discount"].Value.ToString()), int.Parse(Items_dataGridView1.Rows[i].Cells["Amount"].Value.ToString()));

            }


            button1.Enabled = true;
        }


        private int get_item_id(string itemName)
        {
            int id = 0;
            cmd.CommandText = "SELECT * FROM items where item_name = N'" + itemName + "'";
            con.Open();
            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    var loop = true;
                    while (loop)
                    {
                        //1. Here retrive values you need e.g. var myvar = reader.GetBoolean(0);
                        id = reader.GetInt32(0);
                        loop = reader.Read();
                        if (!loop)
                        {
                        }
                        else
                        {
                        }
                    }
                }
            }
            else
            {
                //no item error
            }
            con.Close();
            return id;
        }
        private int get_last_id()
        {
            cmd.CommandText = "SELECT * FROM Order_Out";
            con.Open();
            int last_id = 0;
            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    var loop = true;
                    while (loop)
                    {
                        //1. Here retrive values you need e.g. var myvar = reader.GetBoolean(0);
                        last_id = reader.GetInt32(0);
                        loop = reader.Read();
                        if (!loop)
                        {
                            //You are on the last record. Use values read in 1.
                            //Do some exceptions
                            bill_out_IDTextBox.Text = (last_id + 1).ToString();
                        }
                        else
                        {
                        }
                    }
                }
            }
            else
            {
                bill_out_IDTextBox.Text = "1";
            }
            con.Close();
            return last_id + 1;
        }

        private void nw_order_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            bill_out_CostTextBox.Clear();
            //amountsale.Text = string.Empty;
            amountsale.Clear();
            bill_out_DiscountTextBox.Clear();
            bill_out_Discount_costTextBox.Clear();
            bill_out_Cost_remainTextBox.Clear();
            bill_out_Cost_paidTextBox.Clear();
            customer_nameComboBox.ResetText();
            comboBox2.ResetText();
            total_sale_prise.Clear();
            item_genral_saleTextBox.Clear();
            stay_amount.Clear();
            item_amountTextBox.Clear();


         
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count = dataGridView1.RowCount;
            label3.Text = " عدد الاصناف" + count.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
           
            

        }

        private void emp_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void amountsale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void item_genral_saleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar!=Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox2.Text != string.Empty)
            {
                amountsale.Focus();
            }
        }

        private void amountsale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && amountsale.Text != string.Empty)
            {
               item_genral_saleTextBox.Focus();
            }
        }

      
        private void item_genral_saleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && item_genral_saleTextBox.Text != string.Empty)
            {
                bill_out_DiscountTextBox.Focus();
            }
        }

        private void bill_out_DiscountTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && bill_out_DiscountTextBox.Text != string.Empty)
            {
                add_item.Focus();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                item_IDTextBox.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                amountsale.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                item_genral_saleTextBox.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                total_sale_prise.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                bill_out_DiscountTextBox.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                amountsale.Focus();
            }
            catch
            {
                return;
            }
        }

        private void bill_out_CostTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            bill_out_CostTextBox.Text = sum.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       

        //private void add_item_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        for (int s = 0; s < dataGridView1.Rows.Count - 1; s++)
        //        {
        //            if (dataGridView1.Rows[s].Cells[0].Value.ToString() == item_IDComboBox.Text)
        //            {
        //                MessageBox.Show("هذا المنتج موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //                return;
        //            }
        //        }
        //    }
        //}

    }
}
