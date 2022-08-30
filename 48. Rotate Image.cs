public class Solution
{
    public void Rotate(int[][] matrix)
    {
        int Y = matrix.Length - 1;
        int X = matrix[0].Length - 1;
        int n;
        for (int j = 0; j < (Y / 2 + Y % 2); j++)
        {
            for (int i = 0; i <= X / 2; i++)
            {
                n = matrix[j][i];
                matrix[j][i] = matrix[Y - i][j];
                matrix[Y - i][j] = matrix[Y - j][X - i];
                matrix[Y - j][X - i] = matrix[i][X - j];
                matrix[i][X - j] = n;
            }
        }
    }
}