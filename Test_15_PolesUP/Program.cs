using System;
using System.Linq;

namespace Test_15_PolesUP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку символов");
            string str = Console.ReadLine();

            int max = 0;
            int min = 0;
            int difference;

            for (int i = 0; i < str.Length; i++)
            {
                int check = 0;

                for (int j = 0; j < str.Length; j++)
                {

                    if (str[i].ToString() == " ") { continue; }

                    if (str[i] == str[j])
                    {
                        check++;
                    }

                    if (check > max)
                    {
                        max = check;
                    }

                    if (check < min || min == 0)
                    {
                        min = check;
                    }
                }

            }

            difference = max - min;

            Console.WriteLine(difference);



        }
    }
}