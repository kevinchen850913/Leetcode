public class Solution
{
    public bool IsPossible(int[] nums)
    {
        List<List<int>> LL = new List<List<int>>();
        List<List<int>> LLRemove = new List<List<int>>();
        bool Add;
        foreach (int n in nums)
        {
            Add = false;
            foreach (var L in LL)
            {
                if (L[L.Count - 1] + 1 == n && L.Count < 3)
                {
                    L.Add(n);
                    Add = true;
                    break;
                }
            }
            if (Add)
            {
                continue;
            }
            foreach (var L in LL)
            {
                if (L[L.Count - 1] + 1 == n)
                {
                    L.Add(n);
                    Add = true;
                    break;
                }
                else if (L[L.Count - 1] + 1 < n)
                {
                    if (L.Count < 3)
                        return false;
                    LLRemove.Add(L);
                }
            }
            foreach (var L in LLRemove)
            {
                LL.Remove(L);
            }
            LLRemove = new List<List<int>>();
            if (Add)
            {
                continue;
            }
            LL.Add(new List<int> { n });
        }
        foreach (var L in LL)
        {
            if (L.Count < 3)
                return false;
        }
        return true;
    }
}
