public class Solution
{
    public long MinimumMoney(int[][] transactions)
    {
        long n = 0;
        long m = 0;
        for (int i = 0; i < transactions.Length; i++)
        {
            if (transactions[i][0] > transactions[i][1])
            {
                n += transactions[i][0] - transactions[i][1];
                if (transactions[i][1] > m)
                {
                    m = transactions[i][1];
                }
            }
            else
            {
                if (transactions[i][0] > m)
                {
                    m = transactions[i][0];
                }
            }
        }
        return n + m;
    }
}