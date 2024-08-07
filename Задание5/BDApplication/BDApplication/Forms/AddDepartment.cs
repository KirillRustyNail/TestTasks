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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BDApplication.Forms
{
    public partial class AddDepartment : Form
    {
        private readonly MainForm _parent;
        public string name;
        public int id;
        IRepository<Department> DepartmentRep;
        public AddDepartment(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;
            DepartmentRep = new SQLDepartmentRepository();
        }
        public void UpdateInfo()
        {
            BtnSave.Text = "Update";
            name_text.Text = name;
        }

        public void SaveInfo()
        {
            BtnSave.Text = "Save";
        }

        public void Clear()
        {
            name_text.Text = string.Empty;
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (!(String.IsNullOrEmpty(name_text.Text.ToString())))
                {
                    Department item = new Department(0, name_text.Text);
                    if (BtnSave.Text == "Save")
                    {
                        DepartmentRep.Create(item);
                        Clear();
                    }
                    if (BtnSave.Text == "Update")
                    {
                        DepartmentRep.Update(item,id);

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
