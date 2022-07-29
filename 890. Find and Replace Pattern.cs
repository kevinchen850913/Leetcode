public class Solution
{
    public IList<string> FindAndReplacePattern(string[] words, string pattern)
    {
        IList<string> L = new List<string>();
        pattern = F(pattern);
        foreach (var str in words)
        {
            if (F(str) == pattern)
                L.Add(str);
        }
        return L;
    }
    string F(string s)
    {
        Dictionary<char, int> D = new Dictionary<char, int>();
        string rt = "";
        int i = 0;
        foreach (var c in s)
        {
            if (!D.ContainsKey(c))
                D.Add(c, i++);
            rt += D[c];
        }
        return rt;
    }
}