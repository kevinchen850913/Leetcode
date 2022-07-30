public class Solution
{
    public IList<string> WordSubsets(string[] words1, string[] words2)
    {
        IList<string> L = new List<string>();
        Dictionary<char, int> ht = new Dictionary<char, int>();
        Dictionary<char, int> ht2 = new Dictionary<char, int>();
        bool b = true;
        foreach (var s in words2)
        {
            ht2 = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (!ht2.ContainsKey(c))
                {
                    ht2.Add(c, 0);
                }
                ht2[c]++;
            }
            foreach (var o in ht2)
            {
                if (!ht.ContainsKey(o.Key))
                {
                    ht.Add(o.Key, o.Value);
                }
                else if (ht[o.Key] < o.Value)
                {
                    ht[o.Key] = o.Value;
                }
            }
        }
        foreach (var s in words1)
        {
            ht2 = new Dictionary<char, int>();
            b = true;
            foreach (var c in s)
            {
                if (!ht2.ContainsKey(c))
                {
                    ht2.Add(c, 0);
                }
                ht2[c]++;
            }
            foreach (var o in ht)
            {
                if (!ht2.ContainsKey(o.Key) || (ht2[o.Key] < o.Value))
                {
                    b = false;
                    break;
                }
            }
            if (b)
            {
                L.Add(s);
            }
        }
        return L;
    }
}