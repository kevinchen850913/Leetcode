public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        Hashtable ht = new Hashtable();
        if (s.Length != t.Length)
            return false;
        foreach (var c in s)
        {
            if (!ht.ContainsKey(c))
                ht.Add(c, 1);
            else
                ht[c] = (int)ht[c] + 1;
        }
        foreach (var c in t)
        {
            if (ht.ContainsKey(c) && (int)ht[c] > 0)
                ht[c] = (int)ht[c] - 1;
            else
                return false;
        }
        return true;
    }
}

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        char[] c1 = s.ToArray();
        char[] c2 = t.ToArray();
        Array.Sort(c1);
        Array.Sort(c2);
        for (int i = 0; i < c1.Length; i++)
        {
            if (c1[i] != c2[i])
                return false;
        }
        return true;
    }
}