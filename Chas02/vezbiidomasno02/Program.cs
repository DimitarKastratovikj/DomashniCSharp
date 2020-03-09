using System;

namespace vezbiidomasno02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ex01
            double num1 = 11.12;
            double num2 = 5.62;
            double num3 = num1 / num2;
            Console.WriteLine(num3);
            Console.ReadLine();

            int num4 = 18;
            int num5 = 9;
            int num6 = num4 / num5;
            Console.WriteLine(num6);
            Console.ReadLine();
            #endregion

            #region Ex02
            string str1 = "Dime ";
            string str2 = "Kastro";
            string str3 = str1 + str2;
            Console.WriteLine(str3);
            Console.ReadLine();

            string str4 = "9";
            string str5 = "3";
            string str6 = str4 + str5;
            Console.WriteLine(str6);
            Console.ReadLine();
            #endregion

            #region Ex03
            string str7 = "String and integer";
            int num7 = 5;
            var strAndInt = str7 + num7;
            Console.WriteLine(strAndInt);
            Console.ReadLine();
            #endregion

            #region Ex04
            int n = 102;
            int m = 5;
            int result = n / m;
            Console.WriteLine($"The number of SMS u can send is {result}.");
            Console.ReadLine();
            #endregion

            #region Ex05BonusTask
            //Set variable from input
            //TRY to convert it to int
            //if its converted successfully print in the console if number is odd or even
            //else if its not converted, print in the console that user inserted invalid input
            //Hint: if number / 2 has remainder 0 its even, else its odd
            Console.WriteLine("vnesi broj:");

            var input = Console.ReadLine();
            int number1;
            bool reulst = int.TryParse(input, out number1);
            if (reulst && number1 % 2 == 0) 
            {              
                Console.WriteLine("user input is even");
            }
            else if (reulst && number1 % 2 == 1)
            {
                Console.WriteLine("user input is odd");
            }
            else
            {
                Console.WriteLine("KE PRAVISH SHO KE TI KAZAM!!");
            }
            #endregion

            Console.WriteLine();
            Console.WriteLine("TY! BB!");
            Console.ReadLine();

        }
    }
}
