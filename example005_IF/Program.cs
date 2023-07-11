Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "emil")
{
	Console.WriteLine("i love you, Emil");
}
else 
{
	Console.Write("Privet");
	Console.WriteLine(username);
}
