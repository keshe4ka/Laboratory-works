using System;
using System.Text.RegularExpressions;

namespace lb8_task3
{
    class Task3
    {
        //Написать регулярное выражение, выделяющее из строки все даты в форматедд.мм.гггг и выводящее их на экран.
        //Вместо дд и мм может быть от 1 до 2 чисел, вместогггг 2 или 4 числа.Месяц может быть от 1 до 12, день может быть от 1 до 31.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string user_string = Console.ReadLine();
            CheckDateFormat(user_string);
        }

        public static void CheckDateFormat(string user_string)
        {
            string pattern = @"([0-2][0-9]|[1-9]|[3][0-1])\.([1][0-2]|[0][1-9]|[1-9])\.([0-9]{2}|[0-9]{4})";
            Regex regex = new Regex(pattern);
            //для поиска подстрок
            Match matches = regex.Match(user_string);            
            while (matches.Success)
            {
                Console.WriteLine(matches);
                matches = matches.NextMatch();
            }

        }
    }
}
