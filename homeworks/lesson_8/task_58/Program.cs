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

// Метод возвращает результат перемножения двух матриц
int[,] int_matrixes_multiplication(int[,] first_matrix, int[,] second_matrix)
{
	int first_matrix_rows_number = first_matrix.GetLength(0);
	int second_matrix_columns_number = second_matrix.GetLength(1);

	int[,] result_matrix = new int[first_matrix_rows_number, second_matrix_columns_number];

	for (int i = 0; i < first_matrix_rows_number; i++ )
	{
		for (int j = 0; j < second_matrix_columns_number; j++ )
		{
			result_matrix[i,j] = row_and_column_multiplication(first_matrix, second_matrix, i, j);
		}
	}
	return result_matrix;
}

// Метод возвращает сумму произведений элементов, стоящих на одинаковых позициях в указанной строке
// первой матрицы и указанном столбце второй матрицы
int row_and_column_multiplication(int[,] first_matrix, int[,] second_matrix, int row_number, int column_number)
{
	int first_matrix_columns_number = first_matrix.GetLength(1);
	int sum = 0;

	for (int k = 0; k < first_matrix_columns_number; k++)
	{
		sum += first_matrix[row_number, k] * second_matrix[k, column_number];
	}

	return sum;
}



Console.WriteLine("For first matrix generation:");
int rows_number = ask_for_int_number("Enter rows number: ");
int columns_number = ask_for_int_number("Enter columns number: ");
int[,] first_generated_matrix = generate_natural_matrix(rows_number, columns_number);
Console.WriteLine();

Console.WriteLine("For second matrix generation:");
rows_number = ask_for_int_number("Enter rows number: ");
columns_number = ask_for_int_number("Enter columns number: ");
int[,] second_generated_matrix = generate_natural_matrix(rows_number, columns_number);

Console.WriteLine();
Console.WriteLine("First generated matrix:");
print_int_matrix(first_generated_matrix);

Console.WriteLine();
Console.WriteLine("Second generated matrix:");
print_int_matrix(second_generated_matrix);

Console.WriteLine();
print_int_matrix(int_matrixes_multiplication(first_generated_matrix, second_generated_matrix));


