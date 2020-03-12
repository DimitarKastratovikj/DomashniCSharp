using System;

namespace domasna03
{
    class Program
    {
        static void Main(string[] args)
        {
            ////            EXERCISE 01:

            //Get an input number from the console
            //Print all numbers from 1 to that number
            //Get another input number from the console
            //Print all numbers from that number to 1

            //Console.Write("enter a number ++> ");
            //var userInput = Console.ReadLine();
            //int validNumber;
            //bool validInput = int.TryParse(userInput, out validNumber);

            //if (validInput)
            //{
            //    for (int i = 1; i <= validNumber; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.Write("enter a number <-- ");
            //var userInput1 = Console.ReadLine();
            //int validNumber1;
            //bool validInput1 = int.TryParse(userInput1, out validNumber1);

            //if (validInput1)
            //{
            //    for (int i = validNumber1; i >= 1; i--)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////            EXERCISE 02:

            ////Get an input number from the console
            ////Print all even numbers starting from 2
            ////Get another input number from the console
            ////Print all odd numbers starting from 1

            //Console.Write("enter a number <even> ");
            //var userInput2 = Console.ReadLine();
            //int validNumber2;
            //bool validInput2 = int.TryParse(userInput2, out validNumber2);

            //if (validInput2)
            //{
            //    for (int i = 1; i <= validNumber2; i++)
            //    {
            //        if (i % 2 == 0)
            //            Console.WriteLine(i);
            //    }
            //}

            //Console.Write("enter a number <odd> ");
            //var userInput3 = Console.ReadLine();
            //int validNumber3;
            //bool validInput3 = int.TryParse(userInput3, out validNumber3);

            //if (validInput3)
            //{
            //    for (int i = 0; i <= validNumber3; i++)
            //    {
            //        if (i % 2 == 1)
            //            Console.WriteLine(i);
            //    }
            //}

            //            EXERCISE 03:

            //Create an array with names
            //Give an option to the user to enter a name from the keyboard
            //After entering the name put it in the array
            //Ask the user if they want to enter another name(Y / N)
            //Do the same process over and over until the user enters N
            //Print all the names after user enters N
            //Hint: we need to use endless loop until user enter N, then we want to "break" the loop


            string[] strNames = new string[] { "Dime", "Bocka", "Ogi" };
            Console.Write("Enter a name in the list: ");
            var addName = Console.ReadLine();
            int fInput;
            string trueString;
            bool falceImp = int.TryParse(addName,out fInput);

            if (!falceImp)
            {
                trueString = addName;
                Console.WriteLine($"You have added <{trueString}> to the list of names");
                Array.Resize(ref strNames, 4);
                strNames[3] = trueString;
                Console.WriteLine();

                string yes = "y";
                string no = "y";
                //while (!falceImp)
                //{

                //    Console.Write("Do want to enter another name(Y / N) ");
                //    string yesNo = Console.ReadLine();
                    
                //    //if (yesNo == yes)
                //    //{
                //    //    for (int i = 0; i < ; i++)
                //    //    {

                //    //    }
                //    //}

                //}

            }
            else
            {
                Console.WriteLine("Enater a Valid name!");
            }
            
            foreach (var item in strNames)
            {
                Console.WriteLine();
                Console.WriteLine(item);
            }


            Console.ReadLine();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("Enter a number: ");
            //    string input = Console.ReadLine();
            //    if (!int.TryParse(input, out array[i])
            //    {
            //        // Tell the user something went wrong:
            //        Console.WriteLine("Sorry, '{0}' is not a valid number.", input);

            //        // Don't move to the next array element:
            //        i--;
            //    }
            //}

            Console.ReadLine();
        }
    }
}
