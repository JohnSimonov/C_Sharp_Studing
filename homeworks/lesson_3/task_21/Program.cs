int request_number(string number_name)
{
	Console.Write($"Enter {number_name}: ");
    return int.Parse(Console.ReadLine());
}


int x_1 = request_number("x1");
int y_1 = request_number("y1");
int z_1 = request_number("z1");

int x_2 = request_number("x2");
int y_2 = request_number("y2");
int z_2 = request_number("z2");

int x_difference = x_2 - x_1;
int y_difference = y_2 - y_1;
int z_difference = z_2 - z_1;

double s = Math.Sqrt( Math.Pow(x_difference, 2) + Math.Pow(y_difference, 2) + Math.Pow(z_difference, 2));

Console.WriteLine(s);