using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerBreakQuestionsConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = "I AM IRONMAN";
            int[] arr = { 1, 2, 3, 4, 5 };

            Console.WriteLine(removeDupes(s));
            Console.WriteLine(ReverseStringFunction(s));
            Console.WriteLine(AddPartOfArray(arr, 6));

            Console.ReadLine();
        }
        public static string removeDupes(string s)
        {
            string returnString = "";
            foreach(var item in s)
            {
                if(returnString.IndexOf(item) == -1)
                {
                    returnString += item;
                }
            }
            return returnString;
               
        }
        public static string ReverseStringFunction(string S)
        {
            string[] stringSplit = S.Split(' ');
            Array.Reverse(stringSplit);
            return String.Join(" ", stringSplit).ToString();
        }

        public static string AddPartOfArray(int[] arr, int sum)
        {
            if(arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int x = i + 1; x < arr.Length; x++)
                    {
                        int[] sumOfArray = new int[x - i + 1];
                        Array.Copy(arr, i, sumOfArray, 0, x - i + 1);
                        int newSum = sumOfArray.Sum();
                        if (newSum > sum)
                        {
                            x = arr.Length;
                        }
                        else if (sumOfArray.Sum() == sum)
                        {
                            return "sum found at " + i + " and " + x + ".";
                        }

                    }
                }
            }
            return "No Sum Found";

        }
    }
}
