<Query Kind="Program" />

void Main()
{
	BinaryGap(20).Dump();
}


int BinaryGap(int number)
{
	var binary = Convert.ToString(number, 2);
	var temp = 0; 
	var bigGap = 0;
	for(var i = 0; i <= binary.Length - 1; i++)
	{
		if (binary[i] == '0')
		{
			bigGap += 1;
		}
		else
		{
			if(bigGap > temp)
			{
				bigGap = 0;
			}
			else
			{
				temp = bigGap;  // Save biggest
			}
		}
	}
	return temp;
}
// Define other methods and classes here
