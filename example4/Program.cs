Console.WriteLine("Введите Ваше имя ");

string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("УРА, это же Маша");
}

else {
    Console.WriteLine("Привет, " + username);
}