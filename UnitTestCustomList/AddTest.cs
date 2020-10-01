using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using CustomList;


namespace UnitTestCustomList
{
    [TestClass]
    public class AddTest
    {

        // check variables
        [TestMethod]
        public void Add_AddInt()
        {

            //arrange
            CustomList<int> customList = new CustomList<int>();
            int item = 15;
            //act
            customList.Add(item);

            //assert
            Assert.AreEqual(customList[0], item);
        }
        [TestMethod]
        public void Add_AddString()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string item = "HelloWorld";
            //act
            customList.Add(item);

            //assert
            Assert.AreEqual(customList[0], item);
        }
        [TestMethod]
        public void Add_AddBool()
        {
            //arrange
            CustomList<bool> customList = new CustomList<bool>();
            bool item1 = true;
            bool item2 = false;
            //act
            customList.Add(item1);
            customList.Add(item2);

            //assert
            Assert.AreEqual(customList[0], item1);
            Assert.AreEqual(customList[1], item2);
        }
        [TestMethod]
        public void Add_AddChar()
        {
            //arrange
            CustomList<char> customList = new CustomList<char>();
            char item = 'n';
            //act
            customList.Add(item);

            //assert
            Assert.AreEqual(customList[0], item);
        }
        [TestMethod]
        public void Add_AddDouble()
        {
            //arrange
            CustomList<double> customList = new CustomList<double>();
            double item = 15.5644;
            //act
            customList.Add(item);

            //assert
            Assert.AreEqual(customList[0], item);
        }
        [TestMethod]
        public void Add_AddArray()
        {
            //arrange
            CustomList<int[]> customList = new CustomList<int[]>();
            int[] item = { 1, 2, 3, 3, 4, 5 };
            //act
            customList.Add(item);

            //assert
            Assert.AreEqual(customList[0], item);
        }

        //check count
        [TestMethod]
        public void Add_FifthItem_CheckCount()
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


            //assert
            Assert.AreEqual(customList.Count, 5);
        }

        //Capacity
        [TestMethod]
        public void Add_OneItem_CheckCapacity()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int item = 15;

            //act
            customList.Add(item);

            //assert
            Assert.AreEqual(customList.Capacity, 4);
        }
        [TestMethod]
        public void Add_NinethItem_CheckCapacity()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
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

            //assert
            Assert.AreEqual(customList.Capacity, 16);
        }

        //Check array after recreation and move to new array
        [TestMethod]
        public void Add_FifthItem_CheckRecreatedArray()
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

            //assert
            Assert.AreEqual(customList[3], item4);
        }


        //check data being added to the end of the list
        [TestMethod]
        public void Add_AddToEnd_CheckIndex()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();

            int item = 15;
            int item1 = 1;

            //act
            customList.Add(item);
            customList.Add(item1);


            //assert
            Assert.AreEqual(customList[1], item1);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        
        public void Add_AddToEnd_CheckOutOfRangeException()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();

            int item1 = 1;

            //act
            customList.Add(item1);
            customList.Add(item1);


            //assert
            Assert.Fail(customList[2].ToString());
        }



    }
}
