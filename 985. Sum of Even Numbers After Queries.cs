public class Solution
{
    public int[] SumEvenAfterQueries(int[] nums, int[][] queries)
    {
        int[] rt = new int[queries.Length];
        int all = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                all += nums[i];
            }
        }
        for (int i = 0; i < queries.Length; i++)
        {
            if (nums[queries[i][1]] % 2 == 0)
            {
                if (queries[i][0] % 2 == 0)
                {
                    all += queries[i][0];
                }
                else
                {
                    all -= nums[queries[i][1]];
                }
            }
            else if (queries[i][0] % 2 != 0)
            {
                all += queries[i][0];
                all += nums[queries[i][1]];
            }
            nums[queries[i][1]] += queries[i][0];
            rt[i] = all;
        }
        return rt;
    }
}