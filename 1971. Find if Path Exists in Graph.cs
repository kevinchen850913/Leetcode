public class Solution
{
    public int[] set = null;

    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        set = new int[n];

        for (int i = 0; i < n; i++)
        {
            set[i] = i;
        }

        foreach (var e in edges)
        {
            Union(e[0], e[1]);
        }

        return Find(source) == Find(destination);
    }

    private void Union(int x, int y)
    {
        int px = Find(x),
            py = Find(y);

        if (px != py)
        {
            set[px] = py;
        }
    }

    private int Find(int x)
    {
        if (set[x] != x)
        {
            set[x] = Find(set[x]);
        }

        return set[x];
    }
}