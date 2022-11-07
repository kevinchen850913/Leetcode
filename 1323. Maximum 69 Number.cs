using System;

public class Solution
{
    public int Maximum69Number(int num)
    {
        string str = num.ToString();
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '6')
            {
                return num + 3 * (int)Math.Pow(10, str.Length - i - 1);
            }
        }
        return num;
    }
}