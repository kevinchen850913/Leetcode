//這個答案會超時，不過我其實覺得沒問題。
public class Solution
{
    public string ReverseWords(string s)
    {
        string[] words = s.Split(' ');
        string S = "";
        foreach (string str in words)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                S += str[i];
            }
            S += " ";
        }
        return S.TrimEnd(' ');
    }
}

//這個答案也是極慢，感覺測試項目有點問題。
public class Solution
{
    public string ReverseWords(string s) =>
    string.Join(' ', s.Split(' ').Select(t => string.Concat(t.Reverse())));
}