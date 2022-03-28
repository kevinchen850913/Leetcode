//不太懂題目，暴力解的時間只有N，這答案只省了一點。
public class Solution
{
    public bool Search(int[] nums, int target)
    {
        if (target >= nums[0])
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (target < nums[i])
                    return false;
                if (target == nums[i])
                    return true;
            }
        }
        else
        {
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (target > nums[i])
                    return false;
                if (target == nums[i])
                    return true;
            }
        }
        return false;
    }
}

//二分逼近法的變形解，O(log n)
public class Solution
{
    public bool Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int mid;
        while (left <= right)
        {
            mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return true;
            }
            if (nums[left] < nums[mid])
            {
                if (nums[left] <= target && target < nums[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            else if (nums[left] > nums[mid])
            {
                if (nums[mid] < target && target <= nums[right])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            else
                left++;
        }
        return false;
    }
}