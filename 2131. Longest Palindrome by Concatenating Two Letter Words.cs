public class Solution
{
    public int LongestPalindrome(string[] words)
    {
        Dictionary<string, int> Dic = new Dictionary<string, int>();
        int num = 0;
        int rt = 0;
        string s = "";
        foreach (string str in words)
        {
            if (str[0] == str[1])
            {
                num++;
            }
            if (!Dic.ContainsKey(str))
            {
                Dic.Add(str, 0);
            }
            s = str[1].ToString() + str[0].ToString();
            if (Dic.ContainsKey(s) && Dic[s] > 0)
            {
                Dic[s]--;
                rt += 4;
                if (str[0] == str[1])
                {
                    num -= 2;
                }
            }
            else
            {
                Dic[str]++;
            }
        }
        if (num > 0)
        {
            rt += 2;
        }
        return rt;
    }
}