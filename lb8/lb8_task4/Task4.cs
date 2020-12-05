using System;
using System.Text.RegularExpressions;

namespace lb8_task4
{
    class Task4
    {
        //Написать регулярное   выражение(или набор   регулярных выражений),
        //проверяющее, является ли введенная строка надежным паролем.
        //Требования к паролю:длина от 6 символов, обязательно наличие цифры, строчной и прописной 
        //буквылатинского алфавита.Если требования не выполнены, запрашивать повторный
        //ввод дотех пор, пока пароль не будет соответствовать требованиям
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пароль \n(должен содержать латинские строчные и прописные буквы, иметь числа, а также быть длиной не менее 6 символов: ");
            string user_string = Console.ReadLine();
            CheckPassword(user_string);
        }

        public static void CheckPassword(string user_string)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{6,}$";
            Regex regex = new Regex(pattern);
            Match matches = regex.Match(user_string);
            if (matches.Success)
            {
                Console.WriteLine("Пароль надежен");
            }
            else
            {
                Console.WriteLine("Ненадженый пароль, попробуйте снова");
                string password = Console.ReadLine();
                CheckPassword(password);
            }

        }
    }
}
