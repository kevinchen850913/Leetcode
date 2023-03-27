class Solution {
public:
    int dfs(vector<vector<int>>& nums, vector<bool>& b, int i) {
        int n = 0;
        b[i] = true;
        for (auto v : nums[i])
        {
            if (!b[abs(v)])
            {
                n += v > 0;
                n += dfs(nums, b, abs(v));
            }
        }
        return n;
    }

    int minReorder(int n, vector<vector<int>>& connections) {
        vector<vector<int>> nums(n);
        for (auto v : connections)
        {
            nums[v[0]].push_back(v[1]);
            nums[v[1]].push_back(-v[0]);
        }
        return dfs(nums, vector<bool>(n) = {}, 0);
    }
};