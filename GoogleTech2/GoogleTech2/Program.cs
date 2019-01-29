using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTech2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string text = "11c123xyz";
            var sum = SumNumbers(text);
            Console.WriteLine($"Sum : {sum}");
            Console.ReadKey();
        }

        private static int SumNumbers(string text)
        {
            string combinedNumberText = "";
            bool IsStillNumber = false;
            List<int> intList = new List<int>();
            var charList = text.ToCharArray();

            foreach (var item in charList)
            {
                //control if the char is Digit or not
                if (Char.IsDigit(item))
                {
                    combinedNumberText += item;
                    IsStillNumber = true;
                }

                else
                {
                    if (IsStillNumber)
                    {
                        intList.Add(Int32.Parse(combinedNumberText));
                        combinedNumberText = "";
                    }
                    IsStillNumber = false;
                    continue;
                }
            }

            //control if the end of the string
            if (IsStillNumber)
            {
                intList.Add(Int32.Parse(combinedNumberText));
            }
            return intList.Sum();
        }
    }
}
