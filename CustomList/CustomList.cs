﻿using System;
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
                if (i < 0 || i >= count) { throw new ArgumentOutOfRangeException(); }
                else { return myItemArray[i]; }

            }
            set
            {
                //if (i < 0 || i >= count) { throw new ArgumentOutOfRangeException(); }
                //else { myItemArray[i] = value; }
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
            string saveString=""; 
            for (int i = 0; i < count; i++)
            {
                //if (string.IsNullOrEmpty(saveString))
                //    saveString += myItemArray[i].ToString();
                //else
                    saveString += string.Format("{0}", myItemArray[i]);
            }
            
            return saveString;
            
        }
        public string Zip(CustomList<T> t)
        {
            return "";
        }
        private void RecustructList()
        {

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
            CustomList<T> results = new CustomList<T>();
            for (int i = 0; i < firstList.count; i++)
            {
                for (int j = 0; j < secondList.count; j++)
                {
                    if (Comparer.Equals(firstList[i], secondList[j]))
                    {
                        break;
                    }
                    else if (j == secondList.count - 1)
                    {
                        results.Add(firstList[i]);
                    }
                }
            }
            return results;
        }
        //public IEnumerator<T> GetEnumerator()
        //{
        //    for (int i = 0; i < Count; i++)
        //    {
        //        yield return arrayItem[i];
        //    }
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}
    }
}
