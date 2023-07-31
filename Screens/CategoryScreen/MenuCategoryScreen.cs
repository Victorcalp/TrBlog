
namespace Blog.Screens.CategoryScreen
{
    public class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Categoria");
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
                    ListCategoryScreen.List();
                    break;
                case 2:
                    CreateCategoryScreen.Create();
                    break;
                case 3:
                    UpdateCategoryScreen.Update();
                    break;
                case 4:
                    DeleteCategoryScreen.Delete();
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