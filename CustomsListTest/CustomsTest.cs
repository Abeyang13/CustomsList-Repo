using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomsList;

namespace CustomsListTest
{
    [TestClass]
    public class CustomsTest
    {
        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomsListClass<int> testList = new CustomsListClass<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(1);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToListWithExistingItem_NewItemGoesToEndOfList()
        {
            // arrange
            CustomsListClass<int> testList = new CustomsListClass<int>();
            int expected = 2;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToEmptyList_CountGoesToOne()
        {
            // arrange
            CustomsListClass<int> testList = new CustomsListClass<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(5);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        // write a test for when the array size changes (what is you array's starting size?)
        [TestMethod]
        public void Add_ItemFive_CountToFive()
        {
            // arrange
            CustomsListClass<int> testList = new CustomsListClass<int>();
            int expected = 5;
            int actual;

            // act
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(8);
            testList.Add(9);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ItemFive_CheckIndexFour()
        {
            // arrange
            CustomsListClass<int> testList = new CustomsListClass<int>();
            int expected = 9;
            int actual;

            // act
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(8);
            testList.Add(9);
            actual = testList[4];

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
