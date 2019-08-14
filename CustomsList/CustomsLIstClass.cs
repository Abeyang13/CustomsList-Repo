using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsList
{
    public class CustomsListClass<T>
    {
        private T[] items;
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public CustomsListClass()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if(count == capacity)
            {
                ArrayResize();
            }
            items[count] = item;
            count++;
        }
        public void ArrayResize()
        {
            
            capacity *= 2;
            T[]tempArray = new T[capacity];
            for(int i = 0; i < Count; i++)
            {
                tempArray[i] = items[i];
            }
            items = tempArray;
        }

    }
}
