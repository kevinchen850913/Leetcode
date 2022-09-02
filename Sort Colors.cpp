class Solution {
public:
    void sortColors(vector<int>& nums) {
        int color[2];
        for (int n : nums)
        {
            if (n == 0)
            {
                color[0]++;
                color[1]++;
            }
            if (n == 1)
            {
                color[1]++;
            }
        }
        int i = 0;
        for (; i < color[0]; i++)
        {
            nums[i] = 0;
        }
        for (; i < color[1]; i++)
        {
            nums[i] = 1;
        }
        for (; i < nums.size(); i++)
        {
            nums[i] = 2;
        }
    }
};