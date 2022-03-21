//看到題目直接使用哈希+動態規劃處理
//int[26]紀錄小寫英文
//int[s.Length]紀錄連續狀態
//例如:a-b-a-b-c-b-a-c-a d-e
//由此判斷是否需連續
//時間複雜度 N+N+N 約 60% 
//下方提供更好的解答

public class Solution
{
    public IList<int> PartitionLabels(string s)
    {
        IList<int> l = new List<int>();
        int[] nums = new int[26];
        int[] nums2 = new int[s.Length];
        int n = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (nums[s[i] - 'a'] != 0 || s[i] == s[0])
            {
                for (int j = nums[s[i] - 'a']; j < i; j++)
                {
                    nums2[j] = 1;
                }
            }
            nums[s[i] - 'a'] = i;
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (nums2[i] == 0)
            {
                l.Add(++n);
                n = 0;
            }
            else
            {
                n++;
            }
        }
        return l;
    }
}

//這是網友一個十分精妙的答案
//抱怨一下，有一堆人都用相通但效率不佳的解答
//疑似操作業，有解釋 <= 效率解 <= 自己作答
//其中的關鍵點是，初次見面必為開頭
//LastIndexOf一查就可直接切割
//時間複雜度 N+N 約 90% 
public class Solution
{
    public IList<int> PartitionLabels(string S)
    {
        var result = new List<int>();

        int i = 0;
        int n = S.Length;
        while (i < n)
        {
            int lastIndex = S.LastIndexOf(S[i]);

            for (int j = i + 1; j < lastIndex; j++)
            {
                int tempIndex = S.LastIndexOf(S[j]);
                if (tempIndex > lastIndex)
                    lastIndex = tempIndex;
            }
            result.Add(lastIndex + 1 - i);
            i = lastIndex + 1;
        }

        return result;
    }
}

//稍微修改加上used避免重複判斷
//時間複雜度 N+N 約 98% 
public class Solution
{
    public IList<int> PartitionLabels(string S)
    {
        var result = new List<int>();
        int i = 0;
        int n = S.Length;
        bool[] used = new bool[26];
        while (i < n)
        {
            int lastIndex = S.LastIndexOf(S[i]);
            used[S[i] - 'a'] = true;
            for (int j = i + 1; j < lastIndex; j++)
            {
                if (!used[S[j] - 'a'])
                {
                    int tempIndex = S.LastIndexOf(S[j]);
                    used[S[j] - 'a'] = true;
                    if (tempIndex > lastIndex)
                        lastIndex = tempIndex;
                }
            }
            result.Add(lastIndex + 1 - i);
            i = lastIndex + 1;
        }
        return result;
    }
}