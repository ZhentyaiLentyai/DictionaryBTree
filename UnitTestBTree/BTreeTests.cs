using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DictionaryBTree
{
    [TestClass]
    public class BTreeTests
    {

        [TestMethod]
        public void SearchValues()
        {
            // arrange
            DataBase data = new DataBase();
            var tree = new BTree(2);

            tree = data.LoadDataBase(100);
            
            int key = 30;
            string value = "!30!";

            // act
            string rezult = tree.Search(key);

            // assert
            Assert.AreEqual(value, rezult);
        }

        [TestMethod]
        public void SearchValuesError()
        {
            // arrange
            DataBase data = new DataBase();
            var tree = new BTree(2);

            tree = data.LoadDataBase(100);

            int key = 300;
            string value = null;

            // act
            string rezult = tree.Search(key);

            // assert
            Assert.AreEqual(value, rezult);
        }
    }
}
