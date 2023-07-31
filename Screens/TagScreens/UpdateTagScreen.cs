using Blog.Data;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.TagScreens
{
    public class UpdateTagScreen
    {
        public static void Update()
        {
            Console.Clear();
            Console.WriteLine("Atualizando Tag");
            Console.WriteLine("--------------");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            try
            {
                var repository = new Repository<Tag>(DataBase.Connection);
                var result = repository.GetAll().FirstOrDefault(x => x.Id == id);

                Console.Write("Nome: '" + result.Name + "' - ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    name = result.Name;
                }
                Console.Write("Slug: '" + result.Slug + "' - ");
                string slug = Console.ReadLine();
                if (slug == "")
                {
                    slug = result.Slug;
                }

                repository.Update(new Tag { Id = id, Name = name, Slug = slug });

                Console.Clear();
                Console.WriteLine("Tag Atualizada");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Slug: " + slug);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel atualizar TAG - " + ex.Message);
            }
            Console.ReadKey();
            MenuTagScreens.Load();
        }
    }
}