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

                int item1 = 1;

                //act
                customList.Add(item1);
                customList.Add(item1);


                //assert
               // customList[2].ToString();
            
        }
    }
}
