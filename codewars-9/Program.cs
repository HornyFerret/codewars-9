using System;

namespace codewars_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------");
            int w = СenturyFromYear(year);
            Console.WriteLine(w);
        }
        public static int СenturyFromYear(int year)
        {
            int cen = year % 100;
            if (cen>0)
            {
                int r = (year / 100) + 1;
                return r;
            }
            else if (cen == 0)
            {
                int r = year / 100;
                return r;
            }
            else
            {
                return year;
            }
        }
        
    }
}
