using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsList
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomsListClass<int> testListOne = new CustomsListClass<int>();
            CustomsListClass<int> testListTwo = new CustomsListClass<int>();
            string expected = "35";
            string actual;
            testListOne.Add(1);
            testListOne.Add(3);
            testListOne.Add(5);
            testListTwo.Add(2);
            testListTwo.Add(1);
            testListTwo.Add(6);
            actual = (testListOne - testListTwo).ToString();


        }

    }
}
