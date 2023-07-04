Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

int digits_sum(int number)
{
	int sum = 0;
	while (number > 0)
	{
		sum += number % 10;
		number /= 10;
	}

	return sum;

}

Console.WriteLine(digits_sum(number));