# CustomsList-Repo
 public static CustomsListClass<T> operator -(CustomsListClass<T> listOne, CustomsListClass<T> listTwo)
        {
            CustomsListClass<T> result = listOne + new CustomsListClass<T>();
            for (int i = 0; i < listTwo.count; i++)
            {
                result.Remove(listTwo[i]);
            }
            return result;
        }
                                              
// The parameters I used for my overload - operator is CustomsListClass listOne and ListTwo which are instatiated when you make your lists
// Within the method to find out how to see if there is a certain value that is found in each list.  I instatiated a 3rd list and it consisted of the original listOne and new CustomsListClass.  
// By doing this I don't destroy my original listOne.  
// The main part of the method itself is ran through a for loop of listTwo.  I also used my Remove() method for this method.  
// Basically the for loop takes listTwo at value i which is used to compare in my Remove method.  
// In the Remove() method.  If the listTwo at value i equals any of result value.  Result list will remove the first instance of that value within it's list.
// Then I return the result list that I had created minus the value that was removed.
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
 // actual = "35"
