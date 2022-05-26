public class Solution
{
    public int HammingWeight(uint n)
    {
        int result = 0;
        while (n > 0)
        {
            result += (int)n & 1;
            n = n >> 1;
        }
        return result;
    }
}

//���e�g�L���@��Ѫk
using System.Text.RegularExpressions;
public class Solution
{
    public int HammingWeight(uint n)
    {
        return Regex.Matches(Convert.ToString(n, 2), "1").Count;
    }
}