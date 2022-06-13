public class Solution
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        int minSum = Int32.MaxValue;
        for (int i = 0; i < triangle.Count; i++)
        {
            minSum = Int32.MaxValue;
            for (int j = 0; j < triangle[i].Count; j++)
            {
                if (i == 0) { }
                else if (j == 0)
                    triangle[i][j] += triangle[i - 1][j];
                else if (j == triangle[i].Count - 1)
                    triangle[i][j] += triangle[i - 1][j - 1];
                else
                    triangle[i][j] += Math.Min(triangle[i - 1][j], triangle[i - 1][j - 1]);
                if (minSum > triangle[i][j])
                    minSum = triangle[i][j];
            }
        }
        return minSum;
    }
}