using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryBTree
{
    public class DataBase
    {
        public BTree LoadDataBase(int n)
        {
            BTree tree = new BTree(2);

            int[] keys = new int[n];
            string[] values = new string[n];

            Random random = new Random();

            for (int counter = 0; counter < n; counter++)
            {
                int key = random.Next(1, n + 1);
                if (keys.Contains(key))
                {
                    counter--;
                    continue;
                }
                keys[counter] = key;
                values[counter] = "!" + key.ToString() + "!";
            }
            return LoadDataInBTree(tree, keys, values, n);
        }

        public static BTree LoadDataInBTree(BTree tree, int[] keys, string[] values, int n)
        {
            for (int counter = 0; counter < n; counter++)
            {
                tree.Insert(keys[counter], values[counter]);
            }
            return tree;
        }
    }
}
