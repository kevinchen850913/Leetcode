//���i�����ۧ@�~
//�޿����
//1.�ΤG���k�����q������
//2.���յ��׬O�_���T
//3.���T�N�q��p���ơA���~�N�Ϥ�
//4.�q��̤p�����T���׵���
//�ɶ� N^2 �A���׾a�q�A�o�D�@�I��������

public class Solution
{
    public int SplitArray(int[] nums, int m)
    {
        long low = 0;
        long high = 0; // long to avoid overflow
        foreach (var num in nums)
        {
            low = Math.Max(low, num);
            high += num;
        }
        while (low < high)
        {
            long mid = low + (high - low) / 2;

            if (Valid(nums, m, mid))
                high = mid;
            else
                low = mid + 1;
        }
        return (int)low;
    }

    private bool Valid(int[] nums, int m, long sizeConstraint)
    {
        var count = 1;
        long currentBucketSize = 0;
        foreach (var num in nums)
        {
            if (currentBucketSize + num <= sizeConstraint)
                currentBucketSize += num;
            else
            {
                count += 1;
                currentBucketSize = num;
            }
        }
        return count <= m;
    }
}