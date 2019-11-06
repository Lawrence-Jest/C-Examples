// Class DataBase to connect to the database and process an SQL command
//
//Lawrence Jest-A00583216
//June 12, 2018

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class DataBase
    {

        // Default constructor
        public DataBase()
        {

        }

        // Get connection, initialize SqlDataAdapter, and get data. 
        public static DataTable RunSQL(string sql)
        {
            DataTable table = new DataTable();
            try
            {
                // A reference to the dll is needed in References. See example 19-3.
                // Also, a reference is needed in the App.config file.
                string connection
                = ConfigurationManager.ConnectionStrings["MyConnection"]
                .ConnectionString;

                SqlDataAdapter adapter = null;

                adapter = new SqlDataAdapter(sql, connection);

                adapter.Fill(table);
            }
            catch (Exception e)
            {
                Console.WriteLine("The SQL is either invalid or your "
                + "connection failed. Please check your "
                + "App.config reference just in case: "
                + e.Message);
            }
            return table;
        }
    }
}
