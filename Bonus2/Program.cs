using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the age calculator!");


            Console.Write("Please enter your birth year: ");
            string YearInput = Console.ReadLine();

            Console.Write("Please enter your birth month (01 to 12): ");
            string MonthInput = Console.ReadLine();

            Console.Write("Please enter your birth day (01 to 31): ");
            string DayInput = Console.ReadLine();

            string DateTimeParser;
            DateTimeParser = $"{MonthInput}/{DayInput}/{YearInput}";

            DateTime birthDay;
            birthDay = DateTime.Parse(DateTimeParser);

            TimeSpan age = DateTime.Today - birthDay;


            double Years;
            DateTime previousYear = DateTime.Today.AddYears(-1);

            string previousYearBirthday = $"{MonthInput}/{DayInput}/{previousYear.Year}";
            
            Years = (DateTime.Today.Year - birthDay.Year) - 1;

            DateTime lastBirthDay = DateTime.Parse(previousYearBirthday);
            TimeSpan lastYearSpan = DateTime.Today - lastBirthDay;

            if (lastYearSpan.Days == 365 && LeapYear(previousYear) == false)
            {
                Years++;
                Console.WriteLine($"You just turned {Years} years old. Happy Birthday!");
            }
            else if (lastYearSpan.Days == 366)
            {
                Years++;
                Console.WriteLine($"You just turned {Years} years old. Happy Birthday!");
            }
            else if (lastYearSpan.Days == 365 && LeapYear(previousYear) == true)
            {
                Console.WriteLine($"You are {Years} years and {lastYearSpan.Days} days old. Leap years are fun!");
            }
            else
            {
                Console.WriteLine($"You are {Years} years {lastYearSpan.Days} old!");
            }

            Console.ReadLine();

        }

        public static bool LeapYear(DateTime lastYear)
        {
            DateTime previousYear = DateTime.Today.AddYears(-1);
            int year = previousYear.Year;
            if (DateTime.IsLeapYear(year) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
