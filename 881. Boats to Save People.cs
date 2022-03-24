//�o�D�N�ƧǡA�M���ˬd�Y���i��p��
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
