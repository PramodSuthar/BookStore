using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BookProgram.Controller
{
    public static class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection ConnDB = new SqlConnection("Data Source=DESKTOP-6F29VU1 ; database=book ; Integrated Security=SSPI");
            ConnDB.Open();
            return ConnDB;
        }


    }
}
