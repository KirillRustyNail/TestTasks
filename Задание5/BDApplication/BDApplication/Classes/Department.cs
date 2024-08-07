using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDApplication.Classes
{
    class Department
    {
        public int ID_Department { get; set; }
        public string Name { get; set; }

        public Department(int ID_Department, string Name)
        {
            this.ID_Department = ID_Department;
            this.Name = Name;   
        }
    }
}
