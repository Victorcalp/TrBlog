using Blog.Data;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.TagScreens
{
    public class ListTagsScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Tags");
            Console.WriteLine("--------------");

            var repository = new Repository<Tag>(DataBase.Connection);
            var tags = repository.GetAll();

            foreach (var item in tags)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Slug}");
            }

            Console.ReadKey();
            MenuTagScreens.Load();
        }
    }
}