using System;

namespace VezbiNet02ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01
            Console.WriteLine("1. Write a C# Sharp program to accept two integers and " +
                              "check whether they are equal or not.");
            int num1, num2;

            Console.Write("Input 1st number: ");
            var input = Console.ReadLine();          
            bool result = int.TryParse(input, out num1);

            Console.Write("Input 2nd number: ");
            var input2 = Console.ReadLine();
            bool result2 = int.TryParse(input2, out num2);

            if (result && num1 == num2)
            {
                Console.WriteLine("{0} and {1} are equal ", num1, num2);
            }
            else if(result2 && num1 != num2)
            {
                Console.WriteLine("{0} and {1} are  NOT equal ", num1, num2);
            }
            else
            {
                Console.WriteLine("ENTER NUMBER!!");
            }
        //    int int1, int2;
        //    Console.Write("\n\n");
        //    Console.Write("Check whether two integers are equal or not:\n");
        //    Console.Write("-------------------------------------------");
        //    Console.Write("\n\n");
        //    Console.Write("Input 1st number: ");
        //    int1 = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Input 2nd number: ");
        //    int2 = Convert.ToInt32(Console.ReadLine());

        //    if (int1 == int2)
        //        Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
        //    else
        //        Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);
        

        Console.WriteLine();
            #endregion

            #region 02
            Console.WriteLine("2. Write a C# Sharp program to check whether a given number is even or odd.");
            int num3;
            Console.Write("Input number: ");
            var input3 = Console.ReadLine();
            bool result3 = int.TryParse(input3, out num3);

            if (result3 && num3 % 2 == 0)
            {
                Console.WriteLine("{0} is a EVEN number",num3);
            }
            else if(result3 && num3 % 2 == 1)
            {
                Console.WriteLine("{0} is a ODD number", num3);
            }
            else
            {
                Console.WriteLine("ENTER NUMBER!!");
            }
            //int num1, rem1;    -------------   OD NET
            //Console.Write("\n\n");
            //Console.Write("Check whether a number is even or odd :\n");
            //Console.Write("---------------------------------------");
            //Console.Write("\n\n");
            //Console.Write("Input an integer : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //rem1 = num1 % 2;
            //if (rem1 == 0)
            //    Console.WriteLine("{0} is an even integer.\n", num1);
            //else
            //    Console.WriteLine("{0} is an odd integer.\n", num1);
            Console.WriteLine();
            #endregion

            #region 03
            Console.WriteLine("3. Write a C# Sharp program to check whether a given number is positive or negative.");
            Console.Write("Pls enter number - ");
            var input4 = Console.ReadLine();
            int num4;
            bool result4 = int.TryParse(input4, out num4);
            if (result4 && num4 > 0)
            {
                Console.WriteLine("given number is positive");
            }
            else if (result4 && num4 < 0)
            {
                Console.WriteLine("given number is negative");
            }
            else
            {
                Console.WriteLine("ITS a fukin 0 !! ");
            }
            //int num;
            //Console.Write("\n\n");
            //Console.Write("Check whether a number is positive or negative:\n");
            //Console.Write("----------------------------------------------");
            //Console.Write("\n\n");
            //Console.Write("Input an integer : ");
            //num = Convert.ToInt32(Console.ReadLine());
            //if (num >= 0)

            //    Console.WriteLine("{0} is a positive number.\n", num);
            //else
            //    Console.WriteLine("{0} is a negative number. \n", num);
            Console.WriteLine();
            #endregion

            #region 04
            Console.WriteLine("4. Write a C# Sharp program to find whether a given year is a leap year or not.");
            Console.Write("pls enter Year - ");
            var currYear = Console.ReadLine();
            int year;
            bool validDate = int.TryParse(currYear, out year);

            if (validDate && year % 400 == 0)
            {
                Console.WriteLine("{0} is a leap year.\n", year);
            }
            else if (validDate && year % 100 == 0)
            {
                Console.WriteLine("{0} is not a leap year.\n", year);
            }
            else if (validDate && year % 4 == 0)
            {
                Console.WriteLine("{0} is a leap year.\n", year);
            }
            else if(validDate) 
            {
                Console.WriteLine("{0} is not a leap year.\n", year); 
            }
            else
            {
                Console.WriteLine("ENTER A VALID YEAR!!!");
            }
            //int chk_year;              ---------->   OD NET!
            //Console.Write("\n\n");
            //Console.Write("Check whether a given year is leap year or not:\n");
            //Console.Write("----------------------------------------------");
            //Console.Write("\n\n");
            //Console.Write("Input an year : ");
            //chk_year = Convert.ToInt32(Console.ReadLine());

            //if ((chk_year % 400) == 0)
            //    Console.WriteLine("{0} is a leap year.\n", chk_year);
            //else if ((chk_year % 100) == 0)
            //    Console.WriteLine("{0} is not a leap year.\n", chk_year);
            //else if ((chk_year % 4) == 0)
            //    Console.WriteLine("{0} is a leap year.\n", chk_year);
            //else
            //    Console.WriteLine("{0} is not a leap year.\n", chk_year);
            Console.WriteLine();
            #endregion

            #region 05
            Console.WriteLine("5. Write a C# Sharp program to read the age of a " +
                "candidate and determine whether it is eligible for casting his/her own vote.");
            Console.Write("Enter ur AGE - ");
            var age1 = Console.ReadLine();
            int trueAge;
            bool validAge1 = int.TryParse(age1, out trueAge);
            if(validAge1 && trueAge < 0)                       
            {
                Console.WriteLine(" INVALID YEAR !!!");
            }
            else if(validAge1 && trueAge < 18)
            {
                Console.WriteLine("Sorry! You are NOT eligible for casting your vote.");
            }
            else if(validAge1 && trueAge >= 18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");               
            }
            else
            {
                Console.WriteLine("ENTER UR AGE !!!");
            }
            //int vote_age;
            //Console.Write("\n\n");
            //Console.Write("Detrermine a specific age is eligible for casting the vote:\n");
            //Console.Write("----------------------------------------------------------");
            //Console.Write("\n\n");
            //Console.Write("Input the age of the candidate : ");
            //vote_age = Convert.ToInt32(Console.ReadLine());
            //if (vote_age < 18)
            //{
            //    Console.Write("Sorry, You are not eligible to caste your vote.\n");
            //    Console.Write("You would be able to caste your vote after {0} year.\n\n", 18 - vote_age);
            //}
            //else
            //    Console.Write("Congratulation! You are eligible for casting your vote.\n\n");
            Console.WriteLine();
            #endregion

            #region 06  // ---------> zasto ne mi iskacha??
            Console.WriteLine("6. Write a C# Sharp program to read the value of an " +
                "integer m and display the value of n is 1 when m is larger than 0," +
                " 0 when m is 0" +
                " and -1 when m is less than 0.");
            Console.Write("enter a number -> ");
            var input5 = Console.ReadLine();
            int num5;

            bool trueNumber = int.TryParse(input5, out num5);
            if( trueNumber == true)
            {               
                Console.WriteLine(" The value of n = {0}", num5);
            }
            else if (trueNumber && num5 > 0)
            {
                num5 = 1;
                Console.WriteLine($" The value of n = {num5}");
            }
            else if(trueNumber && num5 < 0)
            {
                num5 = -1;
                Console.WriteLine($" The value of n = {num5}");
            }
            else
            {
                Console.WriteLine("Enter a NUMBER!!!");
            }
            //int m, n;
            //Console.Write("\n\n");
            //Console.Write("Display the value of n is 1,0 and -1 for the value of er m:\n");
            //Console.Write("----------------------------------------------------------");
            //Console.Write("\n\n");

            //Console.Write("Input the  value of m :");
            //m = Convert.ToInt32(Console.ReadLine());
            //if (m != 0)
            //    if (m > 0)
            //        n = 1;
            //    else
            //        n = -1;
            //else
            //    n = 0;
            //Console.Write("The value of m = {0} \n", m);
            //Console.Write("The value of n = {0} \n\n", n);

            Console.WriteLine();
            #endregion

            #region 07
            Console.WriteLine("Write a C# Sharp program to accept the height of a person in centimeter" +
                " and categorize the person according to their height.");
            Console.Write("Enter ur HEIGHT -> ");
            var imputHeight = Console.ReadLine();  
            int height;
            bool trueHeight = int.TryParse(imputHeight, out height);

            if (trueHeight && height < 135)
            {
                Console.WriteLine("The person is Dwarf");
            }
            else if (trueHeight && (height >= 150) && (height <= 165))
            {
                Console.WriteLine("person is  average heighted.");
            }
            else if (trueHeight && (height >= 165) && (height <= 195))
            {
                Console.WriteLine("person is tall");
            }
            else if(trueHeight && height > 195)
            {
                Console.WriteLine("Abnormal height");
            }
            else
            {
                Console.WriteLine("enter number!");
            }

                //if (PerHeight < 150.0)
                //    Console.Write("The person is Dwarf. \n\n");
                //else if ((PerHeight >= 150.0) && (PerHeight <= 165.0))
                //    Console.Write("The person is  average heighted. \n\n");
                //else if ((PerHeight >= 165.0) && (PerHeight <= 195.0))
                //    Console.Write("The person is taller. \n\n");
                //else
                //    Console.Write("Abnormal height.\n\n");

                Console.WriteLine();
            #endregion

            #region 08
            Console.WriteLine("Write a C# Sharp program to find the largest of three numbers.");
            Console.Write("Input the 1st number : \n");
            var firstImp = Console.ReadLine();
            int firstNumber;
            bool trueFirstNumber = int.TryParse(firstImp, out firstNumber);

            Console.Write("Input the 2nd number : \n");
            var secImp = Console.ReadLine();
            int secNumber;
            bool trueSecNumber = int.TryParse(secImp, out secNumber);

            Console.Write("Input the 3th number : \n");
            var trImp = Console.ReadLine();
            int trNumber;
            bool truetrNumber = int.TryParse(trImp, out trNumber);

            if(trueFirstNumber && trueSecNumber && truetrNumber && firstNumber > secNumber)
            {
                if(trueFirstNumber && trueSecNumber && truetrNumber && firstNumber > trNumber)
                {
                    Console.WriteLine("The 1st Number is the greatest among three.");
                }
                else
                {
                    Console.WriteLine("The 3rd Number is the greatest among three. ");
                }
            }
            else if (trueFirstNumber && trueSecNumber && truetrNumber && secNumber > trNumber)
            {
                Console.WriteLine("The 2nd Number is the greatest among three");
            }
            else
            {
                
            }

            Console.WriteLine();
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
            #region 13
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



            Console.WriteLine(" HAVE A NICE DAY!! ");
            Console.ReadLine();
        }
    }
}
