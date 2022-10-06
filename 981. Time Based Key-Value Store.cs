//這是抄作業的答案，重點是SortedList會自排序，之前都沒用過。
using System.Collections.Generic;

public class TimeMap
{
	Dictionary<string, SortedList<int, string>> map;

	/** Initialize your data structure here. */
	public TimeMap()
	{
		map = new Dictionary<string, SortedList<int, string>>();
	}

	public void Set(string key, string value, int timestamp)
	{
		if (!map.ContainsKey(key))
			map.Add(key, new SortedList<int, string>());

		SortedList<int, string> temp = map[key];
		temp.Add(timestamp, value);
	}

	public string Get(string key, int timestamp)
	{
		if (!map.ContainsKey(key))
			return string.Empty;

		IList<int> temp = map[key].Keys;

		int left = 0;
		int right = temp.Count - 1;
		while (left < right)
		{
			int mid = (left + right + 1) / 2;
			if (temp[mid] == timestamp)
				return map[key].Values[mid];

			if (temp[mid] < timestamp)
				left = mid;
			else
				right = mid - 1;
		}
		if (left == 0 && map[key].Keys[0] > timestamp)
			return string.Empty;
		return map[key].Values[left];
	}
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */

//其實我也不是不會，就懶只用些簡單作法，不想處理鍊狀插入及二分搜尋法，所以就Time Limit Exceeded。
public class TimeMap
{
	Dictionary<string, Dictionary<int, string>> MyDic;

	public TimeMap()
	{
		MyDic = new Dictionary<string, Dictionary<int, string>>();
	}

	public void Set(string key, string value, int timestamp)
	{
		if (!MyDic.ContainsKey(key))
		{
			MyDic.Add(key, new Dictionary<int, string>());
		}
		MyDic[key].Add(timestamp, value);
		return;
	}

	public string Get(string key, int timestamp)
	{
		string rt = "";
		foreach (var OneItem in MyDic[key])
		{
			if (OneItem.Key > timestamp)
			{
				break;
			}
			rt = OneItem.Value;
		}
		return rt;
	}
}