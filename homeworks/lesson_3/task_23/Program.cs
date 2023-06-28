Console.Write("Enter number: ");
int number =  int.Parse(Console.ReadLine());

for (int counter = 1; counter <= number; counter++)
{	
	double cube_of_number = Math.Pow(counter, 3);
	Console.Write($"{cube_of_number} ");
}
Console.WriteLine();
