Console.Write("Enter first number: ");
int first_number = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int second_number = int.Parse(Console.ReadLine());

Console.Write("Enter third number: ");
int third_number = int.Parse(Console.ReadLine());

int max = first_number;
if (second_number > max) max = second_number;
if (third_number > max) max = third_number;

Console.WriteLine($"max = {max}");