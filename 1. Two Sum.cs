//�Ĥ@�D�A���g�o�����C�ߡA²��ʼɡA���įण���C
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] n = { 0, 0 };
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    n[0] = i;
                    n[1] = j;
                    return n;
                }
            }
        }
        return n;
    }
}

//�令�o�Ӽg�k�ɶ��N�u�ݭn O(n + n) = O(n)
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Hashtable ht = new Hashtable();
        for (int i = 0; i < nums.Length; i++)
        {
            ht[nums[i]] = i;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (ht.ContainsKey(target - nums[i]) && (int)ht[target - nums[i]] != i)
            {
                return new int[] { (int)ht[target - nums[i]], i };
            }
        }
        return nums;
    }
}