using System;

namespace RealCalculator
{
    class Program
    {

        public static int Sum(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Substract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }


        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            char[] operations = new char[] { '+', '-', '*', '/', 's', 'S' };


            char operation, simbol;

            bool validImputOne, validimputTwo, validChar;

            Console.WriteLine("Hello Real Calculator !");
            while (true)
            {
                int numberOne, numberTwo;

                while (true)
                {
                    Console.WriteLine(" Pls enter a operatinon (+,-,/,*) or 's' to stop the calculator:  ");
                    validChar = char.TryParse(Console.ReadLine(), out simbol);

                    if (validChar && Array.IndexOf(operations, simbol) != -1)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid operator!!!");
                }

                if (validChar && simbol == 's')
                {
                    Console.WriteLine("TY FOR USING THE CALCULATOR");
                    break;
                }
                else if (validChar && simbol == 'S')
                {
                    Console.WriteLine("TY FOR USING THE CALCULATOR");
                    break;
                }
                while (validChar)
                {

                }

            }


            Console.WriteLine("Enter Number One : ");

            Console.WriteLine("Enter Number Two : ");


            Console.ReadLine();
        }
    }
}
