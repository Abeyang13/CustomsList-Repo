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
        [TestMethod]
        public void Remove_ItemTwo_CheckIndexTwo()
        {
            // arrange
            CustomsListClass<int> testList = new CustomsListClass<int>();
            int expected = 4;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Remove(2);
            actual = testList[2];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ItemFour_CheckCountEqualsToThree()
        {
            // arrange
            CustomsListClass<int> testList = new CustomsListClass<int>();
            int expected = 4;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Remove(4);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ItemThree_CheckItemThreeAtIndexFour()
        {
            // arrange
            CustomsListClass<int> testList = new CustomsListClass<int>();
            int expected = 3;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(3);
            testList.Remove(3);
            actual = testList[4];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ItemOfEmptyLIst_CheckCountEqualsZero()
        {
            // arrange
            CustomsListClass<int> testList = new CustomsListClass<int>();
            int expected = 0;
            int actual;

            // act
            testList.Remove(1);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void To_String_AList()
        {
            // arrange
            CustomsListClass<int> testList = new CustomsListClass<int>();
            string expected = "1234";
            string actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            actual = testList.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_AnEmptyList_ReturnEmptyList()
        {
            // arrange
            CustomsListClass<int> testList = new CustomsListClass<int>();
            string expected = "";
            string actual;

            // act
            actual = testList.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_AList_ReturnOnlyOneThreeFour()
        {
            // arrange
            CustomsListClass<int> testList = new CustomsListClass<int>();
            string expected = "134";
            string actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(2);
            actual = testList.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
