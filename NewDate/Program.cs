using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDate
{
    class Program
    {
        static void Main(string[] args)
        {

            DateDiff();
            Console.ReadLine();
           

            

        }

        public static void DateDiff()
        {

            Console.WriteLine("Enter any date: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter another date: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            TimeSpan difference = firstDate - secondDate;
            
            Console.WriteLine("Days : " + difference.TotalDays.ToString());
            Console.WriteLine("Hours : " + difference.TotalHours.ToString());
            Console.WriteLine("Minutes : " + difference.TotalMinutes.ToString());
           

        }
      
    }

    
}
