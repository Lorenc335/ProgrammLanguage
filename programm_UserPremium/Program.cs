Console.WriteLine("введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "masha")
{
    Console.WriteLine("wow, it is Masha!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}