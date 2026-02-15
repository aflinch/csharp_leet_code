namespace leet_code_easy
{
    public class LengthLastWord
    {
        public static int LengthOfLastWord(string s)
        {
            var charFound = false;
            var len = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (char.IsLetter(s[i]))
                {
                    charFound = true;
                    len++;
                }
                else
                {
                    if (charFound)
                    {
                        return len;
                    }
                }
            }
            
            return len;
        }
    }
}