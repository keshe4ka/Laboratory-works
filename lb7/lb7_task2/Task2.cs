using System;
using System.Text.RegularExpressions;

namespace lb7_task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            // Объявил здесь, чтоб введенная строка не слетела при неправильном вводе типа регистра
            Console.WriteLine("Введите строку: ");
            string user_string = Console.ReadLine();
            Task_2_1(user_string);
            Task_2_2(user_string);
        }

        // Меняет регистр строки, введенный пользователем
        public static void Task_2_1(string user_string)
        {
            // Ошибиться при вводе числа намного сложнее, чем при вводе слова, поэтому вот так
            Console.WriteLine("На какой регистр вы хотите поменять строку? " +
                "\n Введите число: " +
                "\n 1 - верхний | Пример: было - текст, стало - ТЕКСТ " +
                "\n 2 - нижний | Пример: было - ТЕКСТ, стало - текст " +
                "\n 3 - инвертированный | Пример: было - ТЕКст, стало - текСТ ");
            int type = Convert.ToInt32(Console.ReadLine());
            switch (type)
            {
                case 1:
                    Console.WriteLine("Строка в верхнем регистре: \n" + user_string.ToUpper());
                    break;
                case 2:
                    Console.WriteLine("Строка в верхнем регистре: \n" + user_string.ToLower());
                    break;
                case 3:
                    char[] swap = user_string.ToCharArray();
                    char[] swapUpper = user_string.ToUpper().ToCharArray();
                    char[] swapLower = user_string.ToLower().ToCharArray();
                    for (int i = 0; i < swap.Length; i++)
                    {
                        if (swap[i] == swapUpper[i])
                        {
                            swap[i] = swapLower[i];
                        }
                        else
                        {
                            swap[i] = swapUpper[i];
                        }
                    }
                    user_string = swap.ToString();
                    Console.WriteLine(user_string);
                    break;
                default:
                    Console.WriteLine("Вы ввели неправильное число, попробуйте снова");
                    Task_2_1(user_string);
                    break;
            }
        }

        // Программа, обрезающая пробелы в начале и конце строки, а также заменяющая два и более идущих последовательно пробела на один
        public static void Task_2_2(string user_string)
        {
            // Возможно, что здесь нужно было решение с использованием цикла и проверкой повторяющихся пробелов,
            // но я воспользовался регулярным выражением
            user_string = Regex.Replace(user_string.Trim(), @"\s+", " ");
            Console.WriteLine(user_string);
        }
    }
}
