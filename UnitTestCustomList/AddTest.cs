using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestCustomList
{
    class AddTest
    {
        // move value to temp array then distroy T{} before moving back to new increased size array

        // check variables
        public void Add_AddInt()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int addedItem = 15;
            //act
            customList.Add(addedItem);

            //assert
            Assert.AreEqual(customList[0], addedItem);
        }
        public void Add_AddString()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string addedItem = "HelloWorld";
            //act
            customList.Add(addedItem);

            //assert
            Assert.AreEqual(customList[0], addedItem);
        }
        public void Add_AddBool()
        {
            //arrange
            CustomList<bool> customList = new CustomList<bool>();
            bool addedItem1 = true;
            bool addedItem2 = false;
            //act
            customList.Add(addedItem1);
            customList.Add(addedItem1);

            //assert
            Assert.AreEqual(customList[0], addedItem1);
            Assert.AreEqual(customList[1], addedItem2);
        }
        public void Add_AddChar()
        {
            //arrange
            CustomList<char> customList = new CustomList<char>();
            char addedItem = 'D';
            //act
            customList.Add(addedItem);

            //assert
            Assert.AreEqual(customList[0], addedItem);
        }
        public void Add_AddDouble()
        {
            //arrange
            CustomList<double> customList = new CustomList<double>();
            double addedItem = 15.5644;
            //act
            customList.Add(addedItem);

            //assert
            Assert.AreEqual(customList[0], addedItem);
        }
        public void Add_AddArray()
        {
            //arrange
            CustomList<int[]> customList = new CustomList<int[]>();
            int[] addedItem = {1,2,3,3,4,5 };
            //act
            customList.Add(addedItem);

            //assert
            Assert.AreEqual(customList[0], addedItem);
        }

        //check count
        public void Add_FifthItem_CheckCount()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4 };
            int addedItem = 5;

            //act
            customList.Add(addedItem);

            //assert
            Assert.AreEqual(customList.Count, 4);
        }

        //Capacity

        public void Add_OneItem_CheckCapacity()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int addedItem = 15;

            //act
            customList.Add(addedItem);

            //assert
            Assert.AreEqual(customList.Capacity, 4);
        }
        public void Add_NineItems_CheckCapacity()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            int addedItem = 9;

            //act
            customList.Add(addedItem);

            //assert
            Assert.AreEqual(customList.Capacity, 18);
        }

        //Check array after recreation and move to new array

        public void Add_FifthItem_CheckRecreatedArray()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>() {1,2,3,4 };
            int addedItem = 15;

            //act
            customList.Add(addedItem);

            //assert
            Assert.AreEqual(customList[4], addedItem);
        }
       
       
        //check data being added to the end of the list
        public void Add_AddToEnd_CheckPostion()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();

            int addedItem = 15;
            int addedItem1 = 1;

            //act
            customList.Add(addedItem);
            customList.Add(addedItem1);


            //assert
            Assert.AreEqual(customList[1], addedItem1);
        }
    

    }
}
