using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class festivalCalendar
    {
        public void festivalnameChecker(string name)
        {

            string festivalname = name switch
            {
                "JAN" => "Pongal",
                "FEB" => "Valentines Day",
                "MARCH" => "No festival",
                "APRIL" => "No festival",
                "MAY" => "No festival",
                "JUNE" => "No Fstival",
                "JULY" => "No festival",
                "AUGUST" => "Rakhi",
                "SEPT" => "NAVRATRI",
                "OCT" => "Diwali",
                "NOVEMEBER" => "No festival",
                "DEC" => "CHRISTMAS",
                _ => "NOT FOUND",

            };

            Console.WriteLine(festivalname);
        }
    }
}
