using System.Linq;

public class Solution
{
    public int LongestPalindrome(string s)
    {
        var result = s.GroupBy(c => c).Sum(g => g.Count() & (~1));
        return result == s.Length ? result : result + 1;
    }
}