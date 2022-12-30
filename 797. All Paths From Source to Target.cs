using System.Collections.Generic;

public class Solution
{
    IList<IList<int>> rt;
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        rt = new List<IList<int>>();
        F(graph, new List<int>(), 0);
        return rt;
    }

    void F(int[][] graph, IList<int> L, int n)
    {
        L.Add(n);
        if (n == graph.Length - 1)
        {
            rt.Add(L);
            return;
        }
        for (int i = 0; i < graph[n].Length; i++)
        {
            F(graph, L.ToList(), graph[n][i]);
        }
        return;
    }
}