using System.Collections.Generic;

public class MyCalendarThree
{
    SortedList<int, int> SL;
    public MyCalendarThree()
    {
        SL = new SortedList<int, int>();
        return;
    }

    public int Book(int start, int end)
    {
        int n = 0;
        int max = 0;
        if (SL.ContainsKey(start))
        {
            SL[start]++;
        }
        else
        {
            SL.Add(start, 1);
        }
        if (SL.ContainsKey(end))
        {
            SL[end]--;
        }
        else
        {
            SL.Add(end, -1);
        }
        foreach (var o in SL)
        {
            n += o.Value;
            if (max < n)
            {
                max = n;
            }
        }
        return max;
    }
}

/**
 * Your MyCalendarThree object will be instantiated and called as such:
 * MyCalendarThree obj = new MyCalendarThree();
 * int param_1 = obj.Book(start,end);
 */