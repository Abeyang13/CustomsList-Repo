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
                try
                {
                    return items[index];
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e);
                    return default(T);
                }
            }
            set
            {
                try
                {
                    items[index] = value;
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e);
                }
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
            if (count == capacity)
            {
                ArrayResize();
            }
            items[count] = item;
            count++;
        }
        private void ArrayResize()
        {
            capacity *= 2;
            T[] temporaryArray = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                temporaryArray[i] = items[i];
            }
            items = temporaryArray;
        }
        public void Remove(T item)
        {
            bool itemFound = false;
            for (int i = 0; i < count; i++)
            {
                if (!itemFound)
                {
                    if (item.Equals(items[i]))
                    {
                        items[i] = items[i + 1];
                        itemFound = true;
                        count--;
                    }
                }
                else
                {
                    items[i] = items[i + 1];
                }
            }
        }
        public override string ToString()
        {
            string list = "";
            for (int i = 0; i < count; i++)
            {
                list += items[i].ToString();
            }
            return list;
        }
        public static CustomsListClass<T> operator+(CustomsListClass<T>listOne,CustomsListClass<T> listTwo)
        {
            CustomsListClass<T> result = new CustomsListClass<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                result.Add(listOne[i]);
            }
            for (int j = 0; j < listTwo.count; j++)
            {
                result.Add(listTwo[j]);
            }
            return result;
        }
        public static CustomsListClass<T> operator -(CustomsListClass<T> listOne, CustomsListClass<T> listTwo)
        {
            CustomsListClass<T> result = listOne + new CustomsListClass<T>();
            for (int i = 0; i < listTwo.count; i++)
            {
                result.Remove(listTwo[i]);
            }
            return result;
        }
    }
}