using System.Collections;

public class Solution
{
    public string GetHint(string secret, string guess)
    {
        Hashtable hs = new Hashtable();
        int A = 0;
        int B = 0;
        for (int i = 0; i < secret.Length; i++)
        {
            if (!hs.ContainsKey(secret[i]))
            {
                hs.Add(secret[i], 0);
            }
            hs[secret[i]] = (int)hs[secret[i]] + 1;
            if (secret[i] == guess[i])
            {
                A++;
            }
        }
        for (int i = 0; i < secret.Length; i++)
        {
            if (hs.ContainsKey(guess[i]) && (int)hs[guess[i]] > 0)
            {
                B++;
                hs[guess[i]] = (int)hs[guess[i]] - 1;
            }
        }
        return A + "A" + (B - A) + "B";
    }
}