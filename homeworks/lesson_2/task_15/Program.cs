Console.Write("Enter daynumber: ");
int day_number = int.Parse(Console.ReadLine());

if ( (day_number > 0 ) && (day_number < 8) )
{
	if (day_number > 5) 
	{
		Console.WriteLine("Yes");
	}
	else
	{
		Console.WriteLine("No");
	}
	
}
else 
{
	Console.WriteLine($"Number {day_number} is not daynumber!");
}

