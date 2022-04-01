//早期寫的答案
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
//現在寫的答案
//沒錯，時間跟空間都變差了
public class Solution
{
    public void ReverseString(char[] s)
    {
        Array.Reverse(s);
    }
}