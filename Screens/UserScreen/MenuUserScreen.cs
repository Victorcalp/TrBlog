
namespace Blog.Screens.UserScreen
{
    public class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Usuário");
            Console.WriteLine("------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar");
            Console.WriteLine("2 - Cadastrar");
            Console.WriteLine("3 - Atualizar");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("5 - Voltar para o Inicio");

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListUserScreen.List();
                    break;
                case 2:
                    CreateUserScreen.Create();
                    break;
                case 3:
                    UpdateUserScreen.Update();
                    break;
                case 4:
                    DeleteUserScreen.Delete();
                    break;
                case 5:
                    Program.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}