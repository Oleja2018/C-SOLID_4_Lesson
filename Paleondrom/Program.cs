using System;
using System.Linq;

namespace Paleondrom
{
    class Program
    {

        internal bool CheckPaleondrom() { 
            bool result = false;
            Console.WriteLine("Введите слово/число");
            string InputText = Console.ReadLine();
            string ReverseText = new string(InputText.Reverse().ToArray());
            if (InputText == ReverseText)
            {
                Console.WriteLine("Это Палиндром");
                result = true; 
            }
            else
            {
                Console.WriteLine("Это не Палиндром");
            }
            return result;
        }
        static void Main(string[] args)
        {

            // На вход получаем слово, число 
            // Переворачиваем и сравниваем
            Program Test = new Program();
            Test.CheckPaleondrom();





        }
    }
}
