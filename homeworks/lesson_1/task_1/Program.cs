Console.Write("Enter first number: ");
int first_number = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int second_number = int.Parse(Console.ReadLine());

if (first_number > second_number)
{
	Console.WriteLine($"max = {first_number}");
}
else
{
	Console.WriteLine($"max = {second_number}");
}