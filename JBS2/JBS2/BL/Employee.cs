using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace JBS2.BL
{
    class Employee
    {
        public DataTable Get_all_employee()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
         //عندما نتعامل مع الداتا اكسس لاير  فاننا لا نحتاج الى فتح الكونكشن ولكن عندما نتعامل مع الكوماند فلابد من فتح الكونكشن 
           // DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Get_all_employee", null);
            // فى حالة عدم وجود براميتير فى استرجاع البيانات ( على سبيل المثال عرض جميع الموظفين) ففى هذه الحالة نكتب null بدل param
             DAL.close();
            return dt;
        }

        public void Add_Employee(string emp_name, string Emp_Personal_ID, date birthdate, string Emp_Add,
                                date Hire_date, float Sallary, float bounus, string phone, string Mobile,
                                string E_mail, int Penalties_Days, int Avaliable_Absence_Days, byte[] image,
                                string notes, string Emp_User_name, string User_Pwd, string emp_type)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[17];
            param[0] = new SqlParameter("@emp_name", SqlDbType.NVarChar,50);
            param[0].Value = emp_name;

            param[1] = new SqlParameter("@Emp_Personal_ID", SqlDbType.NVarChar,14);
            param[1].Value = Emp_Personal_ID;
            
            param[2] = new SqlParameter("@birthdate", SqlDbType.Date);
            param[2].Value = birthdate;
            
            param[3] = new SqlParameter("@Emp_Add", SqlDbType.NVarChar,50);
            param[3].Value = Emp_Add;
            
            param[4] = new SqlParameter("@Hire_date", SqlDbType.Date);
            param[4].Value = Hire_date;
            
            param[5] = new SqlParameter("@Sallary", SqlDbType.Float);
            param[5].Value = Sallary;
            
            param[6] = new SqlParameter("@bounus", SqlDbType.Float);
            param[6].Value = bounus;
            
            param[7] = new SqlParameter("@phone", SqlDbType.NVarChar,20);
            param[7].Value = phone;
            
            param[8] = new SqlParameter("@Mobile", SqlDbType.NVarChar,20);
            param[8].Value = Mobile;
            
            param[9] = new SqlParameter("@E_mail", SqlDbType.NVarChar,30);
            param[9].Value = E_mail;
            
            param[10] = new SqlParameter("@Penalties_Days", SqlDbType.Int);
            param[10].Value = Penalties_Days;
            
            param[11] = new SqlParameter("@Avaliable_Absence_Days", SqlDbType.Int);
            param[11].Value = Avaliable_Absence_Days;
            
            param[12] = new SqlParameter("@image", SqlDbType.Image);
            param[12].Value = image;
            
            param[13] = new SqlParameter("@notes", SqlDbType.NVarChar,1000);
            param[13].Value = notes;
            
            param[14] = new SqlParameter("@Emp_User_name", SqlDbType.VarChar,15);
            param[14].Value = Emp_User_name;
            
            param[15] = new SqlParameter("@User_Pwd", SqlDbType.VarChar,15);
            param[15].Value = User_Pwd;
            
            param[16] = new SqlParameter("@emp_type", SqlDbType.VarChar,15);
            param[16].Value = emp_type;

            DAL.ExecuteCommand("Employee_AddQuery", param);
            DAL.close();

        
        }

        // -------------------------------------------- دالة تعديل بيانات الموظفين -------------------------------------

        public void Edit_Employee(string emp_name, string Emp_Personal_ID, date birthdate, string Emp_Add,
                            date Hire_date, float Sallary, float bounus, string phone, string Mobile,
                            string E_mail, int Penalties_Days, int Avaliable_Absence_Days, byte[] image,
                            string notes, string Emp_User_name, string User_Pwd, string emp_type, string condation, int emp_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[19];
            param[0] = new SqlParameter("@emp_name", SqlDbType.NVarChar, 50);
            param[0].Value = emp_name;

            param[1] = new SqlParameter("@Emp_Personal_ID", SqlDbType.NVarChar, 14);
            param[1].Value = Emp_Personal_ID;

            param[2] = new SqlParameter("@birthdate", SqlDbType.Date);
            param[2].Value = birthdate;

            param[3] = new SqlParameter("@Emp_Add", SqlDbType.NVarChar, 50);
            param[3].Value = Emp_Add;

            param[4] = new SqlParameter("@Hire_date", SqlDbType.Date);
            param[4].Value = Hire_date;

            param[5] = new SqlParameter("@Sallary", SqlDbType.Float);
            param[5].Value = Sallary;

            param[6] = new SqlParameter("@bounus", SqlDbType.Float);
            param[6].Value = bounus;

            param[7] = new SqlParameter("@phone", SqlDbType.NVarChar, 20);
            param[7].Value = phone;

            param[8] = new SqlParameter("@Mobile", SqlDbType.NVarChar, 20);
            param[8].Value = Mobile;

            param[9] = new SqlParameter("@E_mail", SqlDbType.NVarChar, 30);
            param[9].Value = E_mail;

            param[10] = new SqlParameter("@Penalties_Days", SqlDbType.Int);
            param[10].Value = Penalties_Days;

            param[11] = new SqlParameter("@Avaliable_Absence_Days", SqlDbType.Int);
            param[11].Value = Avaliable_Absence_Days;

            param[12] = new SqlParameter("@image", SqlDbType.Image);
            param[12].Value = image;

            param[13] = new SqlParameter("@notes", SqlDbType.NVarChar, 1000);
            param[13].Value = notes;

            param[14] = new SqlParameter("@Emp_User_name", SqlDbType.VarChar, 15);
            param[14].Value = Emp_User_name;

            param[15] = new SqlParameter("@User_Pwd", SqlDbType.VarChar, 15);
            param[15].Value = User_Pwd;

            param[16] = new SqlParameter("@emp_type", SqlDbType.VarChar, 15);
            param[16].Value = emp_type;

            param[17] = new SqlParameter("@condation", SqlDbType.VarChar, 20);
            param[17].Value = condation;

            param[18] = new SqlParameter("@emp_ID", SqlDbType.Int);
            param[18].Value = emp_ID;

            DAL.ExecuteCommand("Edit_Employee", param);
            DAL.close();


        }

        
        internal void Add_Employe(string p, string p_2, DateTime dateTime, string p_3, DateTime dateTime_2, float p_4, float p_5, string p_6, string p_7, string p_8, int p_9, int p_10, byte[] byte_image, string p_11, string p_12, string p_13, string p_14)
        {
           // throw new NotImplementedException();
        }

        internal void Edit_Employee(string p, string p_2, DateTime dateTime, string p_3, DateTime dateTime_2, float p_4, float p_5, string p_6, string p_7, string p_8, int p_9, int p_10, byte[] byte_image, string p_11, string p_12, string p_13, string p_14)
        {
            //hrow new NotImplementedException();
        }

        internal void Edit_Employee(string p, string p_2, DateTime dateTime, string p_3, DateTime dateTime_2, float p_4, float p_5, string p_6, string p_7, string p_8, int p_9, int p_10, byte[] byte_image, string p_11, string p_12, string p_13, string p_14, int p_15)
        {
            throw new NotImplementedException();
        }

        internal void Edit_Employee(string p, string p_2, DateTime dateTime, string p_3, DateTime dateTime_2, float p_4, float p_5, string p_6, string p_7, string p_8, int p_9, int p_10, byte[] Emp_pic, string p_11, string p_12, string p_13, string p_14, string p_15)
        {
            throw new NotImplementedException();
        }

        internal void Edit_Employee(string p, string p_2, DateTime dateTime, string p_3, DateTime dateTime_2, float p_4, float p_5, string p_6, string p_7, string p_8, int p_9, int p_10, byte[] Emp_pic, string p_11, string p_12, string p_13, string p_14, int p_15, string p_16)
        {
            throw new NotImplementedException();
        }

        internal void Edit_Employee(string p, string p_2, DateTime dateTime, string p_3, DateTime dateTime_2, float p_4, float p_5, string p_6, string p_7, string p_8, int p_9, int p_10, byte[] Emp_pic, string p_11, string p_12, string p_13, string p_14, string p_15, int p_16)
        {
            throw new NotImplementedException();
        }
    }
}
