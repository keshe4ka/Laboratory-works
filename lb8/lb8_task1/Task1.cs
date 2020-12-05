using System;
using System.Text.RegularExpressions;

namespace lb8
{
    class Program
    {
        //Написать регулярное выражение, разделяющее строку на предложения и вывестикаждое   предложение с   новой строки.
        //Признак   конца предложения:   точка, вопросительный знак, восклицательный знак, многоточие.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string user_string = Console.ReadLine();
            SentenceDivider(user_string);
        }

        /// <summary>
        /// Разделяет введенный текст на предложения
        /// </summary>
        /// <param name="user_string">текст</param>
        public static void SentenceDivider(string user_string)
        {
            string[] sentences = Regex.Split(user_string, @"(?<=[\.!\?])\s+");
            foreach (string sentence in sentences)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}

