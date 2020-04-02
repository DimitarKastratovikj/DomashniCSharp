using System;

namespace LoginRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user!");
            Console.WriteLine("--If u want to LogIn press 1");
            Console.WriteLine("--if u want to Register press 2");

            var userChoise = Console.ReadLine();
            int validUserChoise;
            bool validUserNumberChoise = int.TryParse(userChoise, out validUserChoise);

            string username, password;
            string newUsername, newPassword;
            string[] listaSoUsernames = new string[3] { "Admin", "Dime", "Jasmina" };
            string[] listaSoPasswords = new string[3] { "1a", "kastro", "jasmin" };

            if (validUserNumberChoise && validUserChoise == 1)
            {
                Console.WriteLine("Welcome Old User, Pls enter Username And Password");
                Console.Write(" -- Enter Username: ");
                username = Console.ReadLine();
                Console.Write(" -- Enter Password: ");
                password = Console.ReadLine();
                if (username == listaSoUsernames[0] && password == listaSoPasswords[0])
                {
                    Console.WriteLine("Welcome Administrator,");
                    Console.WriteLine(" --- for List of all Users press 1 ");
                    Console.WriteLine(" --- to Delete User press 2 ");

                    userChoise = Console.ReadLine();
                    validUserNumberChoise = int.TryParse(userChoise, out validUserChoise);
                    if (validUserNumberChoise && validUserChoise == 1)
                    {

                        for (int i = 0; i < listaSoUsernames.Length; i++)
                        {
                            Console.WriteLine("-- {0}",listaSoUsernames[i]);
                        }

                    }
                    else if (validUserNumberChoise && validUserChoise == 2)
                    {

                        for (int i = 0; i < listaSoUsernames.Length; i++)
                        {
                            Console.WriteLine("-- {0}", listaSoUsernames[i]);
                        }
                        Console.WriteLine();
                        Console.Write("Select a user to delete: ");

                        string deleteUser = Console.ReadLine();
                        int userIndex = 0;

                        if (deleteUser == "Admin")
                        {
                            Console.WriteLine(" U CANNOT DELETE ADMIN !! ");
                        }
                        else if (deleteUser != "Admin")
                        {                     
                            if (userIndex != 0)
                            {
                                listaSoUsernames = Array.FindAll(listaSoUsernames, (user) 
                                    => Array.IndexOf(listaSoUsernames, user) != userIndex);

                                listaSoPasswords = Array.FindAll(listaSoPasswords, (user)
                                    => Array.IndexOf(listaSoPasswords, user) != userIndex);

                                Console.WriteLine("User was successfully deleted. Following users remaining:");
                                foreach (var user in listaSoUsernames)
                                {
                                    Console.WriteLine($"--- {user}");
                                }
                                Console.WriteLine("Password was successfully deleted. Following passwords remaining:");
                                foreach (var user in listaSoPasswords)
                                {
                                    Console.WriteLine($"--- {user}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter valid user to delete");
                            }
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

                string vnesenNovUsername;
                vnesenNovUsername = newUsername;
                int dodajKocka = listaSoUsernames.Length + 1;
                int vnesiVoKocka = listaSoUsernames.Length;

                Console.WriteLine($"You have added <{vnesenNovUsername}> to the list of names");
                Array.Resize(ref listaSoUsernames, dodajKocka);
                listaSoUsernames[vnesiVoKocka] = vnesenNovUsername;

                string vnesenNovPassword;
                vnesenNovPassword = newPassword;
                int dodajKocka1 = listaSoPasswords.Length + 1;
                int vnesiVoKocka1 = listaSoPasswords.Length;

                Console.WriteLine($"You have added <{vnesenNovPassword}> to the list of Passwords");
                Array.Resize(ref listaSoPasswords, dodajKocka1);
                listaSoPasswords[vnesiVoKocka1] = vnesenNovPassword;

                foreach (var user in listaSoUsernames)
                {
                    Console.WriteLine($"--- {user}");
                }
                Console.WriteLine("Passwords: ");
                foreach (var pass in listaSoPasswords)
                {
                    Console.WriteLine($"-- {pass}");
                }
            }
            else
            {
                Console.WriteLine("psl try 1 or 2");
            }

            Console.ReadLine();
        }
    }
}
