using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Упражнение 4.1");
                Console.WriteLine("Введите год");
                int year1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число");
                int date1 = Convert.ToInt32(Console.ReadLine());
                DateTime Time1 = new DateTime(year1, 1, 1);
                Time1 = Time1.AddDays(date1 - 1);
                Console.WriteLine($"Этот день соотвествует - {Time1.Day} {Time1.Month} {year1} не високосный год");
                Console.WriteLine("Упражнение 4.2");
                int year2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число");
                int date2 = Convert.ToInt32(Console.ReadLine());
                if (date2 > 0 && date2 < 366)
                {
                    DateTime Time = new DateTime(year2, 1, 1);
                    Time = Time.AddDays(date2 - 1);
                    Console.WriteLine($"Этот день соотвествует - {Time.Day} {Time.Month} {year2} високосный год ");
                }
                else
                {
                    Console.WriteLine("Введите число от 1 до 366!");
                }
                Console.WriteLine("Домашнее задание 4.1");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число");
                int date = Convert.ToInt32(Console.ReadLine());
                if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                {
                    if (date > 0 && date < 366)
                    {
                        DateTime Time = new DateTime(year, 1, 1);
                        Time = Time.AddDays(date - 1);
                        Console.WriteLine($"Этот день соотвествует - {Time.Day} {Time.Month} {year} високосный год ");
                    }
                    else
                    {
                        Console.WriteLine("Введите число от 1 до 366!");
                    }
                }
                else
                {
                    if (date > 0 && date < 366)
                    {
                        DateTime Time = new DateTime(year, 1, 1);
                        Time = Time.AddDays(date - 1);
                        Console.WriteLine($"Этот день соотвествует - {Time.Day} {Time.Month} {year} не високосный год");
                    }
                    else
                    {
                        Console.WriteLine("Введите число от 1 до 365!");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
