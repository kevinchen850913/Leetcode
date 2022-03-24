//這題就排序，然後檢查頭尾進行計數
class Solution {
public:
    int numRescueBoats(vector<int>& people, int limit)
    {
        sort(people.begin(), people.end());
        int i = 0;
        int j = people.size() - 1;
        int count = 0;

        while (i <= j)
        {
            if (people[i] + people[j] <= limit)
                i++;
            j--;
            count++;
        }
        return count;
    }
};