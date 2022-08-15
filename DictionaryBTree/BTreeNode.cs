using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryBTree
{
    public class BTreeNode
    {
        public bool leaf;
        public int n;
        int t;
        public int[] keys;
        public string[] values;
        public BTreeNode[] branches;

        public BTreeNode(int _t, bool _leaf)
        {
            this.t = _t;
            this.leaf = _leaf;
            keys = new int[2 * t - 1];
            values = new string[2 * t - 1];
            branches = new BTreeNode[2 * t];
            n = 0;
        }

        public void InsertNonFull(int key, string val)
        {
            int i = n - 1;

            if (leaf == true)
            {

                while (i >= 0 && keys[i] > key)
                {
                    keys[i + 1] = keys[i];
                    values[i + 1] = values[i];
                    i--;
                }

                keys[i + 1] = key;
                values[i + 1] = val;
                n = n + 1;
            }
            else
            {
                while (i >= 0 && keys[i] > key)
                    i--;
                if (branches[i + 1].n == 2 * t - 1)
                {
                    SplitChild(i + 1, branches[i + 1]);

                    if (keys[i + 1] < key)
                        i++;
                }
                branches[i + 1].InsertNonFull(key, val);
            }
        }

        public void SplitChild(int i, BTreeNode y)
        {
            BTreeNode z = new BTreeNode(y.t, y.leaf);
            z.n = t - 1;

            for (int j = 0; j < t - 1; j++)
            {
                z.keys[j] = y.keys[j + t];
                z.values[j] = y.values[j + t];
            }

            if (y.leaf == false)
                for (int j = 0; j < t; j++)
                {
                    z.branches[j] = y.branches[j + t];
                    y.branches[j + t] = null;
                }


            for (int j = n; j >= i; j--)
                branches[j + 1] = branches[j];

            branches[i + 1] = z;


            for (int j = n - 1; j >= i; j--)
            {
                keys[j + 1] = keys[j];
                values[j + 1] = values[j];
            }

            keys[i] = y.keys[t - 1];
            values[i] = y.values[t - 1];

            for (int j = y.n - 1; j >= t - 1; j--)
            {
                y.keys[j] = 0;
                y.values[j] = null;
            }
            y.n = t - 1;

            n = n + 1;
        }
        public string Search(int k)
        {
            int i = 0;
            while (i < n - 1 && k > keys[i])
                i++;

            if (k > keys[i])
            {
                if (leaf == true)
                {
                    return null;
                }
                return branches[i + 1].Search(k);
            }

            if (keys[i] == k)
            {
                return values[i];
            }

            if (leaf == true)
            {
                return null;
            }

            return branches[i].Search(k);
        }
    }
}
