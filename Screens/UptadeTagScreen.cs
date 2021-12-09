using System;
using Blog.models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    
    public static class UptadeTagsScreen
    {
        
       
        public static void Load(){
            
            Console.Clear();
            Console.WriteLine("Atualizando uma Tag");
            Console.WriteLine("----------------");
            
            Console.WriteLine("Id");
            var id = Console.ReadLine();
            
            Console.WriteLine("Name");
            var name = Console.ReadLine();
            
            Console.WriteLine("Slug");
            var slug = Console.ReadLine();
            
            Upadate(new Tag{Id= int.Parse(id), Name=name, Slug=slug});
            Console.ReadKey();
            MenuTagScreen.Load();
        }

         public static void Upadate(Tag tag){ 
           try{
            var repository = new Repository<Tag>(Database.connection);
            repository.Uptade(tag);
            Console.WriteLine("Tag Atualizada com Sucesso!!!");
           }
           catch (Exception ex){
                Console.WriteLine("Nao foi possivel Atualizar essa Tag");
                Console.WriteLine(ex.Message);
           }
        }
    }
}