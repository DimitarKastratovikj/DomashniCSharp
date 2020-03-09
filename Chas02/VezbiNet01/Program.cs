using System;

namespace VezbiNet01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01
            Console.WriteLine("1.Write a C# Sharp program to print Hello and your name in a separate line.");
            Console.WriteLine();
            Console.WriteLine("Hellou:");
            Console.WriteLine("Alexandra Abramov");
            #endregion

            #region 02
            Console.WriteLine("2.Write a C# Sharp program to print the sum of two numbers.");
            Console.WriteLine(5 + 6);
            #endregion

            #region 03
            Console.WriteLine("3. Write a C# Sharp program to print the result of dividing two numbers.");
            Console.WriteLine(24 / 6);
            #endregion

            #region 04
            //4.Write a C# Sharp program to print the result of the specified operations
            Console.WriteLine("4.Write a C# Sharp program to print the result of the specified operations");
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            #endregion

            #region 05
            Console.WriteLine("5. Write a C# Sharp program to swap two numbers");
            int num1, num2, tmp;

            Console.Write("\nInput the First Number : ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("\nInput the Second Number : ");
            num2 = int.Parse(Console.ReadLine());

            tmp = num1;
            num1 = num2;
            num2 = tmp;

            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region 06
            Console.WriteLine("Write a C# Sharp program to print the output of multiplication " +
                "of three numbers which will be entered by the user");
            Console.WriteLine();
            //Test Data:
            //Input the first number to multiply: 2
            //Input the second number to multiply: 3
            //Input the third number to multiply: 6
            //Expected Output:
            //2 x 3 x 6 = 36
            Console.Write("\nInput the 1st Number : ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the 2nd Number : ");
            int num4 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the 3th Number : ");
            int num5 = int.Parse(Console.ReadLine());
            Console.Write("\nAfter multiplication : ");
            Console.WriteLine();
            Console.WriteLine($"First number to multiply: {num3}");
            Console.WriteLine($"Second number to multiply: {num4}");
            Console.WriteLine($"Third number to multiply: {num5}");
            Console.WriteLine();
            Console.WriteLine($" Output: {num3 * num4 * num5}");
            Console.WriteLine();
            #endregion

            #region 07
            Console.WriteLine("7. Write a C# Sharp program to print on screen the output of" +
                " adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.");
            Console.WriteLine();
            Console.Write("\nInput the First number : ");
            int num6 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second number : ");
            int num7 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"First and Second number adding result is : {num6 + num7} ");
            Console.WriteLine($"First and Second number subtracting result is : {num6 - num7} ");
            Console.WriteLine($"First and Second number multiplying result is : {num6 * num7} ");
            Console.WriteLine($"First and Second number dividing result is : {num6 / num7} ");
            Console.WriteLine();
            #endregion

            #region 08
            Console.WriteLine("Write a C# Sharp program that takes a number as input" +
                " and print its multiplication table.");
            //Test Data:
            //Enter the number: 5
            //Expected Output:
            //5 * 0 = 0
            //5 * 1 = 5
            //5 * 2 = 10
            //5 * 3 = 15
            //....
            //5 * 10 = 50
            int x;
            int result1;

            Console.WriteLine("Enter a number:");
            x = Convert.ToInt32(Console.ReadLine());
            result1 = x * 1;
            Console.WriteLine("The table is : {0} x {1} = {2}", x, 1, result1); 

            // "The table is : {0} x {1} = {2}"                                                                              
            //ова го праи несто као ареј а пак                                                                               
            //, x, 1, result1 му става вредности                                                                        
            // прашањето е зашо нема $ пред наводниците

            result1 = x * 2;
            Console.WriteLine("             : {0} x {1} = {2}", x, 2, result1);
            result1 = x * 3;
            Console.WriteLine("             : {0} x {1} = {2}", x, 3, result1);
            result1 = x * 4;
            Console.WriteLine("             : {0} x {1} = {2}", x, 4, result1);
            result1 = x * 5;
            Console.WriteLine("             : {0} x {1} = {2}", x, 5, result1);
            result1 = x * 6;
            Console.WriteLine("             : {0} x {1} = {2}", x, 6, result1);
            result1 = x * 7;
            Console.WriteLine("             : {0} x {1} = {2}", x, 7, result1);
            result1 = x * 8;
            Console.WriteLine("             : {0} x {1} = {2}", x, 8, result1);
            result1 = x * 9;
            Console.WriteLine("             : {0} x {1} = {2}", x, 9, result1);
            result1 = x * 10;
            Console.WriteLine("             : {0} x {1} = {2}", x, 10, result1);

            #endregion
            #region 09

            #endregion
            #region 10
            #endregion
            #region 11
            #endregion
            #region 12
            #endregion
            #region 13
            #endregion
            #region 14
            #endregion
            #region 15
            #endregion
            Console.ReadLine();
        }
    }
}
