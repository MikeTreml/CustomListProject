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
            string item1 = "1";
            string item2 = "2";
            string item3 = "3";
            string item4 = "4";
            string item5 = "5";
            string item6 = "6";
            string item7 = "7";
            string item8 = "8";
            string item9 = "9";
            string item10 = "10";
            string item_a = "a";
            string item_b = "b";
            string item_c = "c";
            string item_d = "d";
            string item_e = "e";
            string item_f = "f";
            string item_g = "g";
            string item_h = "h";
            string item_i = "i";
            string item_QUICK = "QUICK";
            string item_Quick = "Quick";
            string item_quick = "quick";
            string item_brown = "brown";
            string item_Brown = "Brown";
            string item_lazy = "lazy";
            CustomList<string> startList = new CustomList<string>();
            CustomList<string> correctList = new CustomList<string>();
            CustomList<string> sortedList = new CustomList<string>();
            //act
            startList.Add(item4);
            startList.Add(item_a);
            startList.Add(item3);
            startList.Add(item_h);
            startList.Add(item1);
            startList.Add(item_c);
            startList.Add(item_d);
            startList.Add(item2);
            startList.Add(item_f);

            correctList.Add(item1);
            correctList.Add(item2);
            correctList.Add(item3);
            correctList.Add(item4);
            correctList.Add(item_a);
            correctList.Add(item_c);
            correctList.Add(item_d);
            correctList.Add(item_f);
            correctList.Add(item_h);

            sortedList = startList.Sort(startList);
            Console.WriteLine(Equals(sortedList, correctList));
            Console.ReadLine();
            //assert

            //Console.ReadLine();
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
