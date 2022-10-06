//�p�G�@�뱡�p�ڷ|�o��g�A������קﳣ�e��
using System.Linq;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        string[] words = s.TrimEnd().Split(' ');
        return words[words.Length - 1].Length;
    }
}

//�n�ܦ��@��ݭn�ϥ�LinQ
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        return s.Trim().Split().LastOrDefault().Length;
    }
}

//�άO���u�A���O�ɶ������˸m
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        return s.TrimEnd().Length - s.TrimEnd().LastIndexOf(' ') - 1;
    }
}

//���t��誩
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

//�̲�������
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        return string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s) ? 0 : (int)s.Split(' ')?.Where(x => x.Length > 0)?.Last().Length;
    }
}