using System;

namespace odg7chas2
{
    class DataEntryAndConversion
	{
        static void Main(string[] args)
        {
            #region /*1*/
            Console.WriteLine("Hello World!");
			// Enter data through the keyboard with Console.ReadLine()

			Console.WriteLine("Enter name:");
			string name = Console.ReadLine();
			Console.WriteLine("Enter Age:");
			string age = Console.ReadLine();

			// Try and convert the age to int
			int ageConverted1 = int.Parse(age);

			//int ageBroken1 = int.Parse("Bob");
			int ageConverted2 = Convert.ToInt32(age);
			int ageConverted3 = 0;
			bool isConvertingSuccessful = int.TryParse(age, out ageConverted3);
			int ageConverted4 = 0;
			bool brokenConvert = int.TryParse("Bob", out ageConverted4);

			Console.WriteLine("Parse: " + ageConverted1);
			Console.WriteLine("Convert: " + ageConverted2);
			Console.WriteLine("TryParse Result: " + ageConverted3 + " Success: " + isConvertingSuccessful);
			Console.WriteLine("Broken Result: " + ageConverted4 + " Success: " + brokenConvert);
			Console.WriteLine("Welcome " + name + " (" + age + ") ");

			Console.ReadLine();
			#endregion

			#region /*2*/
			// How we declared on JS
			//let myVariable = "bob";
			int number = 9000;
			double decimalNumber = 0.2222;

			// If we have a build error it will not let us run our application
			// It will give us the option to run the code from the last time we had a working version
			Console.WriteLine("This is the BROKEN time!");
			//int anotherNumber = "bob";
			int empty;
			empty = 3;
			number = 2000;
			//number = "Jill";
			Console.WriteLine(number);
			//string name = "Bob";
			Console.WriteLine(name);
			Console.WriteLine(empty);
			char someCharacter1 = 'B';
			char someCharacter2 = '&';
			Console.WriteLine(someCharacter1.GetType()); // GetType returns the type of the variable
			Console.WriteLine("This is the OKAY time!");
			Console.ReadLine();
			#endregion

			#region /*3*/
			Console.WriteLine("Enter age:");
			int age1 = 0;
			bool isAgeCorrect = int.TryParse(Console.ReadLine(), out age1);

			if (isAgeCorrect == true && age1 >= 0)
			{
				Console.WriteLine("Your age was recorded in the database!");
			}
			else
			{
				Console.WriteLine("That's probobly not your age! Go away!");
			}
			Console.ReadLine();

			//// JS Convention of writing curly brackets
			//if (true)
			//{

			//}
			//// C# Convention of writing curly brackets
			//if (true)
			//{

			//}

			// Switch
			Console.WriteLine("Enter a week day:");
			int day = 0;
			bool isDayCorrect = int.TryParse(Console.ReadLine(), out day);

			switch (day)
			{
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
					Console.WriteLine("Work day :-(");
					break;
				case 6:
				case 7:
					Console.WriteLine("Chill time!");
					break;
				default:
					Console.WriteLine("No day like that!");
					break;
			}
			Console.ReadLine();

			#endregion
		}
	}
}
