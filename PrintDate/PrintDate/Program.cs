using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDate
{
    class DateClass
    {
        int day, month, year;
        public int Day
        {
            get { return day; }
            set
            {
                if (value < 1 && value > 31)
                {
                    Console.WriteLine("you enterd wrong value of Date");
                }

                else
                {
                    day = value;
                }


            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 && value > 12)
                {
                    Console.WriteLine("you enterd wrong Month");
                }

                else
                {
                    month = value;
                }
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 2011 && value > 2020)
                {
                    Console.WriteLine("you enterd wrong Year");
                }

                else
                {
                    year = value;
                }
            }
        }
    }

        class Program
        { 
        static void Main()
        {
            DateClass dateObj = new DateClass();
            Console.WriteLine("enter Day");
            dateObj.Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Month");
            dateObj.Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Year");
            dateObj.Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The Date is : {dateObj.Day}/{dateObj.Month}/{dateObj.Year}");
            
        }
        }
}
