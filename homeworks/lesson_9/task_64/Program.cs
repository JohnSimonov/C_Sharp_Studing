// Запрос целого числа у пользователя из консоли
int ask_for_int_number(string message)
{
	Console.Write(message);
	int number = int.Parse(Console.ReadLine());
	return number;
}

// Функция выводит убывающую последовательность натуральных чисел от n до 1
string number_row_descending(int n)
{
	if (n == 1) return "1" ;
	return $"{n} " + number_row_descending(n - 1);
}

int n = ask_for_int_number("Enter n: ");
Console.WriteLine(number_row_descending(n));
