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

//Подсчёт суммы элементов на нечётных позициях в целочисленном массиве
int sum_odd_pos_in_int_arr(int[] array)
{
	int sum = 0;

	for (int index = 0; index < array.Length; index++)
	{
		sum += (index % 2 != 0) ? array[index] : 0;
	}

	return sum;
}

int array_size = ask_for_int_number("Enter array size: ");

int[] array = generate_int_array(-100, 100, array_size);

int sum_odd_pos = sum_odd_pos_in_int_arr(array);

string array_for_output = String.Join(", ", array);

Console.WriteLine($"[{array_for_output}] ---> {sum_odd_pos}");

