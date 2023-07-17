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

// сортировка строк целочисленной матрицы в убывающем порядке
int[,] sort_matrix_rows_descending(int[,] input_matrix)
{
	int rows_number = input_matrix.GetLength(0);
	int columns_number = input_matrix.GetLength(1);
	int[,] result_matrix = input_matrix;

	for (int i = 0; i < rows_number; i++ )
	{
		result_matrix = sort_matrix_row_descending(result_matrix, i);
		
	}
	return result_matrix;
}

// сортировка указанной строки целочисленной матрицы в убывающем порядке
int[,] sort_matrix_row_descending(int[,] input_matrix, int row_number)
{
	int columns_number = input_matrix.GetLength(1);
	int[,] result_matrix = input_matrix;
	int max;
	int max_position;
	
	for (int j = 0; j < columns_number - 1; j++ )
	{	
		max = result_matrix[row_number, j];
		max_position = j;

		for (int k = j + 1; k < columns_number; k++)
		{
			if (result_matrix[row_number, k] > max) 
			{
				max = result_matrix[row_number, k];
				max_position = k;
			}
			
		}
		result_matrix[row_number, max_position] = result_matrix[row_number, j];
		result_matrix[row_number, j] = max;
	}

	return result_matrix;
}

Console.WriteLine("For matrix generation:");
int rows_number = ask_for_int_number("Enter rows number: ");
int columns_number = ask_for_int_number("Enter columns number: ");
int[,] generated_matrix = generate_natural_matrix(rows_number, columns_number);

Console.WriteLine();
Console.WriteLine("Generated matrix:");
print_int_matrix(generated_matrix);

Console.WriteLine();
Console.WriteLine("Sorted matrix:");
print_int_matrix(sort_matrix_rows_descending(generated_matrix));

