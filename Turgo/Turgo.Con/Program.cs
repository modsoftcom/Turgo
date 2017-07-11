using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turgo.Lib;

namespace Turgo.Con
{
    class Program
    {
        static Connection connection;
        static void Main(string[] args)
        {
            connection = new Connection();
            showMenu();
        }

        private static void showMenu()
        {
                Console.WriteLine(":: BLUETOOTH DEVICE CONNECTION ::");
            int selectedMenu = 0;

            do
            {
                Console.WriteLine("********* MENU OPTIONS **********");
                Console.WriteLine("1. Discover devices around");
                Console.WriteLine("2. Show adapter info");
                Console.WriteLine("3. Exit");
                Console.Write("> Please select an option : ");
                int.TryParse(Console.ReadLine(), out selectedMenu);
                if (selectedMenu == 0)
                    Console.WriteLine("Please enter a number!");
                else if(selectedMenu < 1 || selectedMenu > 3)
                    Console.WriteLine("Please enter a correct number!");

            } while (selectedMenu < 1 || selectedMenu > 3);
            switch (selectedMenu)
            {
                case 1:
                    break;
                case 2:
                    Console.WriteLine("**** DEVICE ADAPTER INFO ****");
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
