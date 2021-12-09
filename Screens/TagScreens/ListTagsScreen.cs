using System;
using Blog.models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    
    public static class ListTagsScreen
    {
        
        public static void Load(){ 
            Console.Clear();
            Console.WriteLine("List de Tags");
            Console.WriteLine("-----------------------");

            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List(){

            var Repository = new Repository<Tag>(Database.connection);
            var tags = Repository.Get();
            foreach (var item in tags)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - ({item.Slug})");
            }
        }
    }
}