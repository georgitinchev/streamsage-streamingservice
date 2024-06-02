using LogicClassLibrary.Helpers;

// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        string username = "RandomUser";
        string password = "RandomPassword";
        string email = "randomuser@example.com";

        string salt = PasswordHelper.GenerateSalt();
        string hashedPassword = PasswordHelper.HashPassword(password, salt);

        Console.WriteLine($"Username: {username}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Password Hash: {hashedPassword}");
        Console.WriteLine($"Password Salt: {salt}");
    }
}
