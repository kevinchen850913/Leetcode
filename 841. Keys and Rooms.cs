using System.Collections.Generic;

public class Solution
{
    int[] nums;
    IList<IList<int>> m_rooms;
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        m_rooms = rooms;
        nums = new int[rooms.Count()];
        F(0);
        foreach (int i in nums)
        {
            if (i == 0)
            {
                return false;
            }
        }
        return true;
    }

    void F(int n)
    {
        if (nums[n] == 0)
        {
            nums[n] = 1;
            foreach (int i in m_rooms[n])
            {
                F(i);
            }
        }
        return;
    }
}