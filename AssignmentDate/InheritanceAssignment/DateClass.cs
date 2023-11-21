using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDate.InheritanceAssignment
{
    class DateClass
    {
        public void Dates(string datee)
        {


            string[] result = datee.Split('/');
            int day, month, year;
            day = Convert.ToInt32(result[0]);
            // Console.WriteLine(day);
            month = Convert.ToInt32(result[1]);
            // Console.WriteLine(month);
            year = Convert.ToInt32(result[2]);
            //  Console.WriteLine(year);
            if (day <= 31 && month <= 12)
            {
                if (day <= 24 && month <= 12)
                {
                    day = day + 7;

                }
                else if (day > 24 && month < 12)
                {
                    day += 7;
                    day = day - 31;
                    month += 1;

                }
                else if (day > 24 && month == 12)
                {
                    day += 7;
                    day = day - 31;
                    month -= 11;
                    year += 1;
                }
                else
                {
                    Console.WriteLine("Days must be less than 31,Month must be less than 12 .............");
                }

            }
            else
            {
                Console.WriteLine("Dates will be given in day/month/year format");
                return;
            }

            Console.WriteLine("{0}/{1}/{2}", day, month, year);

        }
    }
}
