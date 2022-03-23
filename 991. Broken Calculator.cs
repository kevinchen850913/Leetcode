//直接使用二進為就很好理解
//進位就是乘二，插植就是減的次數
//相加就是答案

public class Solution
{
    public int BrokenCalc(int X, int Y)
    {
        int steps = 0;
        while (Y != X)
        {
            if (Y > X)
            {
                if (Y % 2 == 1)
                    Y++;
                else
                    Y /= 2;
            }
            else
            {
                return steps + (X - Y);
            }
            steps++;
        }
        return steps;
    }
}
