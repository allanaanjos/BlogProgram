using System;
using Blog.models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    
    public static class DeleteTagsScreen
    {
        
        public static void Load(){
            
            Console.Clear();
            Console.WriteLine("Atualizando uma Tag");
            Console.WriteLine("----------------");
            
            Console.WriteLine("Qual O Id da Tag que deseja Excluir?");
            var id = Console.ReadLine();
            
            Delete(new Tag{Id= int.Parse(id),});
            Console.ReadKey();
            MenuTagScreen.Load();
        }

         public static void Delete(int id){ 
           try{
            var repository = new Repository<Tag>(Database.connection);
            repository.Delete(tag);
            Console.WriteLine("Tag Atualizada com Sucesso!!!");
           }
           catch (Exception ex){
                Console.WriteLine("Nao foi possivel Atualizar essa Tag");
                Console.WriteLine(ex.Message);
           }
        }
    }
}