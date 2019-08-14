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
            CustomsListClass<int> testList = new CustomsListClass<int>();

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(2);

            testList.Remove(2);
        }
    }
}
