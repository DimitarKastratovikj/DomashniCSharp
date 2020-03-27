using System;

namespace LoginRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user! If u want to LogIn press 1");
            Console.WriteLine(" if u want to Register press 2");

            var userChoise = Console.ReadLine();
            int validUserChoise;
            bool validUserNumberChoise = int.TryParse(userChoise, out validUserChoise);

            string username, password;
            string newUsername, newPassword;
            string[] listaSoUsernames = new string[3] { "Admin", "Dime", "Jasmina" };
            string[] listaSoPasswords = new string[3] { "Ad#mi8$s@", "kastro", "jasmin" };

            //Console.WriteLine(listaSoUsernames[0]);


            if (validUserNumberChoise && validUserChoise == 1)
            {
                Console.WriteLine("Welcome Old User, Pls enter Username And Password");
                Console.Write("Enter Username: ");
                username = Console.ReadLine();
                Console.Write("Enter Password: ");
                password = Console.ReadLine();
                if (listaSoUsernames[0] == "Admin" && listaSoPasswords[0] == "Ad#mi8$s@")
                {
                    Console.WriteLine("Welcome Administrator,");
                    Console.WriteLine(" for List of all Users press 1 ");
                    Console.WriteLine(" to Delete User press 2 ");
                    userChoise = Console.ReadLine();
                    validUserNumberChoise = int.TryParse(userChoise, out validUserChoise);
                    if (validUserNumberChoise && validUserChoise == 1)
                    {
                        for (int i = 0; i < listaSoUsernames.Length; i++)
                        {
                            Console.WriteLine(listaSoUsernames[i]);
                        }

                    }
                }



            }
            else if (validUserNumberChoise && validUserChoise == 2)
            {
                Console.WriteLine("Welcome NEW User, Pls enter new Username And Password");
                Console.Write("Enter new  Username: ");
                newUsername = Console.ReadLine();
                Console.Write("Enter new  Password: ");
                newPassword = Console.ReadLine();



            }
            else
            {
                Console.WriteLine("psl try 1 or 2");
            }




            Console.ReadLine();
        }
    }
}
