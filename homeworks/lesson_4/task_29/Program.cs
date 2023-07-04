int ask_for_int_number(string message)
{
	Console.Write(message);
	int number = int.Parse(Console.ReadLine());
	return number;
}

int[] generate_int_array(int min_val, int max_val, int size)
{
	int[] array = new int[size];
	for (int index = 0; index < size; index++)
	{
		array[index] = new Random().Next(min_val, max_val + 1);
	}
	return array;
}

void print_int_array(int[] array)
{
	int size = array.Length;
	Console.Write("[ ");
	for (int index = 0; index < size; index++)
	{
		Console.Write($"{array[index]} ");

	}
	Console.Write("]");
	Console.WriteLine();
}

int array_size = ask_for_int_number("Enter array size: ");
int min_value = ask_for_int_number("Enter array min_value: ");
int max_value = ask_for_int_number("Enter array max_value: ");

int[] array = generate_int_array(min_value, max_value, array_size);

print_int_array(array);