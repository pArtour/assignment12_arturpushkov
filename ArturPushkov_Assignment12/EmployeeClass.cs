using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturPushkov_Assignment12
{
    public class EmployeeClass
    {
        public EmployeeClass(string name, int id)
        {
            emplName = name;
            emplNumber = id;
        }
        public string emplName { get; set; }
        public int emplNumber { get; set; }

        public override string ToString()
        {
            return "Name: " + emplName + "\r\n" + "Id: " + emplNumber + "\r\n";
        }
        
    }
}
