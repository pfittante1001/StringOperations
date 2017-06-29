using System;
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

            //string word1 = "Apple";
            //string word2 = "Apple";
            //int stLen = word1.Length;
            //string examp = word1 + " " + word2;

            //bool equal = word1 == word2;
            //bool equal2 = word1.Equals(word2);

            //Console.WriteLine(equal + " " + equal2);
            //Console.WriteLine(word1.Length);
            //Console.WriteLine(stLen);
            //Console.WriteLine(examp);
            //Console.WriteLine();
            //Console.WriteLine("Frist word {0} second word {1}.", word1, word2);//very cool

            //for (int i = 0; i < stLen; i++)
            //{
            //    Console.Write(word1[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("This is a tab \t \nThis is a backspace \\ \nThis is a bell sound \a ");
           
            
            //Console.Write("Please enter a first name: ");
            //string firtName = Console.ReadLine();
            //Console.Write("Please enter a second name: ");
            //string secondName = Console.ReadLine(); ;

            //int flength = firtName.Length;
            //int sLenght = secondName.Length;

            //if (flength > sLenght)
            //{
            //    Console.WriteLine("First is longer " + flength);
            //}else if (flength == sLenght)
            //{
            //    Console.WriteLine("Samsis");
            //}
            //else
            //{
            //    Console.WriteLine("last must be longer " + sLenght);
            //}


            Console.Write("Please enter a first name: ");
            string firtName = Console.ReadLine();
            
            string secondName = "cat";

            if (firtName.ToLower() == secondName)
            {
                Console.WriteLine("You guessed correctly");
            }
            else
            {
                Console.WriteLine("You guessed incorrectly");
            }
            

            
            
        }
    }
}
