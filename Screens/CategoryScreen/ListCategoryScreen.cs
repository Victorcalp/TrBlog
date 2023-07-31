using Blog.Data;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.CategoryScreen
{
    public class ListCategoryScreen
    {
        public static void List()
        {
            Console.Clear();
            var repository = new Repository<Category>(DataBase.Connection);

            var itens = repository.GetAll();

            foreach (var item in itens)
            {
                Console.WriteLine("ID: " + item.Id);
                Console.WriteLine("Nome: " + item.Name);
                Console.WriteLine("Slug: " + item.Slug);
                Console.WriteLine();
            }

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
    }
}