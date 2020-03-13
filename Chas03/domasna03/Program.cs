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

            Console.Write("enter a number ++> ");
            var userInput = Console.ReadLine();
            int validNumber;
            bool validInput = int.TryParse(userInput, out validNumber);

            if (validInput)
            {

                for (int i = 1; i <= validNumber; i++)
                {
                    Console.WriteLine(i);
                }

            }
            else
            {
                Console.WriteLine("pls enter a number");
            }

            Console.Write("enter a number <-- ");
            var userInput1 = Console.ReadLine();
            int validNumber1;
            bool validInput1 = int.TryParse(userInput1, out validNumber1);

            if (validInput1)
            {
                for (int i = validNumber1; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("pls enter a number");
            }

            ////            EXERCISE 02:

            ////Get an input number from the console
            ////Print all even numbers starting from 2
            ////Get another input number from the console
            ////Print all odd numbers starting from 1

            Console.Write("enter a number <even> ");
            var userInput2 = Console.ReadLine();
            int validNumber2;
            bool validInput2 = int.TryParse(userInput2, out validNumber2);

            if (validInput2)
            {
                for (int i = 1; i <= validNumber2; i++)
                {
                    if (i % 2 == 0)
                        Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("pls enter a number");
            }

            Console.Write("enter a number <odd> ");
            var userInput3 = Console.ReadLine();
            int validNumber3;
            bool validInput3 = int.TryParse(userInput3, out validNumber3);

            if (validInput3)
            {
                for (int i = 0; i <= validNumber3; i++)
                {
                    if (i % 2 == 1)
                        Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("pls enter a number");
            }

            //            EXERCISE 03:

            //Create an array with names
            //Give an option to the user to enter a name from the keyboard
            //After entering the name put it in the array
            //Ask the user if they want to enter another name(Y / N)
            //Do the same process over and over until the user enters N
            //Print all the names after user enters N
            //Hint: we need to use endless loop until user enter N, then we want to "break" the loop


            string[] listaSoIminja = new string[] { "Dime", "Bocka", "Ogi" };
            Console.Write("Enter a name in the list: ");
            var addName = Console.ReadLine();

            
            string vnesenoIme;
            vnesenoIme = addName;
            int broj;

            bool brojka = int.TryParse(addName, out broj);
            string yes1 = "y";

            int dodajKocka = listaSoIminja.Length + 1;
            int vnesiVoKocka = listaSoIminja.Length;

            
            if (!brojka)
            {
                Console.WriteLine($"You have added <{vnesenoIme}> to the list of names");
                Array.Resize(ref listaSoIminja, dodajKocka);
                listaSoIminja[vnesiVoKocka] = vnesenoIme;
                Console.WriteLine();
                Console.Write("Do want to enter another name(Y / N) ");

                var yesNo = Console.ReadLine();
                string akoE = yesNo;

                while (akoE == yes1)
                {
                    string ime;
                    Console.Write("Enter a name in the list:  ");
                    var novoIme = Console.ReadLine();
                    ime = novoIme;

                    dodajKocka = listaSoIminja.Length + 1;
                    Array.Resize(ref listaSoIminja, dodajKocka);
                    vnesiVoKocka = vnesiVoKocka + 1;
                    listaSoIminja[vnesiVoKocka] = ime;
                    Console.WriteLine();
                    Console.Write("Do want to enter another name(Y / N) : ");

                    akoE = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("PLSS enter a name!");
            }
            Console.WriteLine();
            Console.WriteLine("THE LIST OF NAMES : ");
            foreach (var item in listaSoIminja)
            {
                Console.WriteLine();
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
