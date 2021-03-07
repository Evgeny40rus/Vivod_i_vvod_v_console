using System;

namespace Vivod_i_vvod_v_console
{
    class Program
    {
        public static void Main(string[] args)
        {
            string MyName = "Евгения";
            byte age = 42;

            Console.WriteLine("Привет, Мир!");
            Console.WriteLine();
            Console.WriteLine($"Меня зовут {MyName}");
            Console.WriteLine($"Мой возраст {age}");


            Console.ReadKey();

        }
    }
}
