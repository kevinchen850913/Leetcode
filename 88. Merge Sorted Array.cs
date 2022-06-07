public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int a = m - 1;
        int b = n - 1;
        for (int i = m + n - 1; i >= 0; i--)
        {
            if (a < 0 || b < 0)
            {
                for (; b >= 0; b--, i--)
                {
                    nums1[i] = nums2[b];
                }
                return;
            }
            if (nums1[a] > nums2[b])
            {
                nums1[i] = nums1[a];
                a--;
            }
            else
            {
                nums1[i] = nums2[b];
                b--;
            }
        }
        return;
    }
}

//早期寫的這個答案沒想像中爛，時間差距太少，但可讀性更加。
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = 0; i < n; i++)
        {
            nums1[m + i] = nums2[i];
        }
        Array.Sort(nums1);
        return;
    }
}

