//偷懶直接抄作業
//邏輯解釋
//1.用二分法直接猜測答案
//2.測試答案是否正確
//3.正確就猜更小的數，錯誤就反之
//4.猜到最小的正確答案結束
//時間 N^2 ，答案靠猜，這題一點都不浪漫

public class Solution
{
    public int SplitArray(int[] nums, int m)
    {
        long low = 0;
        long high = 0; // long to avoid overflow
        foreach (var num in nums)
        {
            low = Math.Max(low, num);
            high += num;
        }
        while (low < high)
        {
            long mid = low + (high - low) / 2;

            if (Valid(nums, m, mid))
                high = mid;
            else
                low = mid + 1;
        }
        return (int)low;
    }

    private bool Valid(int[] nums, int m, long sizeConstraint)
    {
        var count = 1;
        long currentBucketSize = 0;
        foreach (var num in nums)
        {
            if (currentBucketSize + num <= sizeConstraint)
                currentBucketSize += num;
            else
            {
                count += 1;
                currentBucketSize = num;
            }
        }
        return count <= m;
    }
}