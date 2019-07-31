using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class Program
    {

        public static string BestSolution(string sen)
        {
            string[] words = sen.Split(' ');

            return words.OrderByDescending(s => s.Length).First();
        }

        public static string LongestWord(string sen)
        {

            // code goes here  
            /* Note: In C# the return type of a function and the 
               parameter types being passed are defined, so this return 
               call must match the return type of the function.
               You are free to modify the return type. */

            List<string> words = new List<string>();

            words = sen.Split(' ').ToList();

            int longWord = 0;
            string currentWord = "";

            for(var i = 0; i < words.Count; i++)
            {
                if(words[i].Length > currentWord.Length)
                {
                    currentWord = words[i];
                    longWord = words[i].Length;
                }
            }

            sen = currentWord;
            return sen;

        }

        static void Main()
        {
            // keep this function call here
            string sen = Console.ReadLine();
            Console.WriteLine(LongestWord(sen));
            Console.WriteLine(BestSolution(sen));
            //Console.WriteLine(LongestWord(Console.ReadLine()));
            //Console.WriteLine(BestSolution(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}

//BEST SOLUTION BELOW

//using System;
//using System.Linq;

//class MainClass
//{
//    public static string LongestWord(string sen)
//    {

//        string[] words = sen.Split(' ');


//        return words.OrderByDescending(s => s.Length).First(); ;

//    }

//    static void Main()
//    {
//        // keep this function call here
//        Console.WriteLine(LongestWord(Console.ReadLine()));
//    }

//}