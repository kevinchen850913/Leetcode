public class Solution
{
    public int[][] Transpose(int[][] A)
    {
        int[][] B = new int[A[0].Length][];
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < A[i].Length; j++)
            {
                if (i == 0)
                {
                    B[j] = new int[A.Length];
                }
                B[j][i] = A[i][j];
            }
        }
        return B;
    }
}