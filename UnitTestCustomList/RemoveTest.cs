using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestCustomList
{
    class RemoveTest
    {
        // check variables
        [TestMethod]
        public void Remove_RemoveInt()
        {

            //arrange
            CustomList<int> customList = new CustomList<int>();
            int item1 = 1;
            int item2 = 2;
            int item3 = 3;
            string Answer = "13";
            //act
            customList.Add(item1);
            customList.Add(item2);
            customList.Add(item3);
            customList.Remove(item2);

            //assert
            Assert.AreEqual(customList.ToString(), Answer);
        }
        [TestMethod]
        public void Remove_RemoveString()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string item = "HelloWorld";
            //act
            customList.Add(item);
            customList.Add(item);
            customList.Remove(item);

            //assert
            Assert.AreEqual(customList.ToString(), item);
        }
        [TestMethod]
        public void Remove_RemoveBool()
        {
            //arrange
            CustomList<bool> customList = new CustomList<bool>();
            bool item1 = true;
            bool item2 = false;
            //act
            customList.Add(item1);
            customList.Add(item2);
            customList.Add(item1);
            customList.Remove(item2);


            //assert

            Assert.AreEqual(customList[1], item1);
        }
        [TestMethod]
        public void Remove_RemoveChar()
        {
            //arrange
            CustomList<char> customList = new CustomList<char>() ;
            char item1 = 'n';
            char item2 = 'A';
            char item3 = 'a';
            char item4 = 'B';
            string answer = "nAB";
            //act
            customList.Add(item1);
            customList.Add(item2);
            customList.Add(item3);
            customList.Add(item4);
            customList.Remove(item3);

            //assert
            Assert.AreEqual(customList.ToString(), answer);
        }
        [TestMethod]
        public void Remove_RemoveDouble()
        {
            //arrange
            CustomList<double> customList = new CustomList<double>();
            double item1 = 155.5;
            double item2 = 15.55;
            double item3 = 1.555;
            //act
            customList.Add(item1);
            customList.Add(item2);
            customList.Add(item3);
            customList.Remove(item1);

            //assert
            Assert.AreEqual(customList[0], item2);
        }
        [TestMethod]
        public void Remove_RemoveArray()
        {
            //arrange
            CustomList<int[]> customList = new CustomList<int[]>();
            int[] item1 = { 1, 2, 3, 3, 4, 5 };
            int[] item2 = { 2, 2, 2, 2, 2, 2 };
            int[] item3 = { 3, 3, 3, 3, 3, 3 };
            int[] item4 = { 4, 4, 4, 4, 4, 4 };
            //act
            customList.Remove(item2);

            //assert
            customList.Add(item1);
            customList.Add(item2);
            customList.Add(item3);
            customList.Add(item4);
            Assert.AreEqual(customList[1], item3);
        }

        //check count
        [TestMethod]
        public void Remove_FifthItem_CheckCount()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
 
            int item1 = 1;
            int item2 = 2;
            int item5 = 5;

            //act
            customList.Add(item1);
            customList.Add(item2);
            customList.Add(item2);
            customList.Add(item2);
            customList.Add(item5);
            customList.Remove(item2);
            customList.Remove(item2);

            //assert
            Assert.AreEqual(customList.Count, 3);
        }

        //Capacity
        [TestMethod]
        public void Remove_OneItem_CheckCapacity()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int item1 = 15;

            //act
            customList.Add(item1);
            customList.Remove(item1);

            //assert
            Assert.AreEqual(customList.Capacity, 4);
        }
        [TestMethod]
        public void Remove_FifthItem_CheckCapacity()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>() ;
            int item1 = 1;
            int item2 = 2;
            int item3 = 3;
            int item4 = 4;
            int item5 = 5;
            int item6 = 6;
            int item7 = 7;
            int item8 = 8;
            int item9 = 9;

            //act
            customList.Add(item1);
            customList.Add(item2);
            customList.Add(item3);
            customList.Add(item4);
            customList.Add(item5);
            customList.Add(item6);
            customList.Add(item7);
            customList.Add(item8);
            customList.Add(item9);
            customList.Remove(item5);

            //assert
            Assert.AreEqual(customList.Capacity, 18);
        }

        //Check array after recreation and move to new array
        [TestMethod]
        public void Remove_SecondItem_CheckRecreatedArray()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4 };
            int item1 = 1;
            int item2 = 2;
            int item3 = 3;
            int item4 = 4;
            int item5 = 5;

            //act
            customList.Add(item1);
            customList.Add(item2);
            customList.Add(item3);
            customList.Add(item4);
            customList.Add(item5);
            customList.Remove(item2);

            //assert
            Assert.AreEqual(customList[1], item3);
        }


        //check data being remove to the end of the list
        [TestMethod]
        public void Remove_RemoveEnd_CheckIndex()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int item1 = 1;
            int item2 = 2;
            int item3 = 3;
            int item4 = 4;
            int item5 = 5;
            //act
            customList.Add(item1);
            customList.Add(item2);
            customList.Add(item3);
            customList.Add(item4);
            customList.Add(item5);
            customList.Remove(item5);


            //assert
            Assert.AreEqual(customList.count, 4);
        }
        public void RemoveInt_ReturnBool_failed()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int item1 = 1;
            int item2 = 2;
            int item3 = 3;
            int item4 = 100;
            
            //act
            customList.Add(item1);
            customList.Add(item2);
            customList.Add(item3);
            
            customList.Remove(item4);

            //assert
            Assert.AreEqual(customList.Remove(item4), false);
        }
        public void RemoveInt_Count_DoesntDecrease()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int item1 = 1;
            int item2 = 2;
            int item3 = 3;
            int item4 = 100;

            //act
            customList.Add(item1);
            customList.Add(item2);
            customList.Add(item3);
            customList.Remove(item4);

            //assert
            Assert.AreEqual(customList.count, 3);
        }
        public void Remove_ReturnBool_Success()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int item1 = 1;
            int item2 = 2;
            int item3 = 3;
            

            //act
            customList.Add(item1);
            customList.Add(item2);
            customList.Add(item3);

            customList.Remove(item3);

            //assert
            Assert.AreEqual(customList.Remove(item3), true);
        }
    }
        // [TestMethod]
        //[ExpectedException(typeof(IndexOutOfRangeException))]
        //public void Remove_RemoveToEnd_CheckOutOfRangeException()
        //{
        //    //arrange
        //    CustomList<int> customList = new CustomList<int>();
        //    int item1 = 1;
        //    int item2 = 2;
        //    int item3 = 3;
        //    int item4 = 4;
        //    int item5 = 5;


        //    //act
        //    customList.Add(item1);
        //    customList.Add(item2);
        //    customList.Add(item3);
        //    customList.Add(item4);
        //    customList.Add(item5);
        //    customList.Remove(item5);


        //    //assert
        //    Assert.Fail(customList[2]);
    }
    }
}
}
