using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            Console.WriteLine();
            // var option = short.Parse(Console.ReadLine()!); // ! força a entrada de uma string

            // switch (option)
            // {
            //     case 1:
            //         listtagsscreen.load();
            //         break;
            //     case 2:
            //         createtagsscreen.load();
            //         break;
            //     case 3:
            //         updatetagscreen.load();
            //         break;
            //     case 4:
            //         deletetagscreen.load();
            //         break;
            //     default:
            //         load();
            //         break;
            // }

        }
    }
}