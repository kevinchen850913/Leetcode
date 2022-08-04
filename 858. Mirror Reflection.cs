public class Solution
{
    public int MirrorReflection(int p, int q)
    {
        int i = q;
        bool top = false;
        bool left = false;
        if (p == q)
            return 1;
        if (q == 0)
            return 0;
        while (i != 0)
        {
            left = !left;
            i += q;
            if (i >= p)
            {
                i %= p;
                top = !top;
            }
        }
        if (left)
            return 2;
        else
            return top ? 1 : 0;
    }
}