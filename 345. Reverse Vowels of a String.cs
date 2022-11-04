public class Solution
{
	public string ReverseVowels(string s)
	{
		char[] ch = s.ToCharArray();
		int i = 0, j = s.Length - 1;
		char[] vowels = "aeiouAEIOU".ToCharArray();
		while (i < j)
		{
			while (i <= j && !vowels.Contains(ch[i]))
				++i;
			while (j >= i && !vowels.Contains(ch[j]))
				--j;

			if (i < j)
				(ch[i], ch[j]) = (ch[j], ch[i]);
			++i;
			--j;
		}
		return new string(ch);
	}
}