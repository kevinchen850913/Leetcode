using System.Collections;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        Hashtable ht = new Hashtable();
        int i = 0;
        foreach (var n in nums)
        {
            if (!ht.ContainsKey(n))
            {
                ht.Add(n, 0);
                nums[i] = n;
                i++;
            }
        }
        return i;
    }
}