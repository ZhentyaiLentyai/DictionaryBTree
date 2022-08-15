using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using DictionaryBTree;

namespace Benchmark
{
    [RankColumn]
    [MValueColumn]
    public class BTreeBenchmark
    {
        private const int key = 1;
        private readonly BTreeNode tree = new BTreeNode(2, true);
        private readonly DataBase data = new DataBase();

        //100 keys
        public void start100()
        {
            data.LoadDataBase(100);
        }

        [Benchmark]
        public void TestSearch()
        {
            tree.Search(key);
        }

        //1000 keys
        public void start1000()
        {
            data.LoadDataBase(1000);
        }

        [Benchmark]
        public void TestSearch1000()
        {
            tree.Search(key);
        }

        //10000 keys
        public void start10000()
        {
            data.LoadDataBase(10000);
        }

        [Benchmark]
        public void TestSearch10000()
        {
            tree.Search(key);
        }
    }
}
