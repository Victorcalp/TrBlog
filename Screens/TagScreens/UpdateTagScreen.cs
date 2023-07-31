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
                var tags = repository.GetAll();

                var result = tags.FirstOrDefault(x => x.Id == id);

                // Console.WriteLine("Name: " + result.Name);
                // Console.WriteLine("Slug: " + result.Slug);

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
                Console.ReadKey();
                MenuTagScreens.Load();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel atualizar TAG - " + ex.Message);
                Console.ReadKey();
                MenuTagScreens.Load();
            }
        }
    }
}