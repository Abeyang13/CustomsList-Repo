﻿using System;
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
        [TestMethod]
        public void Overload_PlusOperator_WithListOneAndListTwo()
        {
            // arrange
            CustomsListClass<int> testListOne = new CustomsListClass<int>();
            CustomsListClass<int> testListTwo = new CustomsListClass<int>();
            string expected = "135246";
            string actual;
            // act
            testListOne.Add(1);
            testListOne.Add(3);
            testListOne.Add(5);
            testListTwo.Add(2);
            testListTwo.Add(4);
            testListTwo.Add(6);
            actual = (testListOne + testListTwo).ToString();
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Overload_PlusOperator_WithListOneWithTwoItemsAndListTwoWithThreeItems()
        {
            // arrange
            CustomsListClass<int> testListOne = new CustomsListClass<int>();
            CustomsListClass<int> testListTwo = new CustomsListClass<int>();
            string expected = "13246";
            string actual;
            // act
            testListOne.Add(1);
            testListOne.Add(3);
            testListTwo.Add(2);
            testListTwo.Add(4);
            testListTwo.Add(6);
            actual = (testListOne + testListTwo).ToString();
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Overload_PlusOperator_WithEmptyListOneAndListTwo()
        {
            // arrange
            CustomsListClass<int> testListOne = new CustomsListClass<int>();
            CustomsListClass<int> testListTwo = new CustomsListClass<int>();
            string expected = "246";
            string actual;
            // act
            testListTwo.Add(2);
            testListTwo.Add(4);
            testListTwo.Add(6);
            actual = (testListOne + testListTwo).ToString();
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinusOperator_WithListOneAndListTwo_ResultingListOneReturningWithOneMissing()
        {
            // arrange
            CustomsListClass<int> testListOne = new CustomsListClass<int>();
            CustomsListClass<int> testListTwo = new CustomsListClass<int>();
            string expected = "35";
            string actual;
            // act
            testListOne.Add(1);
            testListOne.Add(3);
            testListOne.Add(5);
            testListTwo.Add(2);
            testListTwo.Add(1);
            testListTwo.Add(6);
            actual = (testListOne - testListTwo).ToString();
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinusOperator_WithListOneAndListTwo_ReturnListOneOriginalSinceNoValueEqualsListTwo()
        {
            // arrange
            CustomsListClass<int> testListOne = new CustomsListClass<int>();
            CustomsListClass<int> testListTwo = new CustomsListClass<int>();
            string expected = "135";
            string actual;
            // act
            testListOne.Add(1);
            testListOne.Add(3);
            testListOne.Add(5);
            testListTwo.Add(2);
            testListTwo.Add(4);
            testListTwo.Add(6);
            actual = (testListOne - testListTwo).ToString();
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinusOperator_WithListOneWithTwoValueOfFiveToListTwo_ReturnListOneWithOneAndFive()
        {
            // arrange
            CustomsListClass<int> testListOne = new CustomsListClass<int>();
            CustomsListClass<int> testListTwo = new CustomsListClass<int>();
            string expected = "15";
            string actual;
            // act
            testListOne.Add(1);
            testListOne.Add(5);
            testListOne.Add(5);
            testListTwo.Add(2);
            testListTwo.Add(4);
            testListTwo.Add(5);
            actual = (testListOne - testListTwo).ToString();
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinusOperator_WithListOneAndEmptyListTwo_ReturnAllValuesOfListOne()
        {
            // arrange
            CustomsListClass<int> testListOne = new CustomsListClass<int>();
            CustomsListClass<int> testListTwo = new CustomsListClass<int>();
            string expected = "135";
            string actual;
            // act
            testListOne.Add(1);
            testListOne.Add(3);
            testListOne.Add(5);
            actual = (testListOne - testListTwo).ToString();
            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Zip_ListOneAndListTwo_ResultOneTwoThreeFourFiveSix()
        {
            CustomsListClass<int> testListOne = new CustomsListClass<int>();
            CustomsListClass<int> testListTwo = new CustomsListClass<int>();
            CustomsListClass<int> newList = new CustomsListClass<int>();
            string expected = "123456";
            string actual;
            // act
            testListOne.Add(1);
            testListOne.Add(3);
            testListOne.Add(5);
            testListTwo.Add(2);
            testListTwo.Add(4);
            testListTwo.Add(6);
            actual = newList.Zip(testListOne,testListTwo).ToString();
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_ListOneHasTwoItemsAndListTwoHas3Items_ResultShouldStopAtTheEndOfShortestList()
        {
            CustomsListClass<int> testListOne = new CustomsListClass<int>();
            CustomsListClass<int> testListTwo = new CustomsListClass<int>();
            CustomsListClass<int> newList = new CustomsListClass<int>();
            string expected = "12346";
            string actual;
            // act
            testListOne.Add(1);
            testListOne.Add(3);
            testListTwo.Add(2);
            testListTwo.Add(4);
            testListTwo.Add(6);
            actual = newList.Zip(testListOne,testListTwo).ToString();
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_ListOneHasThreeItemsAndListTwoHas2Items_ResultShouldStopAtTheEndOfShortestList()
        {
            CustomsListClass<int> testListOne = new CustomsListClass<int>();
            CustomsListClass<int> testListTwo = new CustomsListClass<int>();
            CustomsListClass<int> newList = new CustomsListClass<int>();
            string expected = "12345";
            string actual;
            // act
            testListOne.Add(1);
            testListOne.Add(3);
            testListOne.Add(5);
            testListTwo.Add(2);
            testListTwo.Add(4);
            actual = newList.Zip(testListOne,testListTwo).ToString();
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
