using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestCustomList
{
    class AddTest
    {

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

        public void Add_AddInt_ToPostionInList()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int addedItem = 15;
            int addedItem1 = 1;

            //act
            customList.Add(addedItem);
            customList.Add(addedItem);
            customList.Add(addedItem);
            customList.Add(addedItem);
            customList.Add(2,addedItem1);


            //assert
            Assert.AreEqual(customList[2], addedItem1);
        }
        
    }
}
