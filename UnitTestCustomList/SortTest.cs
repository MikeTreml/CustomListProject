using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using CustomList;

namespace UnitTestCustomList
{
    [TestClass]
    public class SortTest
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

        [TestMethod]
        public void Sort_OneToNine_Numbers()
        {
            //arrange
            CustomList<string> startList = new CustomList<string>();
            CustomList<string> correctList = new CustomList<string>();
            CustomList<string> sortedList = new CustomList<string>();
            //act
            startList.Add(item1);
            startList.Add(item2);
            startList.Add(item3);
            startList.Add(item4);
            startList.Add(item5);
            startList.Add(item6);
            startList.Add(item7);
            startList.Add(item8);
            startList.Add(item9);

            correctList.Add(item1);
            correctList.Add(item2);
            correctList.Add(item3);
            correctList.Add(item4);
            correctList.Add(item5);
            correctList.Add(item6);
            correctList.Add(item7);
            correctList.Add(item8);
            correctList.Add(item9);

            sortedList = startList.Sort(startList);
            //assert
            Assert.AreEqual(correctList.ToString(), sortedList.ToString());
        }
        [TestMethod]
        public void Sort_NineToOne_Numbers()
        {
            //arrange
            CustomList<string> startList = new CustomList<string>();
            CustomList<string> correctList = new CustomList<string>();
            CustomList<string> sortedList = new CustomList<string>();
            //act
            startList.Add(item9);
            startList.Add(item8);
            startList.Add(item7);
            startList.Add(item6);
            startList.Add(item5);
            startList.Add(item4);
            startList.Add(item3);
            startList.Add(item2);
            startList.Add(item1);

            correctList.Add(item1);
            correctList.Add(item2);
            correctList.Add(item3);
            correctList.Add(item4);
            correctList.Add(item5);
            correctList.Add(item6);
            correctList.Add(item7);
            correctList.Add(item8);
            correctList.Add(item9);
            
            sortedList = startList.Sort(startList);
            //assert
            Assert.AreEqual(correctList.ToString(), sortedList.ToString());
        }


