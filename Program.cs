﻿using Blog.Screens.CategoryScreen;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreen;

class Program
{
    static void Main(string[] args)
    {
        Load();
        Console.ReadKey();
    }

    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Meu Blog");
        Console.WriteLine("------------");
        Console.WriteLine("O que deseja fazer? ");
        Console.WriteLine();
        Console.WriteLine("1 - Gestão de Usuário");
        Console.WriteLine("2 - Gestão de Perfil");
        Console.WriteLine("3 - Gestão de Categoria");
        Console.WriteLine("4 - Gestão de Tag");
        Console.WriteLine("5 - Vincular Perfil / Usuário");
        Console.WriteLine("6 - Vincular Post / Tag");
        Console.WriteLine("7 - Relatórios");

        var option = short.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1:
                MenuUserScreen.Load();
                break;
            case 3:
                MenuCategoryScreen.Load();
                break;
            case 4:
                MenuTagScreens.Load();
                break;
            default: Load(); break;
        }
    }
}