public class Solution
{
    public string SimplifyPath(string path)
    {
        string str = "";
        string[] words = path.Split('/');
        Stack<string> stk = new Stack<string>();
        foreach (var word in words)
        {
            switch (word)
            {
                case ".":
                case "":
                    break;
                case "..":
                    if (stk.Count > 0)
                    {
                        stk.Pop();
                    }
                    break;
                default:
                    stk.Push(word);
                    break;
            }
        }
        while (stk.Count > 0)
            str = "/" + stk.Pop() + str;
        return str == "" ? "/" : str;
    }
}