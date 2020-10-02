using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            one.Add(1);
            one.Add(3);
            one.Add(5);

            two.Add(2);
            two.Add(1);
            two.Add(6);


            result = one - two;
            Console.WriteLine(result[0] + " , " + result[1]);
            // 3 , 5
        }
       
    }
}
