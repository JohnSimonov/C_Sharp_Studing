// Запрос целого числа у пользователя из консоли
int ask_for_int_number(string message)
{
	Console.Write(message);
	int number = int.Parse(Console.ReadLine());
	return number;
}

// Генерация трёхмерного массива двухзначных натуральных чисел 
int[,,] generate_natural_volume_array(int rows_number, int columns_number, int tables_count)
{
	int[,,] int_volume_array = new int[rows_number, columns_number, tables_count];
	Random random_generator = new Random();
	for (int i = 0; i < rows_number; i++ )
	{
		for (int j = 0; j < columns_number; j++ )
		{	
			for (int k = 0; k < tables_count; k++)
			{
				int random_int = random_generator.Next(10, 99);
				int_volume_array[i, j, k] = random_int;
			}
		}
	}
	return int_volume_array;
}

// Вывод трёхмерного массива
// void print_int_volume_array(int[,,] volume_array)
// {
// 	int rows_number = volume_array.GetLength(0);
// 	int columns_number = volume_array.GetLength(1);
// 	int tables_count = volume_array.GetLength(2);

// 	for (int i = 0; i < rows_number; i++)
// 	{
// 		Console.Write("[ ");
// 		for (int j = 0; j < columns_number; j++)
// 		{	
// 			Console.Write(" [ ");

// 			for (int k = 0; k < tables_count; k++)
// 			{	
// 				Console.Write($"{volume_array[i, j, k]} ");
// 			}

// 			Console.Write("] ");

// 		}
// 		Console.Write("] ");
// 		Console.WriteLine();	
// 	}
	
// }

// Вывод трёхмерного массива
void print_int_volume_array(int[,,] volume_array)
{
	int rows_number = volume_array.GetLength(0);
	int columns_number = volume_array.GetLength(1);
	int tables_count = volume_array.GetLength(2);

	for (int i = 0; i < rows_number; i++)
	{
		for (int j = 0; j < columns_number; j++)
		{	

			for (int k = 0; k < tables_count; k++)
			{	
				Console.Write($"{volume_array[i, j, k]}({i},{j},{k}) ");
			}
			Console.WriteLine();


		}	
	}
	
}





Console.WriteLine("For volume_array generation:");
int rows_number = ask_for_int_number("Enter rows number: ");
int columns_number = ask_for_int_number("Enter columns number: ");
int tables_number = ask_for_int_number("Enter tables number: ");
int[,,] generated_volume_array = generate_natural_volume_array(rows_number, columns_number, tables_number);
Console.WriteLine();


Console.WriteLine();
Console.WriteLine("Generated volume_array:");
print_int_volume_array(generated_volume_array);



// Console.WriteLine();
// print_int_matrix(int_matrixes_multiplication(first_generated_matrix, second_generated_matrix));


