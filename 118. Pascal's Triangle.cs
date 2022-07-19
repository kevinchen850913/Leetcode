//早期比較爛的答案
public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> l = new List<IList<int>>();
        IList<int> ll = new List<int>();
        int[] nums = new int[numRows];
        int[] nums2 = new int[numRows];
        ll = new List<int>();
        ll.Add(1);
        l.Add(ll);
        nums2[0] = 1;
        for (int i = 1; i < numRows; i++)
        {
            ll = new List<int>();
            nums2[i] = 1;
            for (int j = 0; j <= i; j++)
            {
                nums[j] = nums2[j];
            }
            ll.Add(1);
            for (int j = 1; j < i; j++)
            {
                nums2[j] = nums[j] + nums[j - 1];
                ll.Add(nums2[j]);
            }
            ll.Add(1);
            l.Add(ll);

        }
        return l;

    }
}