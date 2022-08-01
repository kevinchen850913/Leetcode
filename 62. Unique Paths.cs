public class Solution
{
    public int UniquePaths(int m, int n)
    {
        int[,] nums = new int[m, n];
        nums[0, 0] = 1;
        for (int i = 1; i < m; i++)
        {
            nums[i, 0] = 1;
        }
        for (int i = 1; i < n; i++)
        {
            nums[0, i] = 1;
        }
        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                nums[i, j] = nums[i - 1, j] + nums[i, j - 1];
            }
        }
        return nums[m - 1, n - 1];
    }
}