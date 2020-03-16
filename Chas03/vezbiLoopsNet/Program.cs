using System;

namespace vezbiLoopsNet
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01
            Console.WriteLine("1.Write a program in C# Sharp to display the first 10 natural numbers."); 
            Console.Write("Enter a number :  ");
            var imput01 = Console.ReadLine();
            int num1;                    
            bool trueNum01 = int.TryParse(imput01, out num1);
            if (trueNum01)
            {
                for (int i = 1; i <= num1; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("ENTER A NUMBER!!");
            }

            #endregion

            #region 02
            Console.WriteLine("2. Write a C# Sharp program to find the sum of first 10 natural numbers.");
            Console.Write("Enter a number :  ");
            var imput02 = Console.ReadLine();
            int num2;
            bool trueNum02 = int.TryParse(imput02, out num2);
            int sum2 =0;
            
            if (trueNum02)
            {               
                for (int i = 1; i < num2; i++)
                {
                   sum2 = sum2 + i;
                    Console.Write("{0} \n", i);
                }
                Console.WriteLine("The Sum is : {0}", sum2);
            }
            else
            {
                Console.WriteLine("ENTER A NUMBER!!");
            }
            #endregion

            #region 03
            Console.WriteLine("3. Write a program in C# Sharp to display n terms of natural number and their sum.");
            Console.Write("Enter a number :  ");
            var imput03 = Console.ReadLine();
            int num3;
            int sum3 = 0;
            bool trueNum03 = int.TryParse(imput03, out num3);
            if (trueNum03)
            {
                for (int i = 1; i < num3; i++)
                {
                    Console.Write("{0} \n", i);
                    sum3 += i;
                }
                Console.WriteLine("The Sum of Natural Number upto {0} terms is : {1} ", num3, sum3);
            }
            else
            {
                Console.WriteLine("ENTER A NUMBER!!");
            }
            #endregion

            #region 04
            Console.WriteLine("4. Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.");
            #endregion
            #region 05
            #endregion
            #region 06
            #endregion
            #region 07
            #endregion
            #region 08
            #endregion
            #region 09
            #endregion
            #region 10
            #endregion
            #region 11
            #endregion
            Console.ReadLine();
        }
    }
}
