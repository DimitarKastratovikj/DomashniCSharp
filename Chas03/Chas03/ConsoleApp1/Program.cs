using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array.indexOf
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            // we get the index of 2 in array
            int indexOfTwo = Array.IndexOf(array, 2);
            Console.WriteLine(indexOfTwo);

            // we revert the array
            Array.Reverse(array);

            foreach (var number in array)
            {
                Console.WriteLine(number);
            }

            // we copy the array in another array
            int[] clonedArray = new int[5];
            Array.Copy(array, clonedArray, 5);

            foreach (var number in clonedArray)
            {
                Console.WriteLine(number);
            }

            // sort the array ASC
            Array.Sort(array);
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }

            // get the length of array
            int length = array.Length;
            Console.WriteLine(length);

            // get the last index of element in array
            int[] newArray = new int[] { 1, 2, 3, 1, 5, 6, 7, 8 };
            int lastIndexOfOne = Array.LastIndexOf(newArray, 1);
            Console.WriteLine(lastIndexOfOne);

            //-----------------------------------------------

            //Declare a new array of integers with 5 elements
            int[] numbers = new int[5];

            //initialize the array elements with values from input

            // we use numberOfElement only for printing which element user is entering
            int numberOfElements = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numberOfElements = i + 1;

                Console.WriteLine("enter the " + numberOfElements + " number:");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //sum all the values and print the result in the console
            int suma = 0;

            foreach (var num in numbers)
            {
                suma += num;
            }

            Console.WriteLine(suma);

            //------------------------------------------------------
            // DEFINITION 1
            //Declaration
            int[] numbers = new int[2];

            //Assignment
            numbers[0] = 10;
            numbers[1] = 20;

            // Note in this case we wont have compile time error but app will throw exception
            numbers[3] = 100;

            //DEFINITION 2
            // Declare and init at same time
            int[] nums = new int[2] { 10, 20 };

            //Note in this case we will have compile time error. Gues why?
            int[] errorNums = new int[2] { 10, 20 ,30 };

            // DEFINITION 3
            int[] numArray = new int[] { 10, 20, 30, 40, 50 };


            //------------------------------------------------------------
            // increment/decrement
            int number = 1;

            // we use it for checking if input from console is successfully converted
            bool result;

            while (true)
            {
                Console.WriteLine("Please enter a number:");

                result = int.TryParse(Console.ReadLine(), out number);

                // checking if number is converted successfully
                // if not we want to go to beggining ask the user to enter a number
                // note that if number is not converted all code after "continue" wont be executed
                if (result == false)
                    continue;

                // this code will be executed if result == true which means user entered number
                Console.WriteLine("Congratulations, you entered a number !");
                break;

            }

            // This example is the same but implemented with for instead with while
            // in this case we dont set condition which means that loop will be endless

            int num;
            bool res;
            for (int i = 0; ; i++)
            {
                Console.WriteLine("Please enter a number:");

                res = int.TryParse(Console.ReadLine(), out num);

                if (res == false)
                    continue;

                Console.WriteLine("Congratulations, you entered a number");
                break;
            }
            Console.ReadLine();
            //---------------------------------------------------------------------
            // SYNTAX


            // FOR
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //Print all even numbers to 100 with for
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }


            // WHILE
            int m = 0;

            while (m < 10)
            {
                Console.WriteLine(m);
                m++;
            }

            //Print all even numbers to 100 with while
            int increment = 1;
            while (increment <= 100)
            {
                if (increment % 2 == 0)
                    Console.WriteLine(increment);

                increment++;
            }


            // DO WHILE
            int n = 0;
            do
            {
                Console.WriteLine(n);
                n++;

            } while (n < 10);

            //Print all even numbers to 100 with do while
            int i = 1;
            do
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);

                i++;
            } while (i <= 100);


            Console.ReadLine();
        }
    }
}
