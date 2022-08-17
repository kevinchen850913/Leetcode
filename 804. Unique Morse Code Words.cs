public class Solution
{
    public int UniqueMorseRepresentations(string[] words)
    {
        string[] MorseCode = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        Hashtable ht = new Hashtable();
        string str;
        foreach (string word in words)
        {
            str = "";
            foreach (char c in word)
            {
                str += MorseCode[c - 'a'];
            }
            if (!ht.ContainsKey(str))
            {
                ht.Add(str, 0);
            }
        }
        return ht.Count;
    }
}