class Solution {
public:
    string mergeAlternately(string word1, string word2) {
        int i1 = 0;
        int i2 = 0;
        int l1 = word1.size();
        int l2 = word2.size();
        string str = string(l1 + l2, ' ');
        while (i1 < l1 && i2 < l2)
        {
            if (i1 == i2)
            {
                str[i1 + i2] = word1[i1];
                ++i1;
            }
            else
            {
                str[i1 + i2] = word2[i2];
                ++i2;
            }
        }
        while (i1 < l1)
        {
            str[i1 + i2] = word1[i1];
            ++i1;
        }
        while (i2 < l2)
        {
            str[i1 + i2] = word2[i2];
            ++i2;
        }
        return str;
    }
};