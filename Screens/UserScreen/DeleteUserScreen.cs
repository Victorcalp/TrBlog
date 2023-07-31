using Blog.Data;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.UserScreen
{
    public class DeleteUserScreen
    {
        public static void Delete()
        {
            Console.Clear();
            Console.WriteLine("Deletar Usuário");
            Console.WriteLine();
            Console.Write("ID do Usuário: ");
            int id = int.Parse(Console.ReadLine());
            try
            {
                var repository = new Repository<User>(DataBase.Connection);
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
            MenuUserScreen.Load();
        }
    }
}