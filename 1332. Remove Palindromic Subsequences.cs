public class Solution
{
    public int RemovePalindromeSub(string s)
    {
        char[] c = s.ToCharArray();
        int L = c.Length;
        if (L == 0)
        {
            return 0;
        }
        for (int i = 0; i < L / 2; i++)
        {
            if (c[i] != c[L - i - 1])
            {
                return 2;
            }
        }
        return 1;
    }
}