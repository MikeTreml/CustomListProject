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
            char[] a = {'a','b','c','A','B','C','z','Z','1','2','3','0'};

            foreach (var item in a)
            {
                Console.WriteLine(Char.IsLower(item) + "  "+ (int)(item));
            }
            Console.ReadLine();

          


        }
        //public CustomList<int> y(CustomList<int> firstList, CustomList<int> secondList)
        //{
        //    int sizeCount = 0;
        //    CustomList<int> results = firstList;
        //    for (int i = 0; i < firstList.Count; i++)
        //    {
        //        for (int j = 0; j < secondList.Count; j++)
        //        {
        //            if (Equals(firstList[i], secondList[j]))
        //            {
        //                results.Remove(secondList[j]);
        //            }
        //        }
        //    }
        //    Console.WriteLine(results);
        //}
    }
}
