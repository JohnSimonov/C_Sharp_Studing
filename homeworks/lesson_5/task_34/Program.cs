// Запрос целого числа у пользователя из консоли
int ask_for_int_number(string message)
{
	Console.Write(message);
	int number = int.Parse(Console.ReadLine());
	return number;
}

// Генерация целочисленного массива 
int[] generate_int_array(int min_val, int max_val, int size)
{
	int[] array = new int[size];
	for (int index = 0; index < size; index++)
	{
		array[index] = new Random().Next(min_val, max_val + 1);
	}
	return array;
}

//Подсчёт количества чётных чисел в целочисленном массиве
int pos_count_in_int_arr(int[] array)
{
	int count = 0;

	foreach (int el in array)
	{
		count += (el % 2 == 0) ? 1 : 0;
	}

	return count;
}

int array_size = ask_for_int_number("Enter array size: ");

int[] array = generate_int_array(100, 999, array_size);

int pos_count = pos_count_in_int_arr(array);

string array_for_output = String.Join(", ", array);

Console.WriteLine($"[{array_for_output}] ---> {pos_count}");
