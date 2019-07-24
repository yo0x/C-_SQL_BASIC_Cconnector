using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Targil4Bonus.Controller
{
    public static class SqlCon
    {

        public static DataTable dtbl = new DataTable();
        public static SqlConnection sqlCon;

        public static void sqlConToSrv()
        {
            sqlCon = new SqlConnection(@"Data Source = tcp:212.117.143.82,64522; Initial Catalog = Project4u; User ID = sa; Password = @@Kinneret@@12345");
           
        }
        public static DataTable ShowAllEmployees()
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(Queries.QueriesToExecute.ShowAllEmpQuery, sqlCon);
            sqlda.Fill(dtbl);
            return dtbl;
        }
        public static void CloseConn()
        {
            sqlCon.Close();
        }
        public static DataTable IncSalary5()
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(Queries.QueriesToExecute.UpdateEmpSalaryBy5Per, sqlCon);
            sqlda.Fill(dtbl);
            return dtbl;
        }
    }
}
