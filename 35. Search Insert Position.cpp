class Solution {
public:
    int searchInsert(vector<int>& nums, int target) {
        if (target < nums[0]) return 0;
        if (target > nums[nums.size() - 1]) return nums.size();
        return binarySearch(target, nums, 0, nums.size());
    }
    int binarySearch(int val, vector<int>& nums, int left, int right)
    {
        int m = (left + right) / 2;
        if (val == nums[m]) return m;
        if (val > nums[m] && val < nums[m + 1]) return m + 1;
        if (val < nums[m]) return binarySearch(val, nums, left, m);
        else               return binarySearch(val, nums, m + 1, right);
    }
};