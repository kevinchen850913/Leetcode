public class Solution
{
    public int FirstUniqChar(string s)
    {
        int index = -1;
        int[] count = new int[26];
        foreach (char ch in s)
            count[ch - 'a']++;
        for (int i = 0; i < s.Length; i++)
        {
            if (count[s[i] - 'a'] == 1)
                return i;
        }
        return index;
    }
}