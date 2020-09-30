using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        public int count;
        public int capacity;
        private T[] arrayItems;

        public CustomList()
        {
            count = 0;
            capacity = 4;

            arrayItems = new T[capacity];
        }

        public void Add(T t)
        {
            ///add value
            //if capacity <= count{capacity *= 2}
                // recustruct list
        }
        public void Remove(T t)
        {
            ///remove value
            
            // recustruct list
        }
        public string ToString()
        {
            ///remove value


            // recustruct list

            return "";
        }
        private void RecustructList()
        { }

    }
}
