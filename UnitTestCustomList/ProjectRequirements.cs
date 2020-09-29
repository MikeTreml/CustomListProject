using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestCustomList
{
    class ProjectRequirements
    {
        public void List_OverLoad_Plus_ConCatTwoList()
        {
            //arrange
            CustomList<int> customList1 = new CustomList<int>() {1,3,5 };
            CustomList<int> customList2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> result = new CustomList<int>();
            CustomList<int> correctAnswer = new CustomList<int>() { 1, 3, 5 , 2, 4, 6 };

            //act
            result = customList1 + customList2;

            //assert
            Assert.AreEqual(result, correctAnswer);
        }
        public void List_OverLoad_Minus_RemoveItemsContainsInSecondList()
        {
            //arrange
            CustomList<int> customList1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> customList2 = new CustomList<int>() { 2, 1, 6 };
            CustomList<int> result = new CustomList<int>();
            CustomList<int> correctAnswer = new CustomList<int>() { 3, 5};

            //act
            result = customList1 - customList2;

            //assert
            Assert.AreEqual(result, correctAnswer);
        }
        public void List_OverLoad_ZipperTwoList()
        {
            //arrange
            CustomList<int> customList1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> customList2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> result = new CustomList<int>();
            CustomList<int> correctAnswer = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };

            //act
            customList1.Zip(customList2);

            //assert
            Assert.AreEqual(result, correctAnswer);
        }
    }
}
