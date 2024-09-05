using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmCsharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string reverseString = "";
            string stringPadrao = "";
            if (args.Length > 0)
            {
                reverseString = inverter(args[0]);
            } else 
            {
                Console.Write("digite a string: ");
                stringPadrao = Console.ReadLine();
                reverseString = inverter(stringPadrao);
            }

            Console.WriteLine(reverseString);
        }

        public static string inverter(string stringPadrao)
        {
            string reverseString = "";
            for (int count=0; count<stringPadrao.Length; count++)
            {
                reverseString += stringPadrao[stringPadrao.Length - count -1];
            }

            return reverseString;
        }
    }
}