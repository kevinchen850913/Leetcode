public class Solution
{
    public int MinCost(string colors, int[] neededTime)
    {
        int rt = 0;
        for (int i = 1; i < neededTime.Length; i++)
        {
            if (colors[i] == colors[i - 1])
            {
                if (neededTime[i] >= neededTime[i - 1])
                {
                    rt += neededTime[i - 1];
                }
                else
                {
                    rt += neededTime[i];
                    neededTime[i] = neededTime[i - 1];
                }
            }
        }
        return rt;
    }
}