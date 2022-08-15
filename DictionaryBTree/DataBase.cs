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

            for (int i = 0; i < n; i++)
            {
                int key = random.Next(1, n + 1);
                if (keys.Contains(key))
                {
                    i--;
                    continue;
                }
                keys[i] = key;
                values[i] = "!" + key.ToString() + "!";
            }
            return LoadDataInBTree(tree, keys, values, n);
        }

        public static BTree LoadDataInBTree(BTree tree, int[] keys, string[] values, int n)
        {
            for (int i = 0; i < n; i++)
            {
                tree.Insert(keys[i], values[i]);
            }
            return tree;
        }
    }
}
