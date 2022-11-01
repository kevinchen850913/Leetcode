public class Solution
{
    int[][] nums;
    public int[] FindBall(int[][] grid)
    {
        nums = grid;
        int[] num = new int[grid[0].Length];
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = DFS(i, 0);
        }
        return num;
    }
    int DFS(int x, int y)
    {
        if (y >= nums.Length)
        {
            return x;
        }
        if (x + nums[y][x] < 0 || x + nums[y][x] >= nums[0].Length || nums[y][x] != nums[y][x + nums[y][x]])
        {
            return -1;
        }
        return DFS(x + nums[y][x], y + 1);
    }
}