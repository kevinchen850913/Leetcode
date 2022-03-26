//�����i��j�M�A²������ŦX�D�N�C
public class Solution
{
    public int Search(int[] nums, int target)
    {
        int nl = nums.Length;
        for (int i = 0; i < nl; i++)
        {
            if (nums[i] == target)
                return i;
        }
        return -1;
    }
}

//�̷��D�N�ϥΤG���G��k�C
public class Solution
{
    public int Search(int[] nums, int target)
    {
        int a = 0;
        int b = nums.Length - 1;
        int c;
        while (true)
        {
            c = (a + b) / 2;
            if (nums[c] == target)
                return c;
            if (c == b)
                return -1;
            if (nums[c] < target)
                a = c + 1;
            else
                b = c;
        }
    }
}