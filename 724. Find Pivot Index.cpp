class Solution {
public:
    int pivotIndex(vector<int>& nums) {
        int left = 0;
        int all = 0;
        for (int i = 0; i < nums.size(); i++)
        {
            all += nums[i];
        }
        for (int i = 0; i < nums.size(); i++)
        {
            if (all - left - left == nums[i])
            {
                return i;
            }
            left += nums[i];
        }
        return -1;
    }
};