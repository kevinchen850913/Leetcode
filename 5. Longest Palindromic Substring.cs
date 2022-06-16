public class Solution
{
    public string LongestPalindrome(string s)
    {
        char[] c1;
        c1 = s.ToCharArray();
        int mi = 0, mj = 0;
        for (int i = 0; i <= s.Length; i++)
        {
            int k = 0;
            for (int j = 0; i - j >= 0 && i + j < s.Length; j++)
            {
                if (c1[i - j] != c1[i + j])
                {
                    k = 2 * (j - 1) + 1;
                    break;
                }
                k = 2 * j + 1;
            }

            if (k >= mj)
            {
                mi = i;
                mj = k;
            }

            for (int j = 1; i - j + 1 >= 0 && i + j < s.Length; j++)
            {
                if (c1[i - j + 1] != c1[i + j])
                {
                    k = 2 * (j - 1);
                    break;
                }
                k = 2 * j;
            }

            if (k >= mj)
            {
                mi = i;
                mj = k;
            }
        }

        string str = "";
        if (mj % 2 == 0)
        {
            for (int i = (-mj / 2) + 1; i <= mj / 2; i++)
            {
                str += c1[mi + i];
            }
        }
        else
        {
            for (int i = (1 - mj) / 2; i <= (mj - 1) / 2; i++)
            {
                str += c1[mi + i];
            }
        }
        return str;
    }
}