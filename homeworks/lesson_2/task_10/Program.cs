Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

int second_digit = (number / 10) % 10 ;
Console.WriteLine($"Second digit is {second_digit}");