        [TestMethod]
        public void Sort_NineThroughOneMixed_Numbers()
        {
            //arrange
            CustomList<string> startList = new CustomList<string>();
            CustomList<string> correctList = new CustomList<string>();
            CustomList<string> sortedList = new CustomList<string>();
            //act
            startList.Add(item9);
            startList.Add(item1);
            startList.Add(item7);
            startList.Add(item2);
            startList.Add(item5);
            startList.Add(item4);
            startList.Add(item6);
            startList.Add(item3);
            startList.Add(item8);

            correctList.Add(item1);
            correctList.Add(item2);
            correctList.Add(item3);
            correctList.Add(item4);
            correctList.Add(item5);
            correctList.Add(item6);
            correctList.Add(item7);
            correctList.Add(item8);
            correctList.Add(item9);

            sortedList = startList.Sort(startList);
            //assert
            Assert.AreEqual(correctList.ToString(), sortedList.ToString());
        }
        [TestMethod]
        public void Sort_aTOi_Numbers()
        {
            //arrange
            CustomList<string> startList = new CustomList<string>();
            CustomList<string> correctList = new CustomList<string>();
            CustomList<string> sortedList = new CustomList<string>();
            //act
            startList.Add(item_a);
            startList.Add(item_b);
            startList.Add(item_c);
            startList.Add(item_d);
            startList.Add(item_e);
            startList.Add(item_f);
            startList.Add(item_g);
            startList.Add(item_h);
            startList.Add(item_i);

            correctList.Add(item_a);
            correctList.Add(item_b);
            correctList.Add(item_c);
            correctList.Add(item_d);
            correctList.Add(item_e);
            correctList.Add(item_f);
            correctList.Add(item_g);
            correctList.Add(item_h);
            correctList.Add(item_i);

            sortedList = startList.Sort(startList);
            //assert
            Assert.AreEqual(correctList.ToString(), sortedList.ToString());
        }
        [TestMethod]
        public void Sort_iTOa_Numbers()
        {
            //arrange
            CustomList<string> startList = new CustomList<string>();
            CustomList<string> correctList = new CustomList<string>();
            CustomList<string> sortedList = new CustomList<string>();
            //act
            startList.Add(item_i);
            startList.Add(item_h);
            startList.Add(item_g);
            startList.Add(item_f);
            startList.Add(item_e);
            startList.Add(item_d);
            startList.Add(item_c);
            startList.Add(item_b);
            startList.Add(item_a);

            correctList.Add(item_a);
            correctList.Add(item_b);
            correctList.Add(item_c);
            correctList.Add(item_d);
            correctList.Add(item_e);
            correctList.Add(item_f);
            correctList.Add(item_g);
            correctList.Add(item_h);
            correctList.Add(item_i);

            sortedList = startList.Sort(startList);
            //assert
            Assert.AreEqual(correctList.ToString(), sortedList.ToString());
        }
        [TestMethod]
        public void Sort_aTOiMixed_Numbers()
        {
            //arrange
            CustomList<string> startList = new CustomList<string>();
            CustomList<string> correctList = new CustomList<string>();
            CustomList<string> sortedList = new CustomList<string>();
            //act
            startList.Add(item_i);
            startList.Add(item_a);
            startList.Add(item_g);
            startList.Add(item_h);
            startList.Add(item_e);
            startList.Add(item_c);
            startList.Add(item_d);
            startList.Add(item_b);
            startList.Add(item_f);

            correctList.Add(item_a);
            correctList.Add(item_b);
            correctList.Add(item_c);
            correctList.Add(item_d);
            correctList.Add(item_e);
            correctList.Add(item_f);
            correctList.Add(item_g);
            correctList.Add(item_h);
            correctList.Add(item_i);

            sortedList = startList.Sort(startList);
            //assert
            Assert.AreEqual(correctList.ToString(), sortedList.ToString());
        }
        [TestMethod]
        public void Sort_LettersAndNumbersMixed()
        {
            //arrange
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
            //assert
            Assert.AreEqual(correctList.ToString(), sortedList.ToString());
        }
        [TestMethod]
        public void Sort_LettersAndNumbersMixed_UpperLowerNumbers()
        {
            //arrange
            CustomList<string> startList = new CustomList<string>();
            CustomList<string> correctList = new CustomList<string>();
            CustomList<string> sortedList = new CustomList<string>();
            //act
            startList.Add(item4);
            startList.Add(item_a.ToUpper());
            startList.Add(item3);
            startList.Add(item_h);
            startList.Add(item1);
            startList.Add(item_a);
            startList.Add(item_f.ToUpper());
            startList.Add(item2);
            startList.Add(item_f);

            correctList.Add(item1);
            correctList.Add(item2);
            correctList.Add(item3);
            correctList.Add(item4);
            correctList.Add(item_a.ToUpper());
            correctList.Add(item_a);
            correctList.Add(item_f.ToUpper());
            correctList.Add(item_f);
            correctList.Add(item_h);

            sortedList = startList.Sort(startList);
            //assert
            Assert.AreEqual(correctList.ToString(), sortedList.ToString());
        }
        [TestMethod]
        public void Sort_WiththeNumberTen_UpperLowerNumbers()
        {
            //arrange
            CustomList<string> startList = new CustomList<string>();
            CustomList<string> correctList = new CustomList<string>();
            CustomList<string> sortedList = new CustomList<string>();
            //act
            startList.Add(item4);
            startList.Add(item_a.ToUpper());
            startList.Add(item3);
            startList.Add(item_h);
            startList.Add(item1);
            startList.Add(item_a);
            startList.Add(item_f.ToUpper());
            startList.Add(item10);
            startList.Add(item_f);

            correctList.Add(item1);
            correctList.Add(item10);
            correctList.Add(item3);
            correctList.Add(item4);
            correctList.Add(item_a.ToUpper());
            correctList.Add(item_a);
            correctList.Add(item_f.ToUpper());
            correctList.Add(item_f);
            correctList.Add(item_h);

            sortedList = startList.Sort(startList);
            //assert
            Assert.AreEqual(correctList.ToString(), sortedList.ToString());
        }
        [TestMethod]
        public void Sort_WordsNumbersLetters()
        {
            //arrange
            CustomList<string> startList = new CustomList<string>();
            CustomList<string> correctList = new CustomList<string>();
            CustomList<string> sortedList = new CustomList<string>();
            //act
            startList.Add(item4);
            startList.Add(item_a.ToUpper());
            startList.Add(item3);
            startList.Add(item_h);
            startList.Add(item1);
            startList.Add(item_a);
            startList.Add(item_f.ToUpper());
            startList.Add(item_f);
            startList.Add(item_Quick);
            startList.Add(item_quick);
            startList.Add(item_lazy);
            startList.Add(item_brown);
            startList.Add(item_Brown);


            correctList.Add(item1);
            correctList.Add(item3);
            correctList.Add(item4);
            correctList.Add(item_a.ToUpper());
            correctList.Add(item_a);
            correctList.Add(item_Brown);
            correctList.Add(item_brown);
            correctList.Add(item_f.ToUpper());
            correctList.Add(item_f);
            correctList.Add(item_h);
            correctList.Add(item_lazy);
            correctList.Add(item_Quick);
            correctList.Add(item_quick);

            sortedList = startList.Sort(startList);
            //assert
            Assert.AreEqual(correctList.ToString(), sortedList.ToString());
        }
        [TestMethod]
        public void Sort_double()
        {
            //arrange
            CustomList<double> startList = new CustomList<double>();
            CustomList<double> correctList = new CustomList<double>();
            CustomList<double> sortedList = new CustomList<double>();
            //act
            startList.Add(5.1);
            startList.Add(6.4);
            startList.Add(1.23);
            startList.Add(1.99999);
            startList.Add(15);
            startList.Add(1999);
            startList.Add(55);
            startList.Add(50);
            startList.Add(24);

            correctList.Add(1.23);
            correctList.Add(1.99999);
            correctList.Add(5.1);
            correctList.Add(6.4);
            correctList.Add(15);
            correctList.Add(24);
            correctList.Add(50);
            correctList.Add(55);
            correctList.Add(1999);

            sortedList = startList.Sort(startList);
            //assert
            Assert.AreEqual(correctList.ToString(), sortedList.ToString());
        }
        [TestMethod]
        public void Sort_int()
        {
            //arrange
            CustomList<int> startList = new CustomList<int>();
            CustomList<int> correctList = new CustomList<int>();
            CustomList<int> sortedList = new CustomList<int>();
            //act
            startList.Add(5);
            startList.Add(6);
            startList.Add(1);
            startList.Add(900);
            startList.Add(15);
            startList.Add(1999);
            startList.Add(55);
            startList.Add(50);
            startList.Add(24);

            correctList.Add(1);
            correctList.Add(5);
            correctList.Add(6);
            correctList.Add(15);
            correctList.Add(24);
            correctList.Add(50);
            correctList.Add(55);
            correctList.Add(900);
            correctList.Add(1999);

            sortedList = startList.Sort(startList);
            //assert
            Assert.AreEqual(correctList.ToString(), sortedList.ToString());
        }
    }
}
