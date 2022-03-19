//�ثe�ڹJ��ƦX�����c���D�س��|���I�d���A�L�k���W�ѥX�C
//�o�D���޿�O�ݭn��Ӹ�ƪ�A
//�@�ӬO�����ӼƦr�X�{������
//�t�@�ӬO�U���W�v�U�����ǼƦr
//��Ƶ��c���T�A�o�D�N�i�H�ѥX�ӤF�C


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