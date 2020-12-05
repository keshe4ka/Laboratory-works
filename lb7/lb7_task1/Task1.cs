using System;

namespace lb7
{
    class Task1
    {
        static void Main(string[] args)
        {
            Task_1_1();
            Task_1_2();
        }

        // Программа, выводящая на консоль количество символов строки
        // с учетом пробелов и без
        public static void Task_1_1()
        {
            Console.WriteLine("Пожалуйста, введите хоть что-нибудь, хоть каких-нибудь словечек...");
            string user_string = Console.ReadLine();
            int length_without_spaces = 0;
            Console.WriteLine("Количество символов: " + user_string.Length);
            for (int i = 0; i < user_string.Length; i++)
            {
                if (user_string[i] != ' ')
                {
                    length_without_spaces++;
                }
            }
            Console.WriteLine("Количество символов без учета пробелов: " + length_without_spaces);
        }

        // Программа, выводящая все позиции на которых находится искомый символ
        public static void Task_1_2()
        {
            Console.WriteLine("Пожалуйста, введите хоть что-нибудь, хоть каких-нибудь словечек...");
            string user_string = Console.ReadLine();
            Console.WriteLine("Какой символ будем искать?");
            char search = Console.ReadLine()[0];
            bool flag = false;
            Console.WriteLine("Данный символ находится на позиции: ");
            for (int i = 0; i < user_string.Length; i++)
            {
                if (user_string[i] == search)
                {
                    Console.WriteLine(i);
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("К сожалению, данный символ отсутствует в строке");
            }
        }
    }
}
