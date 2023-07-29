using Blog.Models;
using Blog.Repository;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

class Program
{
    private const string Connection_String = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True;";

    static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        DeleteUser();
        //UpdateUser();
        ReadUsers();
        //CreateUser();   
    }
    public static void ReadUsers()
    {
        var repository = new UserRepository();
        var users = repository.GetAll();

        foreach (var user in users)
        {
            Console.WriteLine(user.Name);
        }
    }
    public static void ReadUser()
    {
        using var connection = new SqlConnection(Connection_String);
        var user = connection.Get<User>(1); //lista todos os users da base

        Console.WriteLine(user.Name);
    }
    public static void CreateUser()
    {
        var user = new User()
        {
            Name = "Equipe balta.io",
            Bio = "Equipe balta.io",
            Image = "https://...",
            Email = "hello@balta.io",
            PasswordHash = "HASH",
            Slug = "equipe.balta",
        };

        using var connection = new SqlConnection(Connection_String);
        connection.Insert<User>(user);
        Console.WriteLine("Cadastro realizado com sucesso");
    }
    public static void UpdateUser()
    {
        var user = new User()
        {
            Id = 2,
            Name = "Equipe do balta.io",
            Bio = "Equipe balta.io",
            Image = "https://...",
            Email = "hello@balta.io",
            PasswordHash = "HASH",
            Slug = "equipe.balta",
        };

        using var connection = new SqlConnection(Connection_String);
        connection.Update<User>(user);
        Console.WriteLine("Update realizado com sucesso");
    }

    public static void DeleteUser()
    {

        using var connection = new SqlConnection(Connection_String);
        var user = connection.Get<User>(2);
        connection.Delete<User>(user);
        Console.WriteLine("Exclusão realizada");
    }
}