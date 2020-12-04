using System;
using System.Text.RegularExpressions;

namespace lb7_task3
{
    class Task3
    {
        //Программа, разделяющая введенный текст на предложения, 
        //каждое выводится на отдельной строке без пробелов по краям 
        //и без знаков препинания в конце предложения. Конец предложения   
        //определяется символом точка,вопросительный знак, восклицательный знак или их комбинацией. 

        //Во время выполнения третьей задачи, я осознал, что цифры рядом с заданием означают варианты, 
        //а не подзадачу задачи
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
