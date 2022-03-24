//這題就排序，然後檢查頭尾進行計數
public class Solution
{
    public int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);
        int i = 0;
        int j = people.Length - 1;
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
}
