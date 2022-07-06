public class Solution
{
    public int Fib(int n)
    {
        int[] nums = new int[n + 3];
        nums[1] = 1;
        nums[2] = 1;
        for (int i = 3; i <= n; i++)
        {
            nums[i] = nums[i - 1] + nums[i - 2];
        }
        return nums[n];
    }
}

public class Solution
{
    public int Fib(int n)
    {
        if (n >= 3)
            return Fib(n - 1) + Fib(n - 2);
        return n > 0 ? 1 : 0;
    }
}