//如果一般情況我會這麼寫，除錯跟修改都容易
using System.Linq;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        string[] words = s.TrimEnd().Split(' ');
        return words[words.Length - 1].Length;
    }
}

//要變成一行需要使用LinQ
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        return s.Trim().Split().LastOrDefault().Length;
    }
}

//或是重工，浪費時間本末倒置
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        return s.TrimEnd().Length - s.TrimEnd().LastIndexOf(' ') - 1;
    }
}

//高速手刻版
public int LengthOfLastWord2(string s)
{
    var count = 0;
    for (var i = s.Length - 1; i >= 0; i--)
    {
        if (count == 0 && s[i] == ' ') continue;
        else if (s[i] == ' ') break;
        else { count++; }
    }
    return count;
}

//最甜的那種
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        return string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s) ? 0 : (int)s.Split(' ')?.Where(x => x.Length > 0)?.Last().Length;
    }
}