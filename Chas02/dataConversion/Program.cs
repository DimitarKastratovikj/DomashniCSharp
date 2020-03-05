using System;

namespace dataConversion
{
    class Program
    {
        static void Main(string[] args)
        {

            //enter number from console

            //print number


            //Console.WriteLine("vnesi broj");

            //var input = Console.ReadLine();
            //int number;

            //bool result = int.TryParse(input, out number);

            //Console.WriteLine(number);
            //Console.WriteLine(result);

            //string input3 = ""

            Console.WriteLine("vnesi broj");

            var input = Console.ReadLine();

            int number1;
            int number2;

            bool reulst = int.TryParse(input, out number1);
            if (reulst) // ako e true .?
            {
                number2 = 100 / number1;
                Console.WriteLine(number2);
            }
            else
            {
                Console.WriteLine("KE VNESES JA SHO KE TI KAZAM");
            }

            

            

            Console.ReadLine();
        }
    }
}
