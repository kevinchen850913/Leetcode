public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        char[] cs1 = new char[s.Length + 1];
        char[] cs2 = new char[t.Length + 1];
        int i = 0;
        int j = 0;
        foreach (var c in s)
        {
            if (c == '#')
            {
                if (i > 0)
                {
                    i--;
                }
            }
            else
            {
                cs1[i] = c;
                i++;
            }
        }
        foreach (var c in t)
        {
            if (c == '#')
            {
                if (j > 0)
                {
                    j--;
                }
            }
            else
            {
                cs2[j] = c;
                j++;
            }
        }
        if (i != j)
        {
            return false;
        }
        for (int k = 0; k < i; k++)
        {
            if (cs1[k] != cs2[k])
            {
                return false;
            }
        }
        return true;
    }
}