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
            //requests user input
            Console.WriteLine("Enter date and time in any format (eg. mm/dd/yyy and 12:00) : ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter another date and time: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            
            //calculates the time duration between the two user inputs
            TimeSpan diff = (firstDate - secondDate).Duration();

            //displays the time duration in days, hours, and minutes
            Console.WriteLine("Days : " + diff.TotalDays.ToString());
            Console.WriteLine("Hours : " + diff.TotalHours.ToString());
            Console.WriteLine("Minutes : " + diff.TotalMinutes.ToString());
           

        }
      
    }


    
}
