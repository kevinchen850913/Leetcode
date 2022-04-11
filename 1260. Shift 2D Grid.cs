public class Solution
{
    public IList<IList<int>> ShiftGrid(int[][] grid, int k)
    {
        int[][] grid2 = new int[grid.Length][];
        for (int i = 0; i < grid.Length; i++)
        {
            grid2[i] = new int[grid[0].Length];
        }
        int mod = grid.Length * grid[0].Length;
        int n;
        for (int i = 0; i < mod; i++)
        {
            n = i + k < mod ? i + k : (i + k) % mod;
            grid2[n / grid[0].Length][j % grid[0].Length] = grid[n / grid[0].Length][i % grid[0].Length];
        }
        return grid2;
    }
}