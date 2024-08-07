using BDApplication.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace BDApplication.Repositores
{
    internal class SQLDepartmentRepository : IRepository<Department>
    {
        void IRepository<Department>.Create(Department item)
        {
            string sql = @"INSERT INTO DEPARTMENT (NAME) 
                           VALUES (@Name)";

            try
            {
                SqlConnection connect = BD_logic.GetConnection();
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@Name", item.Name);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BD_logic.CloseConnection(connect);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("MsSQL Connection \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void IRepository<Department>.Delete(int id)
        {
            string sql = @"DELETE FROM DEPARTMENT where ID_Department = @id";

            try
            {
                SqlConnection connect = BD_logic.GetConnection();
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BD_logic.CloseConnection(connect);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("MsSQL Connection \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void IRepository<Department>.GetAllList(string s, DataGridView dvg)
        {

            string searchtext = "%" + s + "%";

            string sql = @"select ID_Department, NAME 
                           from DEPARTMENT 
                           WHERE NAME LIKE @searchtext";
            try
            {
                SqlConnection connect = BD_logic.GetConnection();
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@searchtext", searchtext);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable tbl = new DataTable();

                adp.Fill(tbl);
                dvg.DataSource = tbl;
                BD_logic.CloseConnection(connect);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("MsSQL Connection \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void IRepository<Department>.Update(Department item, int id)
        {
            string sql = @"UPDATE DEPARTMENT 
                           SET NAME = @name 
                           WHERE ID_Department = @id";


            try
            {
                SqlConnection connect = BD_logic.GetConnection();
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BD_logic.CloseConnection(connect);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("MsSQL Connection \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
