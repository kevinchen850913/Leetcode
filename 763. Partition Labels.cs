//�ݨ��D�ت����ϥΫ���+�ʺA�W���B�z
//int[26]�����p�g�^��
//int[s.Length]�����s�򪬺A
//�Ҧp:a-b-a-b-c-b-a-c-a d-e
//�Ѧ��P�_�O�_�ݳs��
//�ɶ������� N+N+N �� 60% 
//�U�责�ѧ�n���ѵ�

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

//�o�O���ͤ@�ӤQ���맮������
//���@�U�A���@��H���ά۳q���Ĳv���Ϊ��ѵ�
//�æ��ާ@�~�A������ <= �Ĳv�� <= �ۤv�@��
//�䤤�������I�O�A�즸���������}�Y
//LastIndexOf�@�d�N�i��������
//�ɶ������� N+N �� 90% 
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

//�y�L�ק�[�Wused�קK���ƧP�_
//�ɶ������� N+N �� 98% 
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