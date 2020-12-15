using System;
using IndrivoDataBase.ConsoleMenu;

namespace IndrivoDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TournamentDBContext())
            {
                //Console.BackgroundColor = ConsoleColor.DarkGray;
                //Console.ForegroundColor = ConsoleColor.Black;
                var Menu = new StartMenu();
                Menu.Menu();

            }
        }

    }
}