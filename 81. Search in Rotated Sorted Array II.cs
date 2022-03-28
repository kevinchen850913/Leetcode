//�������D�ءA�ɤO�Ѫ��ɶ��u��N�A�o���ץu�٤F�@�I�C
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

//�G���G��k���ܧθѡAO(log n)
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