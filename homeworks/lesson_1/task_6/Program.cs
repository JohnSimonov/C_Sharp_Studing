Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
	Console.WriteLine($"Number {number} is even");
}
else
{
	Console.WriteLine($"Number {number} is odd");
}

