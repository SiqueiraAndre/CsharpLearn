using System;
using System.Globalization;

namespace date_time {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);


            Console.WriteLine();
            DateTime d4 = DateTime.Parse("2000-08-15");
            DateTime d5 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d6 = DateTime.Parse("15/08/2000");
            DateTime d7 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);

            Console.WriteLine();
            DateTime d8 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d9 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
            CultureInfo.InvariantCulture);
            Console.WriteLine(d8);
            Console.WriteLine(d9);

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine();
            Console.WriteLine("-------------------------");
            DateTime dt2 = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = dt2.ToLongDateString();
            string s2 = dt2.ToLongTimeString();
            string s3 = dt2.ToShortDateString();
            string s4 = dt2.ToShortTimeString();
            string s5 = dt2.ToString();
            string s6 = dt2.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = dt2.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

        }
    }
}
