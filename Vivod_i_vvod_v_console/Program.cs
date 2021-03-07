using System;

class MainClass 
    {
    public static void Main(string[] args)
        {
            string MyName = "Евгения";

            byte ageEvg = 42;

            Console.WriteLine("Привет, Мир!");
            Console.WriteLine();
            Console.WriteLine("Меня зовут {0} \n Мой возраст {1}" , MyName,ageEvg);

        //Console.WriteLine($"Мой возраст {age}");

        Console.WriteLine("Меня зовут {0}", "Маша");

        var age = 27;
        var weight = 50;

        Console.WriteLine("Возраст {0} \n Вес {1}", age, weight);


            Console.ReadKey();

        }
    }
