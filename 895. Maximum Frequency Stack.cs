//目前我遇到複合式結構的題目都會有點卡關，無法馬上解出。
//這題的邏輯是需要兩個資料表，
//一個是紀錄該數字出現的次數
//另一個是各種頻率下有那些數字
//資料結構正確，這題就可以解出來了。


public class FreqStack
{
    private readonly Dictionary<int, int> freqs;
    private readonly Dictionary<int, Stack<int>> dict;
    private readonly Stack<int> peeks;

    public FreqStack()
    {
        freqs = new Dictionary<int, int>();
        dict = new Dictionary<int, Stack<int>>();
        peeks = new Stack<int>();
    }

    public void Push(int x)
    {
        if (freqs.ContainsKey(x))
        {
            freqs[x]++;
        }
        else
        {
            freqs.Add(x, 1);
        }

        var freq = freqs[x];

        if (dict.ContainsKey(freq))
        {
            dict[freq].Push(x);
        }
        else
        {
            var stack = new Stack<int>();
            stack.Push(x);
            dict.Add(freq, stack);
            peeks.Push(freq);
        }
    }

    public int Pop()
    {
        var key = peeks.Peek();
        var stack = dict[key];
        var val = stack.Pop();

        if (stack.Count == 0)
        {
            dict.Remove(key);
            peeks.Pop();
        }

        freqs[val]--;

        return val;
    }
}