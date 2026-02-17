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

            String words = "   fly me   to   the moon  ";
            Console.WriteLine(LengthLastWord.LengthOfLastWord(words));
            
            Console.WriteLine("Stack Using Queues");
            StackUsingQueues st = new StackUsingQueues();
            st.Push(1);
            st.Push(2);
            st.Push(3);
        
            Console.WriteLine(st.Top());
            st.Pop();
            Console.WriteLine(st.Top());
            st.Pop();
            Console.WriteLine(st.Top());
        
            Console.WriteLine(st.Empty());
        }
    }
}