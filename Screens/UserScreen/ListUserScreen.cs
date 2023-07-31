using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.UserScreen
{
    public class ListUserScreen
    {
      public static void List()
        {
            Console.Clear();
            var repository = new Repository<User>(DataBase.Connection);

            var itens = repository.GetAll();

            foreach (var item in itens)
            {
                Console.WriteLine("ID: " + item.Id);
                Console.WriteLine("Nome: " + item.Name);
                Console.WriteLine("E-mail: " + item.Email);
                Console.WriteLine("PasswordHash: " + item.PasswordHash);
                Console.WriteLine("Bio: " + item.Bio);
                Console.WriteLine("Image: " + item.Image);
                Console.WriteLine("Slug: " + item.Slug);
                Console.WriteLine();
            }

            Console.ReadKey();
            MenuUserScreen.Load();
        }  
    }
}