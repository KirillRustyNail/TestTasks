using BDApplication.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDApplication.Repositores
{
    internal class SQLEmployeeRepository : IRepository<Employee>
    {
        void IRepository<Employee>.Create(Employee item)
        {
            string sql = @"INSERT INTO EMPLOYEE (DEPARTMENT_ID,CHIEF_ID,NAME,SALARY) 
                           VALUES (@Department_id,@Chief_id,@Name, @Salary)";
            try
            {
                SqlConnection connect = BD_logic.GetConnection();
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@Department_id", item.DEPARTMENT_ID);
                cmd.Parameters.AddWithValue("@Chief_id", item.CHIEF_ID);
                cmd.Parameters.AddWithValue("@Name", item.Name);
                cmd.Parameters.AddWithValue("@Salary", item.SALARY);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BD_logic.CloseConnection(connect);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("MsSQL Connection \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void IRepository<Employee>.Delete(int id)
        {
            string sql = @"DELETE FROM EMPLOYEE where ID_Employee = @id";

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

        void IRepository<Employee>.GetAllList(string s, DataGridView dvg)
        {
            string searchtext = "%" + s + "%";

            string sql = @"select ID_Employee,DEPARTMENT_ID,CHIEF_ID,EMPLOYEE.NAME,SALARY,ID_Department,DEPARTMENT.NAME AS 'DEPARTMENT NAME' from EMPLOYEE join DEPARTMENT on ID_Department = DEPARTMENT_ID
                           WHERE EMPLOYEE.NAME LIKE @searchtext";
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

        void IRepository<Employee>.Update(Employee item, int id)
        {
            string sql = @"UPDATE EMPLOYEE SET 
                            DEPARTMENT_ID = @Department_id, 
	                        CHIEF_ID = @Chief_id, 
	                        NAME = @Name, 
	                        SALARY = @Salary 
	                        WHERE ID_Employee = @id";

            try
            {
                SqlConnection connect = BD_logic.GetConnection();
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@Department_id", item.DEPARTMENT_ID);
                cmd.Parameters.AddWithValue("@Chief_id", item.CHIEF_ID);
                cmd.Parameters.AddWithValue("@Name", item.Name);
                cmd.Parameters.AddWithValue("@Salary", item.SALARY);
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
