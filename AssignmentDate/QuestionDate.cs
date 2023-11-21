using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDate
{
    class QuestionDate
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
            if (day <= 31 && month <= 12&&year<=9999)
            {
                if (day <= 24 && month <= 12)
                {
                    day = day + 7;

                }
                else if (day > 24 && month < 12)
                {
                    day +=7;
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
           
            Console.WriteLine("After a Week date : {0}/{1}/{2}",day,month,year);


            //days = Convert.ToInt32(datee.Substring(0,2));
            //Console.WriteLine(days);
            //months = Convert.ToInt32(datee.Substring(4,6));
            //Console.WriteLine(months);
            //years = Convert.ToInt32(datee.Substring(6,10));
            //Console.WriteLine(years);
            //Console.WriteLine("{0} \n {1}\n {2}",days,months,years);

        }
        public void Samewords()
        {
            Console.WriteLine("Enter a string.......... ");
            string st1 = Console.ReadLine(); 
            char[] charArray = st1.ToCharArray();
          //  Console.WriteLine(charArray);
            List<char> charList = new List<char>(charArray);
          //  Console.WriteLine(charList[1]);
            int result = 0;
            int space = 0;
            for (int i = 1; i < charList.Count; i++)
            {
                if (charList[i] == ' ')
                {
                    space++;
                    if (charList[i] == ' ' && charList[i - 1] == charList[i + 1])
                    {



                        Console.WriteLine($"Characters '{charList[i - 1]}' and '{charList[i + 1]}' match before space.");


                        result++;


                    }
                }
            }
            if(result==space)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");

            }
           // Console.WriteLine(result);
          


            //for (int i = 0; i <= s.Length-1; i++)
            //{
            //   for(int j = 0; j < s[0].Length; j++)
            //    {
            //        if (s[j] == s[1])
            //        {

            //        }
            //    }

            //Console.Write(s[i]);
            //}
            //if (st1[0] != st1[1])
            //{

            //}
        }
        public void NaturalSum()
        {
            Console.Write("Enter the number of terms : ");
            int terms = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= terms; i++)
            {
                Console.WriteLine($"The Square of Natural Number {i}  =  {i*i}");
                sum = (i * i)+sum;
            }
            Console.WriteLine($"\nThe Sum of Natural Number Terms  is : {sum}");
        }
        public void OvertimePay()
        {
            double[] overtime = { 13.25, 15, 30, 1.5 };
           // Console.WriteLine(overtime[0]);
            double StartWork = Convert.ToDouble(overtime[0]);
            double EndWork = Convert.ToDouble(overtime[1]);
            double Rate = Convert.ToDouble(overtime[2]);
            double MultipleOvertime = Convert.ToDouble(overtime[3]);
            double hours = EndWork-StartWork;
            double result;


            if (StartWork>=9&&EndWork<=17)
            {
                hours = Convert.ToDouble( hours * Rate);
                Console.WriteLine($"Your Pay is {hours} $");
                
            }
            else if (StartWork >= 9 && EndWork >= 17)
            {
                hours = EndWork - 17;
                Rate = Convert.ToDouble(hours * Rate);
                MultipleOvertime = Convert.ToDouble(hours*30*MultipleOvertime);
                result = Rate + MultipleOvertime;
                Console.WriteLine($"Your Pay is {result} $");


            }
            else
            {
                Console.WriteLine("invalid statement................");
            }


        }
        public void FindElementSort()
        {
            int[] consecutiveNum = new int[] { 5, 1, 4, 3, 2 };
            int temp = 0;
            int i = 0;
            bool r = true;
            for (; i <= consecutiveNum.Length - 1; i++)
            {
                for (int j = i + 1; j < consecutiveNum.Length; j++)
                {
                    if (consecutiveNum[i] > consecutiveNum[j])
                    {
                        temp = consecutiveNum[i];
                        consecutiveNum[i] = consecutiveNum[j];
                        consecutiveNum[j] = temp;

                    }
                }
            }
           
          //  Console.WriteLine(intArray[0]);
            
            //1234
            for (int k=1; k < consecutiveNum.Length; k++)
            {
                // Console.WriteLine(intArray[0]);
                if (consecutiveNum[k] != consecutiveNum[k - 1] + 1)
                {
                    r = false;
                    break;
                }
                
            }
            if (r==false)
                Console.WriteLine("False");
            else
                Console.WriteLine("True");

             
           
            Console.ReadLine();
            //int[] originalArray = { 1, 2, 3, 4, 5 };-----------
            //int[] newArray = new int[originalArray.Length - 1];

            //for (int i = 0; i < newArray.Length; i++)
            //{
            //    newArray[i] = originalArray[i];
            //    Console.WriteLine(newArray[i]);
            //}


           
            //int[] compare = new int[5];
            //int min = numbers[0];
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + "  ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("=================================");
            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] < min)
            //    {

            //        compare[i] = numbers[i];
            //        //compare.CopyTo(numbers[i]);

            //      //  compare[i] = Convert.ToInt32(Console.ReadLine(numbers[i]));
            //        min = numbers[i];
            //    }
            //}
            //Console.WriteLine("Max Value in Array :" + min);
            Console.ReadKey();
        }

    }
}
