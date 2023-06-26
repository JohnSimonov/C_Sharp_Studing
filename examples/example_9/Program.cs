void FillArray(int[] array)
{
	int length = array.Length;
	int index = 0;
	while (index < length)
	{

		array[index] = new Random().Next(1, 101);
		index++;
	}
}

void PrintArray(int[] array)
{
	int length = array.Length;
	int index = 0;
	while (index < length)
	{

		Console.Write($"{array[index]} ");
		index++;
	}
	Console.WriteLine();
}

int IndexOf(int[] array, int el_value)
{
	int length = array.Length;
	int index = 0;
	int position = -1;
	while (index < length)
	{

		if (array[index] == el_value) 
		{
			position = index;
		}
		index++;
	}
	return position;	
}





int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();

int val = array[6];

Console.WriteLine(IndexOf(array, val));
