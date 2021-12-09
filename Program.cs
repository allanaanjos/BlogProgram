using System;
using Blog.Screens.TagScreens;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    { 

        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1N6M3A7L@";
        static void Main(string[] args)
        { 
            Database.connection = new SqlConnection(CONNECTION_STRING);
            Database.connection.Open();
            Load();
            Console.ReadKey();
            Database.connection.Close();
        }    

        private static void Load(){

            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("------------------");
            Console.WriteLine("O que deseja Fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestao de usuario");
            Console.WriteLine("2 - Gestao de perfil");
            Console.WriteLine("3 - Gestao de Categoria");
            Console.WriteLine("4 - Gestao de Tag");
            Console.WriteLine("5 - Vincular perfil/usuario");
            Console.WriteLine("6 - Vincular post/tag");
            Console.WriteLine("7 - Relatorios");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()); 

            switch (option)
            {
                case 4: 
                    MenuTagScreen.Load();
                    break;
                default: Load(); break;
            }
        }

    } 
}            