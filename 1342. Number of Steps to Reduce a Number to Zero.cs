public class Solution
{
    public int NumberOfSteps(int num)
    {
        int i = num & 1;
        while (num > 1)
        {
            num = num >> 1;
            i = i + (num & 1) + 1;
        }
        return i;
    }
}