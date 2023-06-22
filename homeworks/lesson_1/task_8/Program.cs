Console.Write("Enter number N: ");
int number_n = int.Parse(Console.ReadLine());

int even_number = 2;

while (even_number <= number_n )
{
	Console.Write($"{even_number} ");
	even_number += 2;
}
Console.WriteLine("");