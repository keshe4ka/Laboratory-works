using System;

namespace lb7_task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину пароля: ");
            int length = Convert.ToInt32(Console.ReadLine());
            GeneratePassword(length);
        }

        /// <summary>
        /// Генерирует пароль из заглавных латинских букв
        /// </summary>
        /// <param name="length">Длина пароля</param>
        public static void GeneratePassword(int length)
        {
            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                Random rnd = new Random();
                password[i] = (char)rnd.Next(65, 91);
            }
            Console.WriteLine(password);
        }
    }
}
