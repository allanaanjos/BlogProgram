using System;
using Blog.models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    
    public static class CreateTagScreen
    {
        
        public static void Load(){
            
            Console.Clear();
            Console.WriteLine("Nova Tag");
            Console.WriteLine("----------------");
            
            Console.WriteLine("Name");
            var name = Console.ReadLine();
            
            Console.WriteLine("Slug");
            var slug = Console.ReadLine();
            
            Create(new Tag{Name=name, Slug=slug});
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Create(Tag tag){ 
           try{
            var repository = new Repository<Tag>(Database.connection);
            repository.Create(tag);
            Console.WriteLine("Tag Cadastrada com Sucesso!!!");
           }
           catch (Exception ex){
                Console.WriteLine("Nao foi possivel salvar a Tag");
                Console.WriteLine(ex.Message);
           }
        }
    }
}