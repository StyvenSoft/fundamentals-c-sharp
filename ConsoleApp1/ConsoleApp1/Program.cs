using System;

namespace ConsoleApp1
{
    class Program
    {
        // Variables accesibles
        int numOne = 5;
        int numTwo = 7;

        static void Main(string[] args)
        {
            // Metodos

            subsNumber();

            Console.WriteLine(multNumber(5, 6));

            /*
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

            int value1 = 7;

            double value2 = 5.3;

            double value3 = 8.8;

            Console.WriteLine(moreSum(value1, value2, value3));

            bool coolNew;
            coolNew = false;

            Console.WriteLine(!coolNew);

            // Operadores de comparacion
            /*
             * igual que ==
             * Diferente que != 
             * menor que <
             * mayor que >
             * Mayor igual que >=
             * 
             * */

            // Operadores Logicos
            /**
             * && y logico
             * || o logico
             * 
             * */

            string document = "no";


            Console.WriteLine("Ingresa Edad: ");

            int ageUser = Int32.Parse(Console.ReadLine());

            if (ageUser >= 18)
            {
                Console.WriteLine("Tienes documento?");

                document = Console.ReadLine();
            }

            if(ageUser >= 18 && document == "si")
            {
                Console.WriteLine("Conducir");
            }

            else
            {
                Console.WriteLine("Carnet?");

                string carnet = Console.ReadLine();

                int compara = String.Compare(carnet, "si", true);

                if (compara == 0) Console.WriteLine("Vehiculo");

            }
        }

        // Metodos 

        int sumNumber()
        {
            int num1 = 7;
            int num2 = 9;

            int result = num1 + num2;

            return result;
        }

        static int multNumber(int num1, int num2)
        {
            int result = num1 * num2;

            return result;
        }

        static void subsNumber ()
        {
            int num1 = 6;
            int num2 = 8;

            int result = num1 - num2;

            Console.WriteLine("Resultado: " + result);
        }

        // Ambito de metodos

        void firstMethod ()
        {
            // int numOne = 5;
            // int numTwo = 7;

            // Flujo de ejecucion
            Console.WriteLine(numOne + numTwo);
        }

        void secondMethod()
        {
            Console.WriteLine(numOne);
            
            sumOther(5, 6, 9);
        }

        // Sobrecarga de parametros en metodos
        static int sumOther(int operator1, int operator2) => operator1 + operator2;

        static int sumOther(int number1, int number2, int number3) => number1 + number2 + number3;

        static int sumOther(int number1, int number2, double number3) => number1 + number2;
        
        // parametros opcionales al final
        private static double moreSum(int num1, double num2, double num3= 0)
        {
            return num1 + num2 + num3;
        }


    }
}
