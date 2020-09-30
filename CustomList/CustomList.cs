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

        public void Add()
        {
            ///add value
            //if capacity <= count{capacity *= 2}
                // recustruct list
        }
        public void Remove()
        {
            ///remove value
            
            // recustruct list
        }
        public void ToString()
        {
            ///remove value

            // recustruct list
        }
        private void RecustructList()
        { }

    }
}
