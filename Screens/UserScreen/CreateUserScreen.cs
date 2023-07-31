
using Blog.Data;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.UserScreen
{
    public class CreateUserScreen
    {
        public static void Create()
        {
            var repository = new Repository<User>(DataBase.Connection);

            Console.Clear();
            Console.WriteLine("Novo Usuário");
            Console.WriteLine();
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("PasswordHash: ");
            string passwordHash = Console.ReadLine();
            Console.Write("Bio: ");
            string bio = Console.ReadLine();
            Console.Write("Image: ");
            string image = Console.ReadLine();
            Console.Write("Slug: ");
            string slug = Console.ReadLine();

            try
            {
                Console.WriteLine();
                Console.WriteLine("Usuário Criado");
                repository.Create(new User { Name = name, Email = email, PasswordHash = passwordHash, Bio = bio, Image = image, Slug = slug });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

            Console.ReadKey();
            MenuUserScreen.Load();
        }
    }
}