using System;

namespace HomeworkClass05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01 *Print individual characters of the string in reverse order. *Example: we love c# *Expected Output : #c evol ew
            string str1 = "we love c#";
            Console.WriteLine(str1);
            for (int i = 0; i < str1.Length; i++)
            {
                Console.Write(str1[str1.Length - i - 1]);
            }
            Console.WriteLine();
            #endregion

            #region 02
            Console.WriteLine();
            Console.WriteLine("Input a sentence: ");
            string usImp = Console.ReadLine();
            string[] zborcinja = usImp.Trim().Split(' ');
            Console.WriteLine("Number of words in the string = {0}", zborcinja.Length);
            Console.ReadLine();
            Console.WriteLine();
            #endregion

            #region 03 *Find maximum occurring character in a string *Example: "We want this situation with covid-19 to ends!"          
            string maxOcur = "We want this situation with covid-19 to ends!";
            char[] arr = maxOcur.ToCharArray();
            string maxChar = " ";
            int num = 0;
            int cc = num + 1;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[i]==arr[j])
                    {
                        num++;
                    }
                }
            }
            Console.WriteLine(arr.Length);

            Console.WriteLine("The highest frequency of character {0} appears number of times : {1} ", maxChar, num);
            #endregion

            #region 04 TASK 04 Print the whole text after "," in the console.
            string stringTest = "The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!";
            char[] delimiterChars = { ',' };
            string[] words = stringTest.Split(delimiterChars);
            Console.WriteLine(words[1]);

            #endregion
            #region 05
            #endregion

            #region 06
            #endregion

            #region 07
            #endregion








            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
