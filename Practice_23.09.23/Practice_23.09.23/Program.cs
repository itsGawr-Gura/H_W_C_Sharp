using System;

namespace Practice_23._09._23
{
    enum weeks
    {
        понедельник = 1,
        вторник = 2,
        среда = 3,
        четверг = 4,
        пятница = 5,
        суббота = 6,
        воскресенье = 7
    }
    internal class Program

    {
        static void Main(string[] args)
        {
            // Задание 1 Последовательность из 10 чисел
            Console.WriteLine("Задание 1 Последовательность из 10 чисел");
            int[] array = new int[11];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int value = rnd.Next();
                array[i] = rnd.Next();
            }
            /*array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5; //Для проверки в случае если все числа идут по возрастанию
            array[5] = 6;
            array[6] = 7;
            array[7] = 8;
            array[8] = 9;
            array[9] = 10;*/
            int[] value1 = new int[11];
            for (int i = 0; i < 10; i++)
            {
                if (array[i] > array[i + 1])
                {
                    value1[i] = array[i + 1];
                }
                else value1[i] = 0;
            }
            int x = 0;
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            foreach (int value in value1)
            {
                x++;
                if (value > 0)
                {
                    Console.WriteLine("Порядковый номер первого числа неудовлетворяющего условию - " + x);
                    break;
                }
                else if (x > 10)
                    Console.WriteLine("Все числа идут по возростанию");
            }


            // Задание 2 Достоинства карт
            Console.WriteLine("Задание 2 Достоинства карт");
            Console.WriteLine("Введите достоинство карты от 6 до 14");
            try
            {
                int dignity = int.Parse(Console.ReadLine());
                if (dignity > 5 && dignity < 15)
                {
                    switch (dignity)
                    {
                        case 6:
                            Console.WriteLine("Ваша карта - шестёрка");
                            break;
                        case 7:
                            Console.WriteLine("Ваша карта - семёрка");
                            break;
                        case 8:
                            Console.WriteLine("Ваша карта - восьмёрка");
                            break;
                        case 9:
                            Console.WriteLine("Ваша карта - девятка");
                            break;
                        case 10:
                            Console.WriteLine("Ваша карта - десятка");
                            break;
                        case 11:
                            Console.WriteLine("Ваша карта - валет");
                            break;
                        case 12:
                            Console.WriteLine("Ваша карта - дама");
                            break;
                        case 13:
                            Console.WriteLine("Ваша карта - король");
                            break;
                        case 14:
                            Console.WriteLine("Ваша карта - туз");
                            break;
                    }
                }
                else
                    Console.WriteLine("карты с таким достоинством нет, повторите попытку.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Неверный формат ввода, повторите попытку.");
            }


            //Задание 3 input-output
            Console.WriteLine("Задание 3 input-output");
            Console.WriteLine("Введите вашу строку");
            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
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
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }


            // Задание 4 Дни недели
            Console.WriteLine("Задание 4 Дни недели");
            Console.WriteLine("Введите порядковый номер дня недели");
            try
            {
                int day = int.Parse(Console.ReadLine());
                if (day > 0 && day < 8)
                {
                    Console.WriteLine((weeks)day);
                }
                else
                    Console.WriteLine("Такого порядкового номера дня недели не существует, повторите попытку.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Неверный формат ввода, повторите попытку");
            }


            // Задание 5 Массив строк
            Console.WriteLine("Задание 5 Массив строк");
            string[] strArr = new string[7];
            strArr[0] = "Hello Kitty";
            strArr[1] = "Nothing";
            strArr[2] = "Hello";
            strArr[3] = "Barbie Doll";
            strArr[4] = "Hello Kitty";
            strArr[5] = "Barbie";
            strArr[6] = "Barbie Doll";
            int o = 0;
            foreach (string str in strArr)
            {
                if (str == "Barbie Doll" || str == "Hello Kitty")
                    o++;
            }
            Console.WriteLine($"Количество повторений данных элементов в массиве = {o}");
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }


}
