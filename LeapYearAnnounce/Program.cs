using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearAnnounce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeapYear leapYear = new LeapYear(2015);

            leapYear.PrintLeapYears();
        }
    }
}
