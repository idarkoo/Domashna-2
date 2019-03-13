using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomashnaDatesDarkoIvanovskiG2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 4
            Console.WriteLine(DateTime.Now.AddDays(3));
            Console.WriteLine(DateTime.Now.AddMonths(1));
            Console.WriteLine(DateTime.Now.AddMonths(1).AddDays(3));
            Console.WriteLine(DateTime.Now.AddYears(-1).AddMonths(-2));
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.ToString("MMMM"));
            Console.ReadLine();
            #endregion

            #region Exercise 5
            Console.Write("Year of birth:");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Month:");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Day:");
            int day = int.Parse(Console.ReadLine());

            var birthday = new DateTime(year, month, day);
            var age = AgeCalculator(birthday);

            Console.WriteLine(age);

            Console.ReadLine();
        }
        static int AgeCalculator(DateTime birthday)
        {
            int age = 0;
            age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.DayOfYear < birthday.DayOfYear)
            {
                age--;
            }
            return age;
        }
        #endregion

    }
}
