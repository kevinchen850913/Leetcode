//����N�O�Ƨǫ����t���A
//�t�׵L�S�O�u�ơA�n�ִN�n�˱�ƧǡC

public class Solution
{
    public int FindUnsortedSubarray(int[] nums)
    {
        int a = -1, b = -1;
        int[] nums2 = (int[])nums.Clone();
        //�ɤWCopy���Ϊk�A��ؤ�k���i��
        //int[] nums2 = new int[nums.Length];
        //Array.Copy(nums,nums2,nums.Length);        
        Array.Sort(nums2);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums2[i] != nums[i])
            {
                a = i;
                break;
            }
        }
        if (a == -1)
        {
            return 0;
        }
        for (int i = nums.Length - 1; i > a; i--)
        {
            if (nums2[i] != nums[i])
            {
                b = i + 1;
                break;
            }
        }
        return b - a;
    }
}