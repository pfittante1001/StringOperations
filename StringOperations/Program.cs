﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string sound = "Bong";

            Console.WriteLine("\"" + sound + "\"");
            Console.WriteLine("\a");
            Console.WriteLine("\t Pete \n \t Fittante");
            */

            string word1 = "Apple";
            string word2 = "Apple";
            int stLen = word1.Length;
            string examp = word1 + " " + word2;

            bool equal = word1 == word2;
            bool equal2 = word1.Equals(word2);

            Console.WriteLine(equal + " " + equal2);
            Console.WriteLine(word1.Length);
            Console.WriteLine(stLen);
            Console.WriteLine(examp);

            for (int i = 0; i < stLen; i++)
            {
                Console.Write(word1[i]);
            }


        }
    }
}
