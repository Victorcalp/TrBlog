
namespace Blog.Screens.TagScreens
{
    public static class MenuTagScreens
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Tags");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Tags");
            Console.WriteLine("2 - Cadastrar Tags");
            Console.WriteLine("3 - Atualizar Tags");
            Console.WriteLine("4 - Excluir Tags");
            Console.WriteLine("5 - Voltar para o Inicio");
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!); // ! força a entrada de uma string

            switch (option)
            {
                case 1:
                    ListTagsScreen.Load();
                    break;
                case 2:
                    CreateTagsScreen.Create();
                    break;
                case 3:
                    UpdateTagScreen.Update();
                    break;
                case 4:
                    DeleteTagScreen.Load();
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