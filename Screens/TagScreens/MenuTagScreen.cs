using System;

namespace Blog.Screens.TagScreens
{
    
    public static class MenuTagScreen
    {
        public static void Load(){
            Console.Clear();
            Console.WriteLine("Gestao de tags");
            Console.WriteLine("--------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listas Tags");
            Console.WriteLine("2 - Cadastro Tags");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:       
                    ListTagsScreen.Load();
                    break;
                case 2: 
                    CreateTagScreen.Load();
                    break;
                case 3:
                    UptadeTagsScreen.Load();
                    break;
                case 4:
                    DeleteTagsScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}