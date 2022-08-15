public class Solution
{
    public int RomanToInt(string s)
    {
        int n = 10000;
        int m = 0;
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case 'M':
                    if (n < 1000)
                    {
                        m -= n * 2;
                    }
                    n = 1000;
                    break;
                case 'D':
                    if (n < 500)
                    {
                        m -= n * 2;
                    }
                    n = 500;
                    break;
                case 'C':
                    if (n < 100)
                    {
                        m -= n * 2;
                    }
                    n = 100;
                    break;
                case 'L':
                    if (n < 50)
                    {
                        m -= n * 2;
                    }
                    n = 50;
                    break;
                case 'X':
                    if (n < 10)
                    {
                        m -= n * 2;
                    }
                    n = 10;
                    break;
                case 'V':
                    if (n < 5)
                    {
                        m -= n * 2;
                    }
                    n = 5;
                    break;
                case 'I':
                    if (n < 1)
                    {
                        m -= n * 2;
                    }
                    n = 1;
                    break;
            }
            m += n;
        }
        return m;
    }
}