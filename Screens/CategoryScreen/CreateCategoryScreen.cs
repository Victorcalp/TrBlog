using Blog.Data;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.CategoryScreen
{
    public class CreateCategoryScreen
    {
        public static void Create()
        {
            var repository = new Repository<Category>(DataBase.Connection);

            Console.Clear();
            Console.WriteLine("Nova Categoria");
            Console.WriteLine();
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Slug: ");
            string slug = Console.ReadLine();

            try
            {
                Console.WriteLine();
                Console.WriteLine("Categoria Criada");
                repository.Create(new Category { Name = name, Slug = slug });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
    }
}