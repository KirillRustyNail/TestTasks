using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace BDApplication
{
    internal class BD_logic
    {

        public static SqlConnection GetConnection()
        { 
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["WorkersDB"].ConnectionString);

            try
            {
                sqlConnection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("MsSQL Connection \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return sqlConnection;

        }

        public static void CloseConnection(SqlConnection s)
        {
            if (s.State == System.Data.ConnectionState.Open)
            {
                s.Close(); 
            }
        }

        public static bool ExecuteProcedure(int ID, int Percent, DataGridView dvg) 
        {
           
            string sql = "UPDATESALARYFORDEPARTMENT";
            try
            {
                SqlConnection connect = GetConnection();
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@PERCENT", Percent);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);

                if (tbl.Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    dvg.DataSource = tbl;
                }

                CloseConnection(connect);
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("MsSQL Connection \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;

        }

    }
}
