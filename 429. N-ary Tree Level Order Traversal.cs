/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<IList<int>> LevelOrder(Node root) {
        IList<IList<int>>LL = new List<IList<int>>();
        IList<IList<Node>>Lchildren = new List<IList<Node>>();
        Queue<Node> q = new Queue<Node>();
        if (root != null)
        {
            q.Enqueue(root);
            LL.Add(new List<int>{ root.val });
        }
        while (q.Count > 0)
        {
            Lchildren = new List<IList<Node>>();
            while (q.Count > 0)
            {
                Node temp = q.Dequeue();
                IList<Node> children = temp.children;
                Lchildren.Add(children);
            }
            IList<int> L = new List<int>();
            foreach(IList<Node> children in Lchildren)
            {
                foreach(Node child in children)
                {
                    L.Add(child.val);
                    q.Enqueue(child);
                }
            }
            if (L.Count > 0)
            {
                LL.Add(L);
            }
        }
        return LL;
    }
}