//一開始直觀想到的答案，是錯誤的。
//邏輯是湊出 aaa...xzzz...
// k = a*i + z*j + x
// n = i + j +1
//問題是乘法會有溢位問題
//而且根本不需要那麼麻煩

public class Solution
{
    public string GetSmallestString(int n, int k)
    {
        string str = "";
        for (int i = n; i >= 0; i--)
        {
            if (k == -1)
            {
                str += 'z';
            }
            else if (i * 26 >= k)
            {
                str += 'a';
                k--;
            }
            else
            {
                k = k % 26;
                k += 96;
                str += (char)k;
                k = -1;
            }
        }
        return str;
    }
}

//生成所有為a的字串，將k減少n
//k為正時將右邊的 'a'變成 'z'（'a' + 25，或 'a' + k）
string getSmallestString(int n, int k)
{
    string res = string(n, 'a');
    k -= n;
    while (k > 0)
    {
        res[--n] += min(25, k);
        k -= min(25, k);
    }
    return res;
}