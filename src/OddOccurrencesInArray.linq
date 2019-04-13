<Query Kind="Program" />

void Main()
{
	var a = new int[] { 9, 3, 9, 3, 9, 7, 9 };
	new Solution().solution(a).Dump();
}

// Define other methods and classes here
class Solution
{
	public int solution(int[] A)
	{
		if (A.Length == 1)
			return A[0];

		if (A.Length % 2 == 0)
			return 0;

		QuickSort(A, 0, A.Length - 1);

		for(var i = 0; i < A.Length; i+=2)
		{
			if (i + 1 == A.Length)
             return A[i];

		    if (A[i] != A[i + 1])
	             return A[i];
		}
		return 0;
	}


	void QuickSort(int[] a, int start, int end)
	{
		if (start >= end)
		{
			return;
		}

		int num = a[start];

		int i = start - 1;
		int j = end + 1;

		while (true)
		{
			do
			{
				i++;
			} while (a[i] < num);

			do
			{
				j--;
			} while (a[j] > num);

			if (i >= j)
				break;

			Swap(a, i, j);
		}

		//a[i] = num;
		QuickSort(a, start, j);
		QuickSort(a, j + 1, end);
	}

	static void Swap(int[] a, int i, int j)
	{
		if (i == j)
			return;

		int temp = a[i];
		a[i] = a[j];
		a[j] = temp;
	}
}