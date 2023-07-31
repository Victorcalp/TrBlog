
using Blog.Data;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.TagScreens
{
    public class CreateTagsScreen
    {
        public static void Create()
        {
            Console.Clear();
            Console.WriteLine("Nova Tag");
            Console.WriteLine("--------------");
            Console.Write("Nome: ");
            var name = Console.ReadLine();
            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            var tag = new Tag { Name = name, Slug = slug };

            try
            {
                var repository = new Repository<Tag>(DataBase.Connection);
                repository.Create(tag);
                Console.WriteLine("Tag Cadastrada");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel cadastrar a TAG");
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
            MenuTagScreens.Load();
        }
    }
}