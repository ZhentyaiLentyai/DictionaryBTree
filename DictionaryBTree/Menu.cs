using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryBTree
{
    public class MainMenu
    {
        public static void Menu(BTree tree)
        {
            bool flag = true;
            while (flag)
            {
                string choice = Table();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter key: ");
                        int key = Convert.ToInt32(Console.ReadLine());
                        tree.Search(key);
                        break;
                    case "0":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Error: enter a valid number");
                        Menu(tree);
                        break;
                }
            }
        }
        public static string Table()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. Search by key");
            Console.WriteLine("0. Exit");
            Console.WriteLine("-----------------------------------");
            Console.Write("-> ");
            string choice = Console.ReadLine();
            Console.WriteLine("-----------------------------------");
            return choice;
        }
    }
}
