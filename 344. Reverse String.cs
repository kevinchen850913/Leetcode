//�����g������
public class Solution
{
    public void ReverseString(char[] s)
    {
        int L = s.Length;
        char c;
        for (int i = 0; i < L / 2; i++)
        {
            c = s[L - i - 1];
            s[L - i - 1] = s[i];
            s[i] = c;
        }
    }
}
//�{�b�g������
//�S���A�ɶ���Ŷ����ܮt�F
public class Solution
{
    public void ReverseString(char[] s)
    {
        Array.Reverse(s);
    }
}