using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryBTree
{
    public class BTree
    {
        int t;
        BTreeNode root;

        public BTree(int _t)
        {
            root = null;
            t = _t;
        }

        public void Insert(int key, string val)
        {
            if (root == null)
            {
                root = new BTreeNode(t, true);
                root.keys[0] = key;
                root.values[0] = val;
                root.n = 1;
            }
            else
            {
                if (root.n == 2 * t - 1)
                {

                    BTreeNode s = new BTreeNode(t, false);


                    s.branches[0] = root;

                    s.SplitChild(0, root);

                    int i = 0;
                    if (s.keys[0] < key)
                        i++;

                    s.branches[i].InsertNonFull(key, val);

                    root = s;
                }
                else
                    root.InsertNonFull(key, val);
            }
        }

        public void Search()
        {
            Console.Write("Enter key: ");
            int key = Convert.ToInt32(Console.ReadLine());
            string values = root.Search(key);

            if (values != null)
            {
                Console.WriteLine($"Key {key}, contains values:{values}");
            }
            else
            {
                Console.WriteLine("Key does not exist");
            }
        }
    }
}
