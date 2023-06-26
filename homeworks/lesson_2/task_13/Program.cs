Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
int number_copy = number;

if (number / 100 < 1)
{
	Console.WriteLine("No third digit!");
}
else 
{
	while ( (number_copy / 1000) > 0 )
		{
			number_copy = number_copy / 10;
		}

		int third_digit = number_copy % 10;
		Console.WriteLine($"In number {number} third digit is {third_digit}");
}

