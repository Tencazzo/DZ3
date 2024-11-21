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
        enum Day { 
            Monday, 
            Tuesday, 
            Wednesday, 
            Thursday, 
            Friday, 
            Saturday, 
            Sunday }
        //1 задание 
        static void CheckIn(int[] nums)
        {
            int number = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] >= nums[i])
                {
                    number++;
                }
                else
                {
                    Console.WriteLine(number + 1);
                    return;
                }
            }
            Console.WriteLine("Возрастающая");
        }
        //2 задание
        static void GetCard()
        {
            string[] cards = { "six", "seven", "eight", "nine", "ten", "vallet", "dame", "king", "tuz" };
            try
            {
                Console.WriteLine("Введите номер карты:");
                int k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат: " + cards[k - 6]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Это НЕ число!!!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Введите ПРАВИЛЬНЫЙ номер карты!!!");
            }
            finally
            {
                Console.WriteLine("Спасибо за попытку!");
            }
        }
        //3
        static void GetDrink()
        {
            Console.WriteLine("Введите данные");
            string s1 = Console.ReadLine();
            switch (s1.ToLower())
            {
                case "jarboni":
                    Console.WriteLine("Patrol Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("You tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
        }
        //4 задание
        static void GetDay()
        {
            try
            {
                Console.Write("Введите порядковый номер дня ");
                var n = int.Parse(Console.ReadLine());
                int g = n % 7;
                if (g == 0)
                {
                    Console.WriteLine((Day)6);
                }
                else
                {
                    Console.WriteLine((Day)(g - 1));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Это НЕ число!!!");
            }
        }
        static int CountDolls(string[] dolls)
        {
            int result = 0;
            foreach (string n in dolls)
            {
                if (n == "Hello Kitty" || n == "Barbie doll")
                {
                    result++;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Задание 1");
                int[] nums = { 1, 3, 6, 8, 9, 10, 8, 12, 88, 100 };
                CheckIn(nums);
                Console.WriteLine("Задание 2");
                GetCard();
                Console.WriteLine("Задание 3");
                GetDrink();
                Console.WriteLine("Задание 4");
                GetDay();
                Console.WriteLine("Задание 5");
                string[] dolls = { "Hello Kitty", "Hello Kitty", "fafa", "aflakjf", "ahfj", "Barbie doll", "Barbie doll", "Barbie doll" };
                int result = CountDolls(dolls);
                Console.WriteLine($"Количество кукол Hello Kitty и Barbie doll: {result}");
            }
        }
    }
}
