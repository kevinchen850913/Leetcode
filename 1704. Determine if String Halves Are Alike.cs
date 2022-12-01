using System.Collections.Generic;

public class Solution
{
    public bool HalvesAreAlike(string s)
    {
        HashSet<char> set = new HashSet<char>(new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' });
        int len = s.Length / 2;
        int cnt = 0;
        for (int i = 0; i < len; i++)
        {
            if (set.Contains(s[i]))
                cnt++;
        }

        for (int i = len; i < s.Length; i++)
        {
            if (set.Contains(s[i]))
                cnt--;
        }
        return cnt == 0;
    }
}