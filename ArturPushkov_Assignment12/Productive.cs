using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturPushkov_Assignment12
{
    public class Productive : EmployeeClass
    {
        public Productive(string name, int id, int shift, decimal HourlyPayment) : base(name, id)
        {
            shiftNum = shift;
            paymentInHour = HourlyPayment;
        }
        public int shiftNum { get; set; }
        public decimal paymentInHour { get; set; }

        public override string ToString()
        {
            return base.ToString() + "Shift: " + shiftNum + "\r\n" + "Hourly Pay: " + paymentInHour + "\r\n";
        }
    }
}
