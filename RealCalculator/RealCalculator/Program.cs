using System;

namespace RealCalculator
{
    class Program
    {

        public static int Sum(int n1, int n2)
        {
            return n2 + n1;
        }

        public static int Substract(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        public static int Divide(int n1, int n2)
        {
            return n1 / n2;
        }


        static void Main(string[] args)
        {

            char[] operations = new char[] { '+', '-', '*', '/', 's', 'S' };

            int numberOne, numberTwo;
            char simbol;
            bool validImputOne, validimputTwo, validChar;
            string nOne, nTwo;
            Console.WriteLine("Hellouu Real Calculator !");

            while (true)
            {
                Console.Write(" Pls enter a operatinon (+,-,/,*) or 's' to stop the calculator:  ");
                validChar = char.TryParse(Console.ReadLine(), out simbol);
                if (/*!validChar &&*/ Array.IndexOf(operations, simbol) != -1)
                {
                    while (validChar)
                    {
                        Console.Write("Enter Number One : ");
                        nOne = Console.ReadLine();
                        validImputOne = int.TryParse(nOne, out numberOne);
                        if (!validImputOne)
                        {
                            Console.WriteLine("Invalid input number");
                        }

                        Console.Write("Enter Number Two : ");
                        nTwo = Console.ReadLine();
                        validimputTwo = int.TryParse(nTwo, out numberTwo);
                        if (!validimputTwo)
                        {
                            Console.WriteLine("Invalid input number");
                        }

                        switch (simbol)
                        {
                            case '+':
                                int soberi = Sum(numberOne, numberTwo);
                                Console.WriteLine($" the sum of {numberOne} and {numberTwo} is {soberi}");
                                break;
                            case '-':
                                int minus = Substract(numberOne, numberTwo);
                                Console.WriteLine($" the minus of {numberOne} and {numberTwo} is {minus}");
                                break;
                            case '*':
                                int mnozi = Multiply(numberOne, numberTwo);
                                Console.WriteLine($" the multipl of {numberOne} and {numberTwo} is {mnozi}");
                                break;
                            case '/':
                                int deli = Divide(numberOne, numberTwo);
                                Console.WriteLine($" the dev of {numberOne} and {numberTwo} is {deli}");
                                break;
                            default:
                                Console.WriteLine("Invalid operation selected! The aplication will automatically close.");
                                break;
                        }
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("The aplication will automatically close........");
                }
            }     
        }
    }
}
