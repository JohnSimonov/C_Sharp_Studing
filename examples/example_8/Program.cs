int Max( int number_1, int number_2, int number_3 )
{
	int max = number_1;
	if (number_2 > max) max = number_2;
	if (number_3 > max) max = number_3;
	return max;
}

int a1 = 15 ;
int b1 = 1121;
int c1 = 39;
int a2 = 12;
int b2 = 555;
int c2 = 33;
int a3 = 13;
int b3 = 223;
int c3 = 33;

int max_1 = Max(a1, b1, c1);
int max_2 = Max(a2, b2, c2);
int max_3 = Max(a3, b3, c3);
int max = Max(
	Max(a1, b1, c1),
	Max(a2, b2, c2),
	 Max(a3, b3, c3));

Console.WriteLine(max);
