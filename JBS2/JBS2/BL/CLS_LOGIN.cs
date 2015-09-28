using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace JBS2.BL
{
    class CLS_LOGIN
    {
        public DataTable LOGIN(string Emp_User_name, string User_Pwd)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Emp_User_name", SqlDbType.VarChar, 15);
            param[0].Value = Emp_User_name;
            param[1] = new SqlParameter("@User_Pwd", SqlDbType.VarChar, 15);
            param[1].Value = User_Pwd;
            
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("dbo.Employee_login", param);
            // فى حالة عدم وجود براميتير فى استرجاع البيانات ( على سبيل المثال عرض جميع الموظفين) ففى هذه الحالة نكتب null بدل param
            DAL.close();
            return dt;
        }
    }
}
