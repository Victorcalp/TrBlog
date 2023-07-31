
using Blog.Data;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.CategoryScreen
{
    public class DeleteCategoryScreen
    {
        public static void Delete()
        {
            Console.Clear();
            Console.WriteLine("Deletar Categoria");
            Console.WriteLine();
            Console.Write("ID da categoria: ");
            int id = int.Parse(Console.ReadLine());
            try
            {
                var repository = new Repository<Category>(DataBase.Connection);
                var result = repository.GetAll().FirstOrDefault(x => x.Id == id);
                Console.WriteLine("Nome: " + result.Name);
                Console.WriteLine("Slug: " + result.Slug);
                Console.WriteLine();
                Console.WriteLine("Deseja continuar com a exclusão(Y/N)? ");
                char quest = char.Parse(Console.ReadLine().ToLower());
                if (quest == 'y')
                {
                    Console.WriteLine("Exclusão Realizada");
                    repository.Delete(id);
                }
                else
                {
                    Console.WriteLine("Operação cancelada");
                }
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