using Blog.Data;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.UserScreen
{
    public class UpdateUserScreen
    {
        public static void Update()
        {
            var repository = new Repository<User>(DataBase.Connection);

            Console.Clear();
            Console.WriteLine("Atualizar Usuário");
            Console.WriteLine();
            Console.Write("ID do Usuário: ");
            int id = int.Parse(Console.ReadLine());

            try
            {
                var result = repository.GetAll().FirstOrDefault(x => x.Id == id);

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

                repository.Update(new User { Id = id, Name = name, Email = email, PasswordHash = passwordHash, Bio = bio, Image = image, Slug = slug });

                Console.Clear();
                Console.WriteLine("Usuário Atualizado");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro" + ex.Message);
            }

            Console.ReadKey();
            MenuUserScreen.Load();
        }
    }
}