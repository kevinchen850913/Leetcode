//�@�}�l���[�Q�쪺���סA�O���~���C
//�޿�O��X aaa...xzzz...
// k = a*i + z*j + x
// n = i + j +1
//���D�O���k�|��������D
//�ӥB�ڥ����ݭn����·�

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

//�ͦ��Ҧ���a���r��A�Nk���n
//k�����ɱN�k�䪺 'a'�ܦ� 'z'�]'a' + 25�A�� 'a' + k�^
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