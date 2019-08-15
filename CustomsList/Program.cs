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

        }

    }
}
