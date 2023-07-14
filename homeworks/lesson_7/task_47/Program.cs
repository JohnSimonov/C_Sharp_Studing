// Запрос целого числа у пользователя из консоли
int ask_for_int_number(string message)
{
	Console.Write(message);
	int number = int.Parse(Console.ReadLine());
	return number;
}

// Генерация матрицы с указанными размерами
double[,] generate_double_matrix(int rows_number, int columns_number)
{
	double[,] double_matrix = new double[rows_number, columns_number];
	Random random_generator = new Random();
	for (int i = 0; i < rows_number; i++ )
	{
		for (int j = 0; j < columns_number; j++ )
		{	
			int random_int = random_generator.Next(-10, 10);
			double random_double = random_generator.NextDouble() * random_int;
			double_matrix[i, j] = Math.Round(random_double, 1, MidpointRounding.AwayFromZero);
		}
	}
	return double_matrix;
}

// Вывод матрицы
void print_double_matrix(double[,] matrix)
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

int rows_number = ask_for_int_number("Enter rows number: ");
int columns_number = ask_for_int_number("Enter columns number: ");
print_double_matrix(generate_double_matrix(rows_number, columns_number));
