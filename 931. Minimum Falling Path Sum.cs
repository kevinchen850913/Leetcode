using System.Linq;

public class Solution
{
    public int MinFallingPathSum(int[][] matrix)
    {
        int n = 0;
        for (int i = 1; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                n = matrix[i - 1][j];
                if (j > 0)
                {
                    n = n < matrix[i - 1][j - 1] ? n : matrix[i - 1][j - 1];
                }
                if (j < matrix[0].Length - 1)
                {
                    n = n < matrix[i - 1][j + 1] ? n : matrix[i - 1][j + 1];
                }
                matrix[i][j] += n;
            }
        }
        return matrix[matrix.Length - 1].Min();
    }
}