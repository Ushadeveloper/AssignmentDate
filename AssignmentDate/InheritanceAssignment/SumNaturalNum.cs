using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDate.InheritanceAssignment
{
    class SumNaturalNum:DateClass
    {
        public void NaturalSum()
        {
            Console.Write("Enter the number of terms : ");
            int terms = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= terms; i++)
            {
                Console.WriteLine($"The Square of Natural Number {i}  =  {i * i}");
                sum = (i * i) + sum;
            }
            Console.WriteLine($"\nThe Sum of Natural Number Terms  are  : {sum}");
        }
    }
}
