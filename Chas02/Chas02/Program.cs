using System;

namespace Chas02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 02
            //int number = 10;

            //bool answer = true;

            //char bukva = 'a';

            //string tekst = "opa cupa";

            //var firstName = "Dime";

            //float floatNumber = 10.22f;
            //double doubleNumber = 10.22;
            //decimal decimalNumber = 10.22m;



            //Console.WriteLine(int.MaxValue);

            //byte od 0 do 225 moze da primi vrednost

            //byte bytenumber = 255;
            //byte byteee = 27;

            double doubleNumber1 = 155.22;
            double doubleNumber2 = 12.22;
            double doubleNumber3 = doubleNumber1/ doubleNumber2;

            Console.WriteLine(doubleNumber3);

            int number1 = 1211;
            int number2 = 20;
            int number3 = number1/ number2;
            Console.WriteLine(number3);
            #endregion

            #region 03
            //var broShoKegovneses = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(broShoKegovneses + 22);


            //Console.WriteLine();
            //Console.ReadLine();

            //string input = "10";
            //int number11 = (string) input;



            //int number = 255;
            //byte antNumber = (byte) number;


            //int.parse
            string input2 = "123";
            int numbervalue =int.Parse( input2);


            int val2 = Convert.ToInt32(input2);



#endregion
            Console.ReadLine();
        }
    }
}
