//�ܦh�H����LINQ�ƧǡA�ڤ]�n�Ʋߤ@�U�}��
public class Solution {
public int TwoCitySchedCost(int[][] costs) 
{
	var n = costs.Length/2;
	var sorted = costs.OrderBy(x => x[1] - x[0]).ToList();
	int total = 0;
	for(int i = 0; i < n; i++)
	{
		total += (sorted[i][1] + sorted[n+i][0]);
	}
	return total;
}
}