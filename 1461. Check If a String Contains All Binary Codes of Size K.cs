public class Solution
{
    public bool HasAllCodes(string s, int k)
    {
        HashSet<string> visited = new HashSet<string>();
        int total = (int)Math.Pow(2, k);

        for (int i = 0; i < s.Length - k + 1; i++)
        {
            string subString = s.Substring(i, k);
            visited.Add(subString);
        }

        return visited.Count == total;
    }
}