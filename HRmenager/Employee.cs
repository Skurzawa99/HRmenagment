using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRmenager
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DateToEmployee { get; set; }
        public string DateDismiss { get; set; }       
        public int Money { get; set; }
        public string Comments { get; set; }    
        public int GroupId { get; set; }
    }
}
