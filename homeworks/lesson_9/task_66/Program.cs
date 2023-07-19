// Запрос целого числа у пользователя из консоли
int ask_for_int_number(string message)
{
	Console.Write(message);
	int number = int.Parse(Console.ReadLine());
	return number;
}

// Функция возвращает сумму натуральных чисел, входящих в отрезок [m, n]

int int_numbers_in_range_sum(int m, int n)
{
	int sum = 0;
	for (int number = m; number <= n; number++)
	{
		sum += number;
	}
	return sum;
}

int m = ask_for_int_number("Enter m: ");
int n = ask_for_int_number("Enter n: ");
Console.WriteLine($"result: {int_numbers_in_range_sum(m, n)}");