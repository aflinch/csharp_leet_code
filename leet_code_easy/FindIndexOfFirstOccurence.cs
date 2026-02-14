// Given two strings needle and haystack, return the index of the first occurrence of
// needle in haystack, or -1 if needle is not part of haystack.

namespace leet_code_easy
{
    public class FindIndexOfFirstOccurence
    {
        public static int StrStr (string haystack, string needle) {
            if (needle.Length == 0)  return -1;
            
            var haystackLength = haystack.Length;
            var needleLength = needle.Length;

            for (int i = 0; i <= haystackLength - needleLength; i++)
            {
                int j = 0;
                while (j < needleLength && haystack[i + j] == needle[j])
                {
                    j++;
                    if (j == needleLength) return i;
                }
            }
            return -1;
        }
    }
}