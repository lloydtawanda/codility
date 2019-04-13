<Query Kind="Program" />

void Main()
{
	BinaryGap(1).Dump();
	BinaryGap(2).Dump();
	BinaryGap(3).Dump();
	BinaryGap(4).Dump();
	BinaryGap(5).Dump();
}


string Binary(int value)
{
	var d = value;
	var r = 0;
	var number = "";
	while(d > 0)
	{
		r = d % 2;
		d = d / 2;

		number = r + number;
	}
	return number;
}

int BinaryGap(int value)
{
	var d = value;
	var r = 0;
	var number = "";
	var temp = 0;
	var bg = 0;
	var index = 0;
	
	while (d > 0)
	{

		r = d % 2;
		d = d / 2;
		
		if(r == 1) // start/close
		{
			if(temp < bg)
				temp = bg;
			bg = 0;
		}
		else
		{
			bg++;
		}
		
		number += r;
		index++;
	}
	return temp;
}



// Define other methods and classes here