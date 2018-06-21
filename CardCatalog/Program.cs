using System;

namespace CardCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            //I'm so lost man, how does Git work?
            //I know
            
            bool displaymenu = true;

            while (displaymenu)
            {
                displaymenu = MainMenu();

            }


        }

        private static bool MainMenu()
        {
            Console.WriteLine("Enter the name of a file: ");
            string filename = Console.ReadLine();
            CardCatalog cc = new CardCatalog();
            Console.WriteLine("Select a number");
            Console.Write("1. List All books");
            Console.Write("2. Add a book");
            Console.Write("3. Save and Exit");

            string option = Console.ReadLine();
            int num = int.Parse(option);

            if (num == 1)
            {

               
            }
            else if (num == 2)
            {
                cc.AddBook();
            }
            else if (num == 3)
            {
                return false;
            }
            return true;
        }


            

    }
}
