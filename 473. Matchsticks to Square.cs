public class Solution
{
    int[] _matchsticks;
    int L;
    public bool Makesquare(int[] matchsticks)
    {
        _matchsticks = matchsticks;
        L = 0;
        foreach (var n in matchsticks)
        {
            L += n;
        }
        if (L % 4 != 0)
        {
            return false;
        }
        L /= 4;
        Array.Sort(_matchsticks);
        Array.Reverse(_matchsticks);
        return F(0, 0, 0, 0, 0);
    }

    public bool F(int a, int b, int c, int d, int i)
    {
        if (i > _matchsticks.Length || a > L || b > L || c > L || d > L)
        {
            return false;
        }
        if (i == _matchsticks.Length && a == L && b == L && c == L && d == L)
        {
            return true;
        }
        if (_matchsticks[i] > L)
        {
            return false;
        }
        if (F(a + _matchsticks[i], b, c, d, i + 1))
        {
            return true;
        }
        if (F(a, b + _matchsticks[i], c, d, i + 1))
        {
            return true;
        }
        if (F(a, b, c + _matchsticks[i], d, i + 1))
        {
            return true;
        }
        if (F(a, b, c, d + _matchsticks[i], i + 1))
        {
            return true;
        }
        return false;
    }
}