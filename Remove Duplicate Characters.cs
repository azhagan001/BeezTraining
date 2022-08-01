using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicate_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Duplicate = "csharpcorner";
            Console.WriteLine("Initial String : " + Duplicate);
            var Character = new HashSet<char>(Duplicate);
            Console.WriteLine("After Remove Duplicate Characters : ");
            foreach (char d in Character)
                Console.Write(d);
            Console.WriteLine();
                while (Duplicate.Length > 0)
                {
                    int find = 0;
                    Console.Write(Duplicate[0] + " = ");
                    for (int i = 0; i < Duplicate.Length; i++)
                    {
                        if (Duplicate[i] == Duplicate[0])
                        {
                            find++;
                        }
                    }
                    Console.WriteLine(find);
                    Duplicate = Duplicate.Replace(Duplicate[0].ToString(), string.Empty);
                }
            Console.ReadLine();
        }
    }
}
