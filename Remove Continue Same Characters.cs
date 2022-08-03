using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Same_Characters
{
    internal class Program
    {
        public static string SameChar(string characters)
        {
            if (characters.Length <= 1)
                return characters;
            if (characters[0] == characters[1])
                return SameChar(characters.Substring(2));
            else
                return characters[0] + SameChar(characters.Substring(1));
        }
        public static void Main(String[] args)
        {

            string S0 = "Beez";
            string S1 = "Waggle";
            Console.WriteLine("After Remove Characters S0 Is : " + SameChar(S0));
            Console.WriteLine("After Remove Characters S1 Is : " + SameChar(S1));
            Console.WriteLine();

            for (int i = 0; i <S0.Length; i++) 
                {
                    if (S0[i] != S0.Length)
                    {
                        Console.WriteLine("S0 Characters Position Is : " + S0.IndexOf(S0[i]));
                    }
                    if (S0[i] == S0.Length)
                    {
                        Console.WriteLine(S0);
                    }

                }
                Console.WriteLine(S0.Replace('e', 'k'));
                Console.WriteLine();


               for (int j = 0; j < S1.Length; j++)
               {
                if (S1[j] != S1.Length)
                {
                    Console.WriteLine("S1 Characters Position Is : " + S1.IndexOf(S1[j]));
                }
                if (S1[j] == S1.Length)
                {
                    Console.WriteLine(S1);
                }

            }
                    Console.WriteLine(S1.Replace('g', 'd'));
                    Console.ReadKey();
        }
    }
}


    

