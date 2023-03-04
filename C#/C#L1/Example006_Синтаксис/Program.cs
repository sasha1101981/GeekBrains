internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ввведите имя пользователя: ");
        string username = Console.ReadLine();

        if (username.ToLower() == "маша")
        {
            Console.Write("Ура, этоже МАША");
        }
        else
        {
            Console.Write("Привет, ");
            Console.WriteLine(username);
        }
    }
}