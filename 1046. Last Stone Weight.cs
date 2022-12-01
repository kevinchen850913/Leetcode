using System;

public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        if (stones.Length == 1)
        {
            return stones[0];
        }
        Array.Sort(stones);
        while (stones[stones.Length - 2] != 0)
        {
            stones[stones.Length - 1] -= stones[stones.Length - 2];
            stones[stones.Length - 2] = 0;
            Array.Sort(stones);
        }
        return stones[stones.Length - 1];
    }
}