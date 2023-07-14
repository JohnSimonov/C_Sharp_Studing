// Запрос целого числа у пользователя из консоли
int ask_for_int_number(string message)
{
	Console.Write(message);
	int number = int.Parse(Console.ReadLine());
	return number;
}

// Генерация матрицы с указанными размерами
int[,] generate_int_matrix(int rows_number, int columns_number)
{
	int[,] int_matrix = new int[rows_number, columns_number];
	Random random_generator = new Random();
	for (int i = 0; i < rows_number; i++ )
	{
		for (int j = 0; j < columns_number; j++ )
		{	
			int random_int = random_generator.Next(-10, 10);
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

// Метод подсчитывает среднее по каждому столбцу и возвращает массив средних значений,
// взятых по каждому столбцу
double[] int_matrix_mean_by_column(int[,] matrix)
{
	int rows_number = matrix.GetLength(0);
	int columns_number = matrix.GetLength(1);
	double[] means_array = new double[columns_number];

	double column_mean = 0;
	double columns_sum = 0;
	for (int j = 0; j < columns_number; j++)
	{
		columns_sum = 0;
		for (int i = 0; i < rows_number; i++)
		{
			columns_sum += matrix[i, j];

		}
		column_mean = columns_sum  / rows_number ;
		means_array[j] = column_mean;
	}

	return means_array;
}

Console.WriteLine("For matrix generation please:");
int rows_number = ask_for_int_number("Enter rows number: ");
int columns_number = ask_for_int_number("Enter columns number: ");

int[,] generated_matrix = generate_int_matrix(rows_number, columns_number);
Console.WriteLine();
Console.WriteLine("Generated matrix:");
print_int_matrix(generated_matrix);

for (int i = 0; i < columns_number; i++)
{
	Console.WriteLine($"{i + 1} column mean: {int_matrix_mean_by_column(generated_matrix)[i]}");
}



