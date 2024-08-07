using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BDApplication.Repositores;
using BDApplication.Classes;
using BDApplication.Forms;

namespace BDApplication
{
    public partial class MainForm : Form
    {

        IRepository<Department> DepartmentRep;
        IRepository<Employee> EmployeeRep;

        AddDepartment Departmentform;  // Форма добавления\обновления отдела
        AddEmployee Employeeform;  // Форма добавления\обновления сотрудника
        public string selectRow = "0";  // Выбранная строка в таблице
        public MainForm()
        {
            InitializeComponent();
            Departmentform = new AddDepartment(this);
            Employeeform = new AddEmployee(this);

            EmployeeRep = new SQLEmployeeRepository();
            DepartmentRep = new SQLDepartmentRepository();

            Choosetable.SelectedIndex = 0;
            Choosetable.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void ExucProcBut_Click(object sender, EventArgs e)
        {
            
            if (!(String.IsNullOrEmpty(textBoxID.Text.ToString())) && !(String.IsNullOrEmpty(textBoxPersent.Text.ToString())))
            {
                Choosetable.SelectedIndex = 1;
                if (!BD_logic.ExecuteProcedure(int.Parse(textBoxID.Text.ToString()), int.Parse(textBoxPersent.Text.ToString()), dataGridView))
                { 
                    MessageBox.Show("Процедура не вернула никаких данных.");
                    Display();
                }
                selectRow = "0";
            }
            else MessageBox.Show("Data entered incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Display();
        }

        // Отображение выбранной таблицы
        public void Display()
        {
            if (Choosetable.SelectedIndex == 0)
            {
                DepartmentRep.GetAllList(searchtext.Text, dataGridView);
            }
            else if (Choosetable.SelectedIndex == 1)
            {
                EmployeeRep.GetAllList(searchtext.Text, dataGridView);
            }

            try
            {
                if (Convert.ToInt32(selectRow) > 0)
                {
                    dataGridView.CurrentCell = dataGridView.Rows[Convert.ToInt32(selectRow)].Cells[0];
                }
                dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
            }
            catch { }

        }

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //отображение таблицы с учётом поиска
                Display();
                dataGridView.CurrentCell = dataGridView.Rows[0].Cells[0];
            }
            catch { }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = dataGridView.SelectedRows[0].Index.ToString();
        }

        private void CreateBut_Click(object sender, EventArgs e)
        {
            if (Choosetable.SelectedIndex == 0)
            {
                Departmentform.SaveInfo();
                Departmentform.Clear();
                Departmentform.ShowDialog();
            }
            else if (Choosetable.SelectedIndex == 1)
            {
                Employeeform.SaveInfo();
                Employeeform.Clear();
                Employeeform.ShowDialog();
            }
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            try
            {
                if (Choosetable.SelectedIndex == 0)
                {
                    Departmentform.Clear();
                    Departmentform.id = int.Parse(dataGridView.Rows[Convert.ToInt32(selectRow)].Cells[0].Value.ToString());
                    Departmentform.name = dataGridView.Rows[Convert.ToInt32(selectRow)].Cells[1].Value.ToString();
                    
                    Departmentform.UpdateInfo();
                    Departmentform.ShowDialog();
                }
                if (Choosetable.SelectedIndex == 1)
                {
                    Employeeform.Clear();
                    Employeeform.id = int.Parse(dataGridView.Rows[Convert.ToInt32(selectRow)].Cells[0].Value.ToString());
                    Employeeform.Department_id = int.Parse(dataGridView.Rows[Convert.ToInt32(selectRow)].Cells[1].Value.ToString());
                    Employeeform.Chief_id = int.Parse(dataGridView.Rows[Convert.ToInt32(selectRow)].Cells[2].Value.ToString());
                    Employeeform.name = dataGridView.Rows[Convert.ToInt32(selectRow)].Cells[3].Value.ToString();
                    Employeeform.Salary = int.Parse(dataGridView.Rows[Convert.ToInt32(selectRow)].Cells[4].Value.ToString());

                    Employeeform.UpdateInfo();
                    Employeeform.ShowDialog();
                    
                }
            }
            catch
            {
                MessageBox.Show("Row not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            try
            {
                if (Choosetable.SelectedIndex == 0)
                {
                    if (MessageBox.Show("Are you wand to delete record?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int id = int.Parse(dataGridView.Rows[Convert.ToInt32(selectRow)].Cells[0].Value.ToString());
                        DepartmentRep.Delete(id);
                        selectRow = (Convert.ToInt32(selectRow) - 1).ToString();
                        Display();
                    }
                }
                if (Choosetable.SelectedIndex == 1)
                {
                    if (MessageBox.Show("Are you wand to delete record?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int id = int.Parse(dataGridView.Rows[Convert.ToInt32(selectRow)].Cells[0].Value.ToString());
                        EmployeeRep.Delete(id);
                        selectRow = (Convert.ToInt32(selectRow) - 1).ToString();
                        Display();
                    }
                }
            }
            catch { }
        }

        private void Choosetable_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            selectRow = "0";
            searchtext.Clear();

            Display();
        }
    }
}
