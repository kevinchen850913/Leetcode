//二分逼近法變形
public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        if (matrix == null || matrix.Length == 0)
            return false;
        int s = 0,
            e = matrix.Length * matrix[0].Length - 1;
        while (s <= e)
        {
            int mid = s + (e - s) / 2,
                x = mid / matrix[0].Length,
                y = (mid - x * matrix[0].Length) % matrix[0].Length;

            if (matrix[x][y] == target)
                return true;
            else if (matrix[x][y] < target)
                s = mid + 1;
            else
                e = mid - 1;
        }
        return false;
    }
}