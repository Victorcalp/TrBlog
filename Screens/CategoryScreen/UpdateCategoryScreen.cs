
using Blog.Data;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.CategoryScreen
{
    public class UpdateCategoryScreen
    {
        public static void Update()
        {
            var repository = new Repository<Category>(DataBase.Connection);

            Console.Clear();
            Console.WriteLine("Atualizar Categoria");
            Console.WriteLine();
            Console.Write("ID da Categoria: ");
            int id = int.Parse(Console.ReadLine());

            try
            {
                var result = repository.GetAll().FirstOrDefault(x => x.Id == id);

                Console.Write("Nome: " + result.Name + " - ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    name = result.Name;
                }
                Console.Write("Slug: " + result.Slug + " - ");
                string slug = Console.ReadLine();
                if (slug == "")
                {
                    slug = result.Slug;
                }

                repository.Update(new Category { Id = id, Name = name, Slug = slug });

                Console.Clear();
                Console.WriteLine("Categoria Atualizada");
                Console.WriteLine("Nome: " + name);
                Console.WriteLine("Slug: " + slug);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro" + ex.Message);
            }

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
    }
}