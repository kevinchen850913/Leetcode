public class Solution
{
    public int NumIslands(char[][] grid)
    {
        int n = 0;
        for (int j = 0; j < grid.Length; j++)
        {
            for (int i = 0; i < grid[0].Length; i++)
            {
                if (grid[j][i] == '1')
                {
                    FloodFill(grid, j, i);
                    n = n + 1;
                }
            }
        }
        return n;
    }

    public void FloodFill(char[][] image, int y, int x)
    {
        if (y < 0 || x < 0 || y == image.Length || x == image[0].Length || image[y][x] == '0')
        {
            return;
        }
        image[y][x] = '0';
        FloodFill(image, y + 1, x);
        FloodFill(image, y - 1, x);
        FloodFill(image, y, x + 1);
        FloodFill(image, y, x - 1);
        return;
    }
}