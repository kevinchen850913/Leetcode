//這題根本沒有Hard的難度
class Solution {
public:
    int maxSatisfaction(vector<int>& satisfaction) {
        int max = 0, dt = 0;
        sort(satisfaction.begin(), satisfaction.end());
        for (int i = satisfaction.size() - 1; i >= 0; --i)
        {
            dt += satisfaction[i];
            if (dt < 0)
                return max;
            max += dt;
        }
        return max;
    }
};