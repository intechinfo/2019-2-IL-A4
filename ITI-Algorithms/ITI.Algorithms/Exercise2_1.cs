using System.Collections.Generic;

namespace ITI.Algorithms
{
    public class Exercise2_1
    {
        public static bool ContainsDuplicateChar(string s)
        {
            HashSet<char> uniqueChars = new HashSet<char>();
            foreach (char c in s)
            {
                if (!uniqueChars.Add(c)) return true;
            }

            return false;
        }
    }
}
