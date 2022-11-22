Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "наташа")
{
    Console.WriteLine ("Здравствуй дорогая, Наташа");
}
 
 else 
{
    Console.Write("Привет, ");
    Console.WriteLine (username);
}