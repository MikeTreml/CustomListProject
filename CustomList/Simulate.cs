using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Simulate
    {
        public Simulate()
        {
                
        }

        public void RunTest()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            string expected = "123";
            //act
            string result = customList.ToString();

           
            ////arrange
            //CustomList<int> customList = new CustomList<int>();
            //customList.Add(1);
            //customList.Remove(1);

            //string expected = "";
            ////act
            //string result = customList.ToString();

        }
    }
}
