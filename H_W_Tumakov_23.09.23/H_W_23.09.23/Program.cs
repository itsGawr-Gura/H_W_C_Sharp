using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_23._09._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 4.1 дата по числу.
            Console.WriteLine("Задание 4.1 дата по числу.");
            Console.WriteLine("Введите число от 1 до 365");
            string str = Console.ReadLine();
            try
            {
                int date = int.Parse(str);
                if (date > 0 && date < 366)
                {
                    DateTime date1 = new DateTime(2023,12,31);
                    int month = date1.AddDays(date).Month;
                    int day = date1.AddDays(date).Day;
                    Console.WriteLine($"Сейчас {month} месяц и {day} число");
                }
                else
                    Console.WriteLine("В году 365 дней, повторите попытку.");

            }
            catch (System.FormatException)
            {
                Console.WriteLine("Неверный формат ввода, повторите попытку.");
            }
           // Задание 4.3 дата учитывая год
           Console.WriteLine("Задание 4.3 дата учитывая год");
            Console.WriteLine("Введите текущий год");
            str = Console.ReadLine();
             int year = int.Parse(str);
            Console.WriteLine("Введите число от 1 до 365");
            str = Console.ReadLine();
            int day1 = int.Parse(str);
            if (day1 > 0 && day1 < 366)
            {
                try
                {
                    int a = year % 4;
                    int b = year % 100;
                    int c = year % 400;
                    int d = year % 80;
                    
                    if ((a == 0 && b != 0) || c == 0)
                    {
                        DateTime date1 = new DateTime(2019, 12, 31);
                        int month = date1.AddDays(day1).Month;
                        int day = date1.AddDays(day1).Day;
                        Console.WriteLine($"Сейчас {year} год {month} месяц и {day} число. Год високосный");
                    }
                    else
                    {
                        DateTime date1 = new DateTime(2022, 12, 31);
                        int month = date1.AddDays(day1).Month;
                        int day = date1.AddDays(day1).Day;
                        Console.WriteLine($"Сейчас {year} год {month} месяц и {day} число. Год не високосный");
                    }


                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Неверный формат ввода, повторите попытку.");
                }

            }
            else
                Console.WriteLine("В году 365 дней, повторите попытку.");
            
            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
