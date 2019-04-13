<Query Kind="Program" />

void Main()
{
	new Solution().solution(10, 85, 30).Dump();
}

class Solution 
{ 
	public int solution(int X, int Y, int D)
	{
		var gap = Y - X;
		var p = gap / D;
		var r = gap % D;
		
		if(r > 0)
			return p + 1;
		else
			return p;
	}
}
// Define other methods and classes here
