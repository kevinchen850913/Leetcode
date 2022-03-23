//�����ϥΤG�i���N�ܦn�z��
//�i��N�O���G�A���ӴN�O�����
//�ۥ[�N�O����

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
