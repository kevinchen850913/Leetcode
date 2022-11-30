using System.Collections;

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        Hashtable ht = new Hashtable();
        Hashtable ht2 = new Hashtable();
        foreach (var n in arr)
        {
            if (!ht.ContainsKey(n))
            {
                ht.Add(n, 0);
            }
            ht[n] = (int)ht[n] + 1;
        }
        foreach (DictionaryEntry o in ht)
        {
            if (ht2.ContainsKey(o.Value))
            {
                return false;
            }
            ht2.Add(o.Value, 0);
        }
        return true;
    }
}