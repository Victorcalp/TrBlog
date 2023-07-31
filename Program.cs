using Blog.Data;
using Blog.Screens.CategoryScreen;
using Blog.Screens.TagScreens;
using Microsoft.Data.SqlClient;

class Program
{
    private const string Connection_String = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True;";

    static void Main(string[] args)
    {
        Console.Clear();
        DataBase.Connection = new SqlConnection(Connection_String);
        DataBase.Connection.Open();

        Load();
        Console.ReadKey();

        DataBase.Connection.Close();
    }

    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Meu Blog");
        Console.WriteLine("------------");
        Console.WriteLine("O que deseja fazer? ");
        Console.WriteLine();
        Console.WriteLine("1 - Gestão de Usuário");
        Console.WriteLine("2 - Gestão de Perfil");
        Console.WriteLine("3 - Gestão de Categoria");
        Console.WriteLine("4 - Gestão de Tag");
        Console.WriteLine("5 - Vincular Perfil / Usuário");
        Console.WriteLine("6 - Vincular Post / Tag");
        Console.WriteLine("7 - Relatórios");

        var option = short.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 3:
                MenuCategoryScreen.Load();
                break;
            case 4:
                MenuTagScreens.Load();
                break;
            default: Load(); break;

        }
    }
}