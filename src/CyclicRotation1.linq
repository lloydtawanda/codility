<Query Kind="Program" />

void Main()
{
	var a = new int[]{ 1, 2, 3, 4}; 
	new Solution().solution(a, 1).Dump();
}

class Solution 
{ 
	public int[] solution(int[] A, int K){
		if (K < 0 || K > 100) 
			return A;
	
		if(A.Length == 0)
			return A;
		
		var R = new int[A.Length];
		var s = K % A.Length;

		for(var i = 0; i < A.Length - s; ++i)
		{
			R[i + s] = A[i];
		}

		for (var i = 0; i < s; ++i)
		{
			R[i] = A[A.Length - K + i];
		}
		return R;
	} 
}

// Define other methods and class

