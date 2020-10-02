using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private T[] myItemArray;
        protected int capacity;
        protected int count;
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public int Count { get { return count; } }
        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= count) { throw new IndexOutOfRangeException(); }
                else { return myItemArray[i]; }
            }
            set
            {
                myItemArray[i] = value;
            }
        }
        public CustomList()
        {
            count = 0;
            capacity = 4;
            myItemArray = new T[capacity];
        }

        public void Add(T addItem)
        {
            if (count == capacity)
            {
                IncreaseArrayCapacity();
            }
            myItemArray[count] = addItem;
            count++;
        }
        public void IncreaseArrayCapacity()
        {
            capacity *= 2;
            T[] newSizeArray = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                newSizeArray[i] = myItemArray[i];
            }
            myItemArray = newSizeArray;
        }
        public bool Remove(T itemToRemove)
        {
            bool compare = false;
            T[] saveArray = new T[capacity];
            int saveArrayPoint = 0;
            for (int i = 0; i < count; i++)
            {
                // this will only trigger for one remove
                if (Equals(myItemArray[i], itemToRemove) && compare == false)
                {
                    compare = true;
                }
                else
                {
                    saveArray[saveArrayPoint] = myItemArray[i];
                    saveArrayPoint++;
                }
            }
            if (compare) { count--; }
            myItemArray = saveArray;
            return compare;
        }
        public override string ToString()
        {
            string saveString = "";
            for (int i = 0; i < count; i++)
            {
                saveString += string.Format("{0}", myItemArray[i]);
            }
            return saveString;

        }
        public CustomList<T> Zip(CustomList<T> secondList)
        {
            CustomList<T> results = new CustomList<T>();
            for (int i = 0; i < Count; i++)
            {
                results.Add(myItemArray[i]);
                results.Add(secondList[i]);
            }

            return results;

        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> results = new CustomList<T>();
            for (int i = 0; i < firstList.count; i++)
            {
                results.Add(firstList[i]);
            }
            for (int j = 0; j < secondList.count; j++)
            {
                results.Add(secondList[j]);
            }
            return results;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> results = firstList;
            for (int i = 0; i < firstList.count; i++)
            {
                for (int j = 0; j < secondList.count; j++)
                {
                    if (Equals(firstList[i], secondList[j]))
                    {
                        results.Remove(secondList[j]);
                    }
                }
            }
            return results;
        }
        //Sort string handles the fist char in the string and sort by that. anything with a number will be first. Then letters. Capitol letters get priority of lowercase. 
        //The down size is that it doesn't sort by the second char if a char is the same for the first. 
        public CustomList<string> Sort(CustomList<string> startList)
        {

            CustomList<string> result = new CustomList<string>();

            while (startList.Count > 0)
            {
                int minIndex = 0;
                double min = 200;
                double buffer;
                for (int i = 0; i < startList.Count; i++)
                {
                    if (Char.IsLower(startList[i][0]))
                    {
                        buffer = (int)(startList[i][0]) - 31.5;
                    }
                    else
                    {
                        buffer = (int)(startList[i][0]);
                    }
                    if (buffer < min)
                    {
                        min = buffer;
                        minIndex = i;
                    }
                }
                result.Add(startList[minIndex]);
                startList.Remove(startList[minIndex]);
            }
            return result;
        }
        //sorts char in order number through letters. Uppercase is before Lowercase.
        public CustomList<char> Sort(CustomList<char> startList)
        {

            CustomList<char> result = new CustomList<char>();

            while (startList.Count > 0)
            {
                int minIndex = 0;
                double min = 200;
                double buffer;
                for (int i = 0; i < startList.Count; i++)
                {
                    if (Char.IsLower(startList[i]))
                    {
                        buffer = (int)(startList[i]) - 31.5;
                    }
                    else
                    {
                        buffer = (int)(startList[i]);
                    }
                    if (buffer < min)
                    {
                        min = buffer;
                        minIndex = i;
                    }
                }
                result.Add(startList[minIndex]);
                startList.Remove(startList[minIndex]);
            }
            return result;
        }
        //sort doubles from smallest to largest (bubble sort)
        public CustomList<double> Sort(CustomList<double> startList)
        {
            double buffer = 0;

            for (int i = 0; i < startList.Count; i++)
            {
                for (int j = i; j < startList.Count; j++)
                {
                    if (startList[i] > startList[j])
                    {
                        buffer = startList[i];
                        startList[i] = startList[j];
                        startList[j] = buffer;
                    }
                }
            }
            return startList;
        }
        //sort ints from smallest to largest (bubble sort)
        public CustomList<int> Sort(CustomList<int> startList)
        {

            int buffer = 0;

            for (int i = 0; i < startList.Count; i++)
            {
                for (int j = i; j < startList.Count; j++)
                {
                    if (startList[i] > startList[j])
                    {
                        buffer = startList[i];
                        startList[i] = startList[j];
                        startList[j] = buffer;
                    }
                }
            }
            return startList;
        }

    }
}
