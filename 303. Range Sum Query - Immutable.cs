public class NumArray
{
    int[] m_nums;
    public NumArray(int[] nums)
    {
        m_nums = nums;
    }

    public int SumRange(int left, int right)
    {
        int n = 0;
        for (int i = left; i <= right; i++)
        {
            n += m_nums[i];
        }
        return n;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */