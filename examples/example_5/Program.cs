Console.Write("Пожалуйста, введите своё имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
	Console.WriteLine("О нет, только не Маша");
}
else
{
	Console.WriteLine("Привет, " + username);
}
