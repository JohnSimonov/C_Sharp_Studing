// Запрос целого числа у пользователя из консоли
int ask_for_int_number(string message)
{
	Console.Write(message);
	int number = int.Parse(Console.ReadLine());
	return number;
}

// Генерация вещественного массива 
double[] generate_double_array(int size)
{
	double[] array = new double[size];
	for (int index = 0; index < size; index++)
	{
		array[index] = new Random().Next(1, 10001) / 100.0;
	}
	return array;
}

//Подсчёт  максимума  в вещественном массиве
double max_in_double_arr(double[] array)
{
	double max = array[0];

	for (int index = 0; index < array.Length; index++)
	{
		if (array[index] > max) max = array[index] ;
	}

	return max;
}

//Подсчёт минимума в вещественном массиве
double min_in_double_arr(double[] array)
{
	double min = array[0];

	for (int index = 0; index < array.Length; index++)
	{
		if (array[index] < min) min = array[index] ;
	}

	return min;
}


int array_size = ask_for_int_number("Enter array size: ");

double[] array = generate_double_array(array_size);

double maxmin_difference = max_in_double_arr(array) - min_in_double_arr(array) ;

string array_for_output = String.Join(", ", array);

Console.WriteLine($"[{array_for_output}] ---> {maxmin_difference}");

