//�o�ӵ��׷|�W�ɡA���L�ڨ��ı�o�S���D�C
public class Solution
{
    public string ReverseWords(string s)
    {
        string[] words = s.Split(' ');
        string S = "";
        foreach (string str in words)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                S += str[i];
            }
            S += " ";
        }
        return S.TrimEnd(' ');
    }
}

//�o�ӵ��פ]�O���C�A�Pı���ն��ئ��I���D�C
public class Solution
{
    public string ReverseWords(string s) =>
    string.Join(' ', s.Split(' ').Select(t => string.Concat(t.Reverse())));
}