using Blog.Data;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.TagScreens
{
    public class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Delete TAG");
            Console.WriteLine();
            Console.Write("Qual o ID: ");
            int id = int.Parse(Console.ReadLine());

            try
            {
                var repository = new Repository<Tag>(DataBase.Connection);

                var tags = repository.GetAll().FirstOrDefault(x => x.Id == id);

                Console.WriteLine("Nome: " + tags.Name);
                Console.WriteLine("Slug: " + tags.Slug);
                Console.WriteLine();
                Console.Write("Continuar com exclusão(y/n): ");
                char quest = char.Parse(Console.ReadLine().ToLower());
                if (quest == 'y')
                {
                    repository.Delete(id);
                    Console.WriteLine("Tag excluida");
                }
                else
                {
                    Console.WriteLine("Operação cancelada");
                }

                Console.ReadKey();
                MenuTagScreens.Load();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}