public class Solution
{
    public string LargestMultipleOfThree(int[] digits)
    {
        int[] nums = new int[3];
        string str = "";
        foreach (int num in digits)
            nums[num % 3]++;
        if (nums[0] == 0 && nums[1] < 3 && nums[2] < 3 && (nums[1] == 0 || nums[2] == 0))
            return "";
        switch ((nums[1] - nums[2]) % 3)
        {
            case 2:
                if (nums[2] > 0)
                    nums[2] -= 1;
                else
                    nums[1] -= 2;
                break;
            case 1:
                nums[1] -= 1;
                break;
            case -1:
                nums[2] -= 1;
                break;
            case -2:
                if (nums[1] > 0)
                    nums[1] -= 1;
                else
                    nums[2] -= 2;
                break;
        }
        Array.Sort(digits);
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (nums[digits[i] % 3] > 0)
            {
                if (str == "0")
                    str = "";
                str += digits[i].ToString();
                nums[digits[i] % 3]--;
            }
        }
        return str;
    }
}