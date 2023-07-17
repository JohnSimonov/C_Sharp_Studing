// Запрос целого числа у пользователя из консоли
int ask_for_int_number(string message)
{
	Console.Write(message);
	int number = int.Parse(Console.ReadLine());
	return number;
}

// Генерация матрицы натуральных чисел с указанными размерами
int[,] generate_natural_matrix(int rows_number, int columns_number)
{
	int[,] int_matrix = new int[rows_number, columns_number];
	Random random_generator = new Random();
	for (int i = 0; i < rows_number; i++ )
	{
		for (int j = 0; j < columns_number; j++ )
		{	
			int random_int = random_generator.Next(1, 10);
			int_matrix[i, j] = random_int;
		}
	}
	return int_matrix;
}

// Вывод матрицы
void print_int_matrix(int[,] matrix)
{
	int rows_number = matrix.GetLength(0);
	int columns_number = matrix.GetLength(1);

	for (int i = 0; i < rows_number; i++)
	{
		Console.Write("[ ");
		for (int j = 0; j < columns_number; j++)
		{
			Console.Write($"{matrix[i, j]} ");

		}
		Console.Write("]");
		Console.WriteLine();	
	}
	
}

// Метод возвращает номер строки целочисленной матрицы с наименьшей суммой элементов
int min_sum_int_matrix_row_number(int[,] input_matrix)
{
	int rows_number = input_matrix.GetLength(0);
	int min_sum_row_number = 0;
	int min_sum = sum_int_matrix_row(input_matrix, 0);

	for (int i = 1; i < rows_number; i++ )
	{
		int current_row_sum = sum_int_matrix_row(input_matrix, i);

		if (current_row_sum < min_sum)
		{
			min_sum = current_row_sum;
			min_sum_row_number = i;
		}
		
	}
	return min_sum_row_number;
}

// вычисление суммы элементов указанной строки целочисленной матрицы 
int sum_int_matrix_row(int[,] input_matrix, int row_number)
{
	int columns_number = input_matrix.GetLength(1);
	int sum = 0;
	
	for (int j = 0; j < columns_number ; j++ )
	{	
		sum += input_matrix[row_number, j];
		
	}

	return sum;
}

Console.WriteLine("For matrix generation:");
int rows_number = ask_for_int_number("Enter rows number: ");
int columns_number = ask_for_int_number("Enter columns number: ");
int[,] generated_matrix = generate_natural_matrix(rows_number, columns_number);

Console.WriteLine();
Console.WriteLine("Generated matrix:");
print_int_matrix(generated_matrix);

Console.WriteLine();
Console.WriteLine($"matrix min sum row number: {min_sum_int_matrix_row_number(generated_matrix) + 1}");


