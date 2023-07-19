// Запрос целого числа у пользователя из консоли
int ask_for_int_number(string message)
{
	Console.Write(message);
	int number = int.Parse(Console.ReadLine());
	return number;
}

int accerman_function(int n, int m)
{
	if ( n == 0 ) return m + 1 ;
	if (m == 0) return accerman_function(n - 1 , 1);
	return accerman_function( n - 1 , accerman_function(n , m - 1));
}

int n = ask_for_int_number("Enter n: ");
int m = ask_for_int_number("Enter m: ");

Console.WriteLine($"result: {accerman_function(n, m)}");
