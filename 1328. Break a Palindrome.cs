public class Solution
{
    public string BreakPalindrome(string palindrome)
    {
        string str = "";
        int i;
        bool b = false;
        if (palindrome.Length < 2)
        {
            return str;
        }
        for (i = 0; i < palindrome.Length / 2; i++)
        {
            if (palindrome[i] != 'a')
            {
                str += 'a';
                b = true;
                i++;
                break;
            }
            else
            {
                str += palindrome[i];
            }
        }
        while (i < palindrome.Length - 1)
        {
            str += palindrome[i++];
        }
        str += b ? palindrome[palindrome.Length - 1] : 'b';
        return str;
    }
}