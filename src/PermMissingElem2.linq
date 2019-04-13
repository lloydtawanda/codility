<Query Kind="Program" />

void Main()
{
	var a = new int[] { 3, 5, 2, 1, 3, 7 };
	new Solution().solution(a).Dump();
}

// Define other methods and classes here
class Solution
{
	public int solution(int[] A)
	{
		if(A.Length == 1)
			return 1;
		var sum = 0;

		for (var i = 0; i < A.Length; i++)
		{
			sum = sum ^ A[i] ^ (i + 1);
		}
		return sum ^ (A.Length + 1);
	}
}