using System;

namespace LeapYearAnnounce
{
    internal class LeapYear
    {
        static int currentYear;
        public LeapYear(int year)
        {
            currentYear = year;
        }

        public void PrintLeapYears()
        {
            for (int y = currentYear; y <= 2104; y++)
            {
                if (DateTime.IsLeapYear(y))
                {
                    Console.WriteLine($"{y} is a leap year");
                }
            }
        }
    }
}
