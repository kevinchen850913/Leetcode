//LINQ都是糖，不過簡單好用。
public class Solution
{
    public int MaximumUnits(int[][] boxTypes, int truckSize)
    {
        int ret = 0;
        var queryOrder = boxTypes.OrderByDescending(e => e[1]);
        foreach (var nums in queryOrder)
        {
            if (nums[0] > truckSize)
            {
                ret += truckSize * nums[1];
                break;
            }
            ret += nums[0] * nums[1];
            truckSize -= nums[0];
        }
        return ret;
    }
}