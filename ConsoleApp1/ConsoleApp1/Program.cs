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

            // Conversion explicita
            // Casting

            double temperature = 34.5;
            int temperatureCol;

            temperatureCol = (int)temperature;

            Console.WriteLine(temperatureCol);

            // Conversion implicita

            int populationBog = 12000000;

            long populationContries = populationBog;

            Console.WriteLine(populationContries);

            float materialWeight = 5.78F;

            double materialWeightPrec = materialWeight;

            Console.WriteLine(materialWeightPrec);

            // Type Conversion
            // Methodo parse()

            Console.WriteLine("Ingresa numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            //Uging

            Console.WriteLine("Resultado es: " + (num1 + num2));

            const int valueOne = 4;
            Console.WriteLine(valueOne);

            // Constante

            const double PI = 3.1413;

            Console.WriteLine("Ingresa medida radio: ");

            double radie = double.Parse(Console.ReadLine());

            //double area = radie * radie * PI;
            double area = Math.Pow(radie, 2) * PI;

            Console.WriteLine("Area del circulo es: " + area);

            Console.ReadKey();
        }
    }
}
