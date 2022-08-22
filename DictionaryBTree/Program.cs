using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryBTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            DataBase start = new DataBase();
            BTree tree = start.LoadDataBase(n);
            MainMenu.Menu(tree);
        }
    }
}
