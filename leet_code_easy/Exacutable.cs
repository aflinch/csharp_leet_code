using System;

namespace leet_code_easy
{
    public class Exacutable
    {
        public static void Main()
        {
            int[] arr = { 0, 1, 3, 0, 2, 2, 4, 2 };
            var val = 2;
            Console.WriteLine(RemoveElement.RemoveElementFromList(arr, val));
            
            String s = "[()(]{}";
            Console.WriteLine(ValidParentheses.IsValid(s));
            
            String haystack = "sadbutsad";
            String needle = "sad";
            Console.WriteLine(FindIndexOfFirstOccurence.StrStr(haystack, needle));
        }
    }
}