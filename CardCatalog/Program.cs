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
            bool displaymenu = true;

            if (displaymenu)
            {
                MainMenu();

            }


        }

        private static bool MainMenu()
        {
            Console.WriteLine("Enter the name of a file: ");
            string filename = Console.ReadLine();
            Console.WriteLine("Select a number");
            Console.Write("1. List All books");
            Console.Write("2. Add a book");
            Console.Write("3. Save and Exit");

            string input = Console.ReadLine();



            return false;
        }


    }
}
