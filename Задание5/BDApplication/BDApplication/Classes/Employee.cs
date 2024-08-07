using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDApplication.Classes
{
    class Employee
    {
        public int Id { get; set; } 
        public int DEPARTMENT_ID { get; set; }
        public int CHIEF_ID { get; set; }
        public string Name { get; set; }
        public int SALARY {  get; set; }

        public Employee(int Id , int DEPARTMENT_ID, int CHIEF_ID, string Name, int SALARY)
        {
            this.Id = Id;
            this.DEPARTMENT_ID = DEPARTMENT_ID;
            this.CHIEF_ID = CHIEF_ID;
            this.Name = Name;  
            this.SALARY = SALARY;
        }
    }
}
