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

            // Array de tipo String

            string[] cadens = new string[5];
            
            cadens[3] = "Hugo";
            cadens[4] = "Steveen";

            string[] nameClients = { "Fredy", "Mary", "Yina" };

            Console.WriteLine("Result {0}", cadens.Length);

            Console.WriteLine(nameClients);

            // Array tipo entero

            int[] ageOthers = new int[5];

            ageOthers[0] = 5;
            ageOthers[1] = 6;
            
            int[] agesNew = { 8, 55, 17, 23 };

            Console.WriteLine(agesNew);

            //Array bidimensional

            double[,] newDoble = new double[2, 2] { { 8, 2.5 }, { 6.4, 5.4 } };

            Console.WriteLine("resultado {0}", newDoble[1,0]);

            // Array tridimensional

            double[,,] newTrid = new double[2, 2, 3] { { { 8, 2.5, 7.1 }, { 6.4, 5.4, 6 } }, { { 8, 1.2, 5 }, { 8, 1.2, 6 } } };

            Console.WriteLine("resultado {0}", newTrid[1, 0, 1]);

            Console.ReadKey();

            Console.WriteLine("Ingresa tu edad");

            int ageClient = Int32.Parse(Console.ReadLine());

            if (ageClient < 18) Console.WriteLine("Niño");
            else if (ageClient < 30) Console.WriteLine("Joven");
            else if (ageClient < 60) Console.WriteLine("Adulto");
            else Console.WriteLine("Mayor");


            Console.WriteLine("Elige medio de transporte (coche, tren, avion): ");

            string meansTransport = Console.ReadLine();

            switch (meansTransport)
            {
                case "coche":
                    Console.WriteLine("Velocidad 100 km/h");
                    break;
                case "tren":
                    Console.WriteLine("Velocidad 250 km/h");
                    break;
                case "avion":
                    Console.WriteLine("Velocidad 800 km/h");
                    break;
                default:
                    Console.WriteLine("No transporte");
                    break;
            }

            // Bucle While

            Console.WriteLine("Bucle while");

            string response = Console.ReadLine();

            while (response != "no")
            {
                Console.WriteLine("Ingreso bucle");

                string myName = Console.ReadLine();

                Console.WriteLine($"respuesta {myName}");

            }

            // Ejercicio bucle While

            Random numbers = new Random();

            int numberAleat = numbers.Next(0, 100);

            int myNumberOne = 101;

            int inter = 0;

            Console.WriteLine("Ingresar numero 1 - 100");

            while(numberAleat != myNumberOne)
            {
                inter++;

                try
                {
                    myNumberOne = int.Parse(Console.ReadLine());
                } catch(FormatException ex)
                {
                    Console.WriteLine("Error numero invalido" + ex);
                } catch(OverflowException ex)
                {
                    Console.WriteLine("Demasiado alto"+ ex);
                }
                /*
                 * Jerarquia de excepciones
                 * 
                 * 1. Exception
                 * 2. SystemException
                 * 3. FormatException y OverflowException
                 * 
                 */

                // Excepcion generica
               /* catch(Exception ex)
                {
                    Console.WriteLine("Excepcion generica" + ex.Message);
                }
                */

                // Excepciones con Filtro

                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine(e.Message);
                }

                if(myNumberOne > numberAleat)  Console.WriteLine("Numero mas bajo");

                if (myNumberOne < numberAleat) Console.WriteLine("Numero mas alto");
            }

            Console.WriteLine($"Correcto, intentos {inter}");

            // Bucle do - While

            int valueZ = 10;

            do
            {
                Console.WriteLine("Impresion" + valueZ);

                valueZ++;

            } while (valueZ < 15);

            Console.WriteLine("Ingresa Numero de Mes");

            int numberMonth = int.Parse(Console.ReadLine());

            Console.WriteLine(NameMonth(numberMonth));

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

        static void useChecked()
        {
            // Comprobar desbordamiento
            checked
            {
                int numberMax = int.MaxValue;

                // Desbordamiento de valor maximo

                int resultMax = numberMax + 20;

                Console.WriteLine(resultMax);
            }

            // No comprobar desbordamiento tipo INT, LONG

            // unchecked()
            
        }

        public static string NameMonth(int month)
        {
            switch (month)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                default:
                    return "Error mes";
            }
            
        }



    }
}
