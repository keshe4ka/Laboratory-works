using System;
using System.Text.RegularExpressions;

namespace lb8_task2
{
    class Task2
    {
        //Написать регулярное   выражение,   
        //заменяющее слова   «редиска»   и фразу«нехороший человек» 
        //(и то и другое в любых склонениях и числе) на текст «*давайтежить дружно*».
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string user_string = Console.ReadLine();
            Censor(user_string);
        }

        public static void Censor(string user_string)
        {           
            string pattern = @"(редиск\w*)|(нехорош\w*\sчеловек\w*)";
            Regex regex = new Regex(pattern);
            user_string = regex.Replace(user_string, "*давайте жить дружно*");
            Console.WriteLine(user_string);
        }
    }
}
