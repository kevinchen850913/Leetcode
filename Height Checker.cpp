class Solution {
public:
    int heightChecker(vector<int>& heights) {
        vector<int> heights2;
        heights2.assign(heights.begin(), heights.end());
        bool b = true;
        int rt = 0;
        while (b)
        {
            b = false;
            for (int i = 0; i < heights2.size() - 1; i++)
            {
                int temp;
                if (heights2[i] > heights2[i + 1])
                {
                    b = true;
                    temp = heights2[i];
                    heights2[i] = heights2[i + 1];
                    heights2[i + 1] = temp;
                }
            }
        }
        for (int i = 0; i < heights.size(); i++)
        {
            if (heights[i] != heights2[i])
            {
                rt++;
            }
        }
        return rt;
    }
};