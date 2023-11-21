using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDate.InheritanceAssignment
{
    class OvertimeSalary:SumNaturalNum
    {
        public void OvertimePay()
        {
            double[] overtime = { 13.25, 15, 30, 1.5 };
            // Console.WriteLine(overtime[0]);
            double StartWork = Convert.ToDouble(overtime[0]);
            double EndWork = Convert.ToDouble(overtime[1]);
            double Rate = Convert.ToDouble(overtime[2]);
            double MultipleOvertime = Convert.ToDouble(overtime[3]);
            double hours = EndWork - StartWork;
            double result;


            if (StartWork >= 9 && EndWork <= 17)
            {
                hours = Convert.ToDouble(hours * Rate);
                Console.WriteLine($"Your Pay is {hours} $");

            }
            else if (StartWork >= 9 && EndWork >= 17)
            {
                hours = EndWork - 17;
                Rate = Convert.ToDouble(hours * Rate);
                MultipleOvertime = Convert.ToDouble(hours * 30 * MultipleOvertime);
                result = Rate + MultipleOvertime;
                Console.WriteLine($"Your Pay is {result} $");


            }
            else
            {
                Console.WriteLine("invalid statement................");
            }


        }
    }
}
