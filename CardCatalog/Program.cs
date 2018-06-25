using System;

namespace CardCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            //I'm so lost man, how does Git work?
            //I know
            
            Console.WriteLine("Enter the name of a file: ");
            string inputfilename = Console.ReadLine();
            CardCatalog cc = new CardCatalog(inputfilename);
            

            
            bool displaymenu = true;

            while (displaymenu)
            {
                displaymenu = MainMenu(cc);

            }


        }

        private static bool MainMenu(CardCatalog cc)
        {
            
            Console.WriteLine("Select a number");
            Console.WriteLine("1. List All Books");
            Console.WriteLine("2. Add a Book");
            Console.WriteLine("3. Save and Exit");

            string option = Console.ReadLine();
            int num = int.Parse(option);

            if (num == 1)
            {
                cc.ListAllBooks();
               
            }
            else if (num == 2)
            {
                Console.WriteLine("1.Enter Title: ");
                string title = Console.ReadLine();
                Console.WriteLine("2.Enter Author: ");
                string author= Console.ReadLine();
                Console.WriteLine("3.Enter ISBN: ");
                string ISBN = Console.ReadLine();
                cc.AddBook(new Book(author, title, ISBN));
            }
            else if (num == 3)
            {
                cc.savememorytofile();
                return false;
            }
            return true;
        }

         

            

    }
}
