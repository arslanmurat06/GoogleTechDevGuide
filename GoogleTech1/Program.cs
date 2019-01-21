    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTech1
{
    class Program
    {
        private static string[] words = {"able", "ale", "apple", "bale", "kangaroo","applee" };
        private static string word = "abppplee";
        private static string longestWord = "";

        static void Main(string[] args)
        {
            FindTheLongestWord(word, words);

            Console.WriteLine($"LongestWord = {longestWord}");
            Console.ReadKey();
        }

        private static void FindTheLongestWord(string word, string[] words)
        {
            int count =0;
            bool hasExcited = false;
        
            foreach (var item in words)
            {
                var a = item.ToCharArray();
                var b = word.ToCharArray().ToList();
                for (int i = 0; i < a.Count(); i++)
                {
                    if (b.IndexOf(a[i]) < 0 )
                    {
                        hasExcited = true;
                        break;
                    }
                    else if (b.IndexOf(a[i]) < i)
                    {
                        hasExcited = true;
                        break;
                    }

                    else
                    {
                        hasExcited = false;
                        count++;
                        
                    }

                    
                }
                if (!hasExcited)
                {
                    if (item.Count() > longestWord.Count())
                    {
                        longestWord = item;
                    }
                }
              
                
            }
        }
    }
}
