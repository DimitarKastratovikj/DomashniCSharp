using System;

namespace Class03ExtraExercisesG1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 01
            //Console.WriteLine("1. Write a C# Sharp program to find the sum of first 10 natural numbers");

            //Console.Write("Enter a number :  ");
            //var imput01 = Console.ReadLine();
            //int num1;
            //bool trueNum01 = int.TryParse(imput01, out num1);
            //int sum1 = 0;

            //if (trueNum01)
            //{
            //    for (int i = 1; i < num1; i++)
            //    {
            //        sum1 = sum1 + i;
            //        Console.Write("{0} \n", i);
            //    }
            //    Console.WriteLine("The SUM is : {0}", sum1);
            //}
            //else
            //{
            //    Console.WriteLine("ENTER A NUMBER!!");
            //}
            #endregion

            #region 02
            //Console.WriteLine("2. Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.");
            //Console.Write("Enter 1st number :  ");
            //var imput21 = Console.ReadLine();
            //int num21;
            //bool trueNum21 = int.TryParse(imput21, out num21);
            ////----
            //Console.Write("Enter 2nd number :  ");
            //var imput22 = Console.ReadLine();
            //int num22;
            //bool trueNum22 = int.TryParse(imput22, out num22);
            ////----
            //Console.Write("Enter 3th number :  ");
            //var imput23 = Console.ReadLine();
            //int num23;
            //bool trueNum23 = int.TryParse(imput23, out num23);
            ////----
            //Console.Write("Enter 4th number :  ");
            //var imput24 = Console.ReadLine();
            //int num24;
            //bool trueNum24 = int.TryParse(imput24, out num24);
            ////----
            //Console.Write("Enter 5th number :  ");
            //var imput25 = Console.ReadLine();
            //int num25;
            //bool trueNum25 = int.TryParse(imput25, out num25);
            ////----
            //Console.Write("Enter 6th number :  ");
            //var imput26 = Console.ReadLine();
            //int num26;
            //bool trueNum26 = int.TryParse(imput26, out num26);
            ////----
            //Console.Write("Enter 7th number :  ");
            //var imput27 = Console.ReadLine();
            //int num27;
            //bool trueNum27 = int.TryParse(imput27, out num27);
            ////----
            //Console.Write("Enter 8th number :  ");
            //var imput28 = Console.ReadLine();
            //int num28;
            //bool trueNum28 = int.TryParse(imput28, out num28);
            ////----
            //Console.Write("Enter 9th number :  ");
            //var imput29 = Console.ReadLine();
            //int num29;
            //bool trueNum29 = int.TryParse(imput29, out num29);
            ////----

            //Console.Write("Enter 10th number :  ");
            //var imput20 = Console.ReadLine();
            //int num20;
            //bool trueNum20 = int.TryParse(imput20, out num20);
            ////----
            //int avg10num;
            //int sum10num;

            //if (trueNum21 && trueNum22 && trueNum23 && trueNum24 && trueNum25 && 
            //    trueNum26 && trueNum27 && trueNum28 && trueNum29 && trueNum20)
            //{
            //    avg10num = (num20 + num29 + num28 + num27 + num26 + num25 + num24 + num23 + num22 + num21) / 10;
            //    sum10num = num20 + num29 + num28 + num27 + num26 + num25 + num24 + num23 + num22 + num21;
            //    Console.WriteLine($"The SUM of the 10 numbers is {sum10num} ");
            //    Console.WriteLine($"The AVG of the 10 numbers is {avg10num} ");
            //}
            //else
            //{
            //    Console.WriteLine("enter number!");
            //}

            #endregion

            #region 03
            //Console.WriteLine("Declare and init array of 10 integers by your choise."+ 
            //                  "Find maximum and minimum element in that array and their indexes.");
            //Console.WriteLine("Press ENTER to continue.");
            //Console.ReadLine();
            //int [] brojki01 = new int[] { 23, 43 , 64 , 57 , 32 , 65 , 44 , 64 , 24 , 67};

            //int max1 = Int32.MinValue;
            //int min1 = Int32.MaxValue;
            //foreach (var item in brojki01)
            //{
            //    Console.WriteLine(item);

            //}


            //for (int i = 0; i < brojki01.Length; i++)
            //{
            //    if (brojki01[i] > max1)
            //    {
            //        max1 = brojki01[i];               
            //    } 
            //}
            //Console.WriteLine(" maximum number in the array is  : {0}", max1);

            //for (int i = 0; i < brojki01.Length; i++)
            //{
            //    if (brojki01[i] < min1)
            //    {
            //        min1 = brojki01[i];
            //    }
            //}
            //Console.WriteLine(" maximum number in the array is  : {0}", min1);

            #endregion

            #region 04

            //Console.WriteLine("Write a program in C# Sharp to " +
            //    "count a total number of duplicate elements in arrayWithDuplicates");



            //int[] arrayWithDuplicates = new int[] { 1, 4, 6, 3, 4, 5, 9, 3, 2, 9,10,11,11 };

            //int numberOfDuplic = 0;

            //for (int i = 0; i < arrayWithDuplicates.Length; i++)
            //{
            //    for (int j = i+1; j < arrayWithDuplicates.Length; j++)
            //    {
            //        if (arrayWithDuplicates[i] == arrayWithDuplicates[j])
            //        {
            //            numberOfDuplic++;
            //        }
            //    }
            //}
            //Console.WriteLine("the number of duplicates is --> {0}",numberOfDuplic);

            #endregion

            #region 05


            int[] oddEvenArray = { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };
            Console.WriteLine("Write a program in C# Sharp to separate" +
                " odd and even integers from the oddEvenArray in separate arrays");
            int[] odds = new int[] { };
            int[] evens = new int[] { };
            for (int i = 0; i < oddEvenArray.Length; i++)
            {
                //Console.WriteLine(oddEvenArray[i]);
                if (oddEvenArray[i] % 2 == 1)
                {
                    Array.Resize(ref odds, oddEvenArray[i]);

                }

            }
            for (int i = 0; i < odds.Length; i++)
            {
                Console.WriteLine(odds[i]);
            }
            //Console.WriteLine(dodajKockaEve);
            //foreach (var item in evens)
            //{
            //    Console.WriteLine("evens > {0}",item);
            //}

            #endregion
            #region 06
            #endregion
            #region 07
            #endregion
            #region 08
            #endregion
            #region 09
            #endregion

            Console.ReadLine();
        }
    }
}
