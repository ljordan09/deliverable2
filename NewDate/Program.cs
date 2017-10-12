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

            Dates();
            Console.ReadLine();         

        }

        public static void Dates()
        {

            Console.WriteLine("Enter any date: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter another date: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            TimeSpan diff = (firstDate - secondDate).Duration();
            
            Console.WriteLine("Days : " + diff.TotalDays.ToString());
            Console.WriteLine("Hours : " + diff.TotalHours.ToString());
            Console.WriteLine("Minutes : " + diff.TotalMinutes.ToString());
           

        }
      
    }


    
}
