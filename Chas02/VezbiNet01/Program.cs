using System;

namespace VezbiNet01BasicExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01
            Console.WriteLine("01.Write a C# Sharp program to print Hello and your name in a separate line.");
            Console.WriteLine();
            Console.WriteLine("Hellou:");
            Console.WriteLine("Alexandra Abramov");
            #endregion

            #region 02
            Console.WriteLine("02.Write a C# Sharp program to print the sum of two numbers.");
            Console.WriteLine(5 + 6);
            #endregion

            #region 03
            Console.WriteLine("03. Write a C# Sharp program to print the result of dividing two numbers.");
            Console.WriteLine(24 / 6);
            #endregion

            #region 04
            //4.Write a C# Sharp program to print the result of the specified operations
            Console.WriteLine("04.Write a C# Sharp program to print the result of the specified operations");
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            #endregion

            #region 05
            Console.WriteLine("05. Write a C# Sharp program to swap two numbers");
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
            Console.WriteLine("06.Write a C# Sharp program to print the output of multiplication " +
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

            //resenie od net

            //int num1, num2, num3;

            //Console.Write("Input the first number to multiply: ");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Input the second number to multiply: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Input the third number to multiply: ");
            //num3 = Convert.ToInt32(Console.ReadLine());

            //int result = num1 * num2 * num3;
            //Console.WriteLine("Output: {0} x {1} x {2} = {3}", num1, num2, num3, result);

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

                                                           //resenie od net 
            //Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter another number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            //Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            //Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            //Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            //Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);

            #endregion

            #region 08
            Console.WriteLine("08.Write a C# Sharp program that takes a number as input" +
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
            Console.WriteLine("09. Write a C# Sharp program that takes four numbers as input to calculate and print the average");
            Console.WriteLine();

            int num8, num9, num10, num11;

            Console.Write("\nInput the 1st Number : ");
            num8 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the 2nd Number : ");
            num9 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the 3th Number : ");
            num10 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the 4th Number : ");
            num11 = int.Parse(Console.ReadLine());

            double result2 = (num8 + num9 + num10 + num11) / 4;
            Console.WriteLine($"The average of {num8}, {num9}, {num10} and {num11} is {result2}");

            //double result2 = (number1 + number2 + number3 + number4) / 4;  resenie od net
            //Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",number1, number2, number3, number4, result2);

            #endregion

            #region 10
            Console.WriteLine("10. Write a C# Sharp program to that takes three numbers(x,y,z)" +
                " as input and print the output of (x+y).z and x.y + y.z");
            int num12, num13, num14;

            Console.Write("Enter first number - ");
            num12 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second  number - ");
            num13 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third  number - ");
            num14 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Result of specified numbers x = {num12},y = {num13} and z = {num14}, " +
                $"(x+y)*z is {(num12 + num13)* num14} and x*y + y*z is {num12 * num13 + num13 * num14}");

            #endregion

            #region 11
            Console.WriteLine("11.Write a C# Sharp program that takes an age (for example 20)" +
                " as input and prints something as" + "You look older than 20");
            Console.WriteLine();
            int age;
            Console.Write("Enter your age ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("You look younger than {0} ", age);
            Console.WriteLine();
            #endregion

            #region 12
            Console.WriteLine("12. Write a C# program to that takes a number as input" +
                " and display it four times in a row (separated by blank spaces), " +
                "and then four times in the next row, with no separation. " +
                "You should do it two times: Use Console. Write and then use {0}.");
            int num15;
            Console.Write("pls insert number - ");
            num15 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}{0}", num15);
            Console.WriteLine("{0} {0} {0} {0}", num15);

            //// Part A: "num num num num" using Write  ---------  od net 
            //Console.Write(num);
            //Console.Write(" ");
            //Console.Write(num);
            //Console.Write(" ");
            //Console.Write(num);
            //Console.Write(" ");
            //Console.Write(num);
            //Console.WriteLine();

            //// Part B: "numnumnumnum" using Write
            //Console.Write(num);
            //Console.Write(num);
            //Console.Write(num);
            //Console.WriteLine(num);
            //Console.WriteLine();

            #endregion

            #region 13
            Console.WriteLine("13. Write a C# program that takes a number as input and then displays a " +
                "rectangle of 3 columns wide and 5 rows tall using that digit. ");
            int num16;
            Console.Write("pls insert number - ");
            num16 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"{num16} {num16} {num16}");
            Console.WriteLine($"{num16}     {num16}");
            Console.WriteLine($"{num16}     {num16}");
            Console.WriteLine($"{num16}     {num16}");
            Console.WriteLine($"{num16} {num16} {num16}");
            #endregion

            #region 14
            Console.WriteLine("14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.");
            int num17;
            Console.Write("Enter number - ");
            num17 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount of celsius: {0}", (num17));
            Console.WriteLine(" to Kelvin: {0}", (num17 + 273));
            Console.WriteLine(" to Fahrenheit: {0}", (num17 * 18 / 10 + 32));
            Console.WriteLine();
            #endregion
            #region 15
            Console.WriteLine("15. Write a C# program remove specified a character " +
                "from a non-empty string using index of a character.");

            #endregion
            #region 16
            #endregion
            #region 17
            #endregion
            #region 18
            #endregion
            #region 19
            #endregion
            #region 20
            #endregion
            #region 21
            #endregion
            #region 22
            #endregion
            #region 23
            #endregion
            #region 24
            #endregion
            #region 25
            #endregion
            #region 26
            #endregion
            #region 27
            #endregion
            #region 28
            #endregion
            #region 29
            #endregion
            #region 30
            #endregion
            Console.ReadLine();
        }
    }
}
