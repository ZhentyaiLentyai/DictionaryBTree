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
            BTreeNode s = new BTreeNode(2, true);
            int key = 30;
            string value = "!30!";
            BTree v = new BTree(2);
            // act
            string rezult = s.Search(key);

            // assert
            Assert.AreEqual(value, rezult);
        }

        [TestMethod]
        public void SearchValuesError()
        {
            // arrange
            BTreeNode s = new BTreeNode(2, true);
            int key = 300;
            string value = null;

            // act
            string rezult = s.Search(key);

            // assert
            Assert.AreEqual(value, rezult);
        }
    }
}
