using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   /*
             * Fundamentos de C#
             * 
             * Primitivos
             * 
             * Enteros - Reales - Booleanos
             * 
             * */
            Console.WriteLine("Hello Welcome C#!");
            Console.WriteLine("New comment");
            int age;

            age = 18;

            Console.WriteLine(age);
            // Double
            Console.WriteLine(5.1 / 2.2);
            // Residuo
            Console.WriteLine(9 % 3);
            //
            int age_one = 19;

            Console.WriteLine("Edad: " + age_one + "años");
            
            // Interpolacion
            Console.WriteLine($"Tu edad es {age}");

            // Incremento
            Console.WriteLine(age++);


            int agePerson1;
            int agePerson2;
            int agePerson3;

            agePerson1 = agePerson2 = agePerson3 = 27;

            Console.WriteLine(agePerson3);


            Console.ReadKey();
        }
    }
}
