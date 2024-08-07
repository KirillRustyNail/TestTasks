using BDApplication.Classes;
using BDApplication.Repositores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BDApplication.Forms
{
    public partial class AddEmployee : Form
    {
        private readonly MainForm _parent;
        public string name;
        public int id , Department_id, Chief_id , Salary;
        IRepository<Employee> EmployeeRep;
        public AddEmployee(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;
            EmployeeRep = new SQLEmployeeRepository();
        }
        public void UpdateInfo()
        {
            BtnSave.Text = "Update";
            Department_id_text.Text = Department_id.ToString();
            Chief_id_text.Text = Chief_id.ToString();
            Salary_text.Text = Salary.ToString();   
            Name_text.Text = name;
        }

        public void Clear()
        {
            Department_id_text.Text = Chief_id_text.Text = Salary_text.Text = Name_text.Text = string.Empty;
        }

        public void SaveInfo()
        {
            BtnSave.Text = "Save";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (!(String.IsNullOrEmpty(Name_text.Text.ToString())) &&
                    !(String.IsNullOrEmpty(Department_id_text.Text.ToString())) &&
                    !(String.IsNullOrEmpty(Chief_id_text.Text.ToString())) &&
                    !(String.IsNullOrEmpty(Salary_text.Text.ToString())))
                {
                    Employee item = new Employee(0, int.Parse(Department_id_text.Text.ToString()),
                        int.Parse(Chief_id_text.Text.ToString()),
                        Name_text.Text.ToString(), 
                        int.Parse(Salary_text.Text.ToString()));

                    if (BtnSave.Text == "Save")
                    {
                        EmployeeRep.Create(item);
                        Clear();
                    }
                    if (BtnSave.Text == "Update")
                    {
                        EmployeeRep.Update(item, id);

                    }
                    _parent.Display();
                }
                else
                {
                    MessageBox.Show("Data entered incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Data entered incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
