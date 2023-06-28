Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

int first_digit = number / 10000 ;
int fifth_digit = number % 10 ;
bool first_condition = ( first_digit == fifth_digit );

int second_digit = ( number / 1000 ) % 10 ;
int fourth_digit = (number / 10) % 10 ;
bool second_condition = ( second_digit == fourth_digit) ;

if (first_condition && second_condition)
{
	Console.WriteLine("Yes");
}
else
{
	Console.WriteLine("No");
}