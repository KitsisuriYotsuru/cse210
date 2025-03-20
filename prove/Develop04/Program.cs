using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        bool quit = false;

        while(!quit)
        {
            Console.Clear();
            menu.DisplayMenu();
            string input = menu.GetResponse();
            switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        quit = true;
                        break;
                }
        }

    }
}