//感覺這個答案不是我寫的，不過看起來也沒得優化。
public class Solution
{
    public string CountAndSay(int n)
    {
        if (n == 1)
            return "1";

        var cas = CountAndSay(n - 1);
        var count = 0;
        var sb = new StringBuilder();
        for (var i = 0; i < cas.Length; i++)
        {
            if (i + 1 < cas.Length && cas[i] == cas[i + 1])
            {
                count++;
                continue;
            }

            sb.Append($"{count + 1}{cas[i]}");
            count = 0;
        }
        return sb.ToString();
    }
}