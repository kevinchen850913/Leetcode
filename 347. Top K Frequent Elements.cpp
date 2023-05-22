class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        vector<int> Vec1(k + 1, 0);
        vector<int> Vec2(k + 1, 0);
        unordered_map<int, int> Map;
        for (auto i : nums)
        {
            if (Map.find(i) == Map.end())
                Map[i] = 0;
            Map[i] += 1;
        }
        for (auto d : Map)
        {
            for (int i = k - 1; i >= 0; i--)
            {
                if (d.second > Vec2[i])
                {
                    Vec1[i + 1] = Vec1[i];
                    Vec2[i + 1] = Vec2[i];
                    Vec1[i] = d.first;
                    Vec2[i] = d.second;
                }
            }
        }
        Vec1.pop_back();
        return Vec1;
    }
};