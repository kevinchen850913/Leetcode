//優雅且高效的答案
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int max = 0;
        string str = "";
        foreach (var c in s)
        {
            str = str.Remove(0, str.IndexOf(c) + 1) + c;
            max = max > str.Length ? max : str.Length;
        }
        return max;
    }
}