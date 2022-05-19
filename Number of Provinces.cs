public class Solution
{
    int[][] _isConnected;
    List<int> nums;
    public int FindCircleNum(int[][] isConnected)
    {
        _isConnected = isConnected;
        List<List<int>> ret = new List<List<int>>();
        bool b = false;
        for (int i = 0; i < _isConnected.Length; i++)
        {
            b = false;
            for (int j = 0; j < ret.Count; j++)
            {
                if (ret[j][i] == 1)
                {
                    b = true;
                    break;
                }
            }
            if (!b)
            {
                nums = new List<int>();
                for (int j = 0; j < _isConnected.Length; j++)
                {
                    nums.Add(0);
                }
                A(i);
                ret.Add(nums);
            }
        }
        return ret.Count;
    }
    public void A(int i)
    {
        for (int j = 0; j < _isConnected.Length; j++)
        {
            if (_isConnected[i][j] == 1 && nums[j] != 1)
            {
                nums[j] = 1;
                A(j);
            }
        }
        return;
    }
}