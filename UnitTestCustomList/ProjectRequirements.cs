using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestCustomList
{ 
    [TestClass]
    public class ProjectRequirements
    {
        [TestMethod]
        public static void List_OverLoad_Plus_ConCatTwoList()
        {
            //arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            CustomList<int> correctAnswer = new CustomList<int>();
            int item1 = 1;
            int item2 = 2;
            int item3 = 3;
            int item4 = 4;
            int item5 = 5;
            int item6 = 6;
            //act
            customList1.Add(item1);
            customList2.Add(item2);
            customList1.Add(item3);
            customList2.Add(item4);
            customList1.Add(item5);
            customList2.Add(item6);
            correctAnswer.Add(item1);
            correctAnswer.Add(item3);
            correctAnswer.Add(item5);
            correctAnswer.Add(item2);
            correctAnswer.Add(item4);
            correctAnswer.Add(item6);
            result = customList1 + customList2;

            //assert
            Assert.AreEqual(result, correctAnswer);
        }
        [TestMethod]
        public static void List_OverLoad_Minus_RemoveItemsContainsInSecondList()
        {
            //arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            CustomList<int> correctAnswer = new CustomList<int>();
            int item1 = 1;
            int item2 = 2;
            int item3 = 3;
            
            int item5 = 5;
            int item6 = 6;
            //act
            customList1.Add(item1);
            customList2.Add(item2);
            customList1.Add(item3);
            customList2.Add(item1);
            customList1.Add(item5);
            customList2.Add(item6);
            correctAnswer.Add(item3);
            correctAnswer.Add(item5);

            result = customList1 - customList2;
            
            //assert
            Assert.AreEqual(result, correctAnswer);
        }
        [TestMethod]
        public static void List_OverLoad_ZipperTwoList()
        {
            //arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            CustomList<int> correctAnswer = new CustomList<int>();
            int item1 = 1;
            int item2 = 2;
            int item3 = 3;
            int item4 = 4;
            int item5 = 5;
            int item6 = 6;
            //act
            customList1.Add(item1);
            customList1.Add(item3);
            customList1.Add(item5);

            customList2.Add(item2);
            customList2.Add(item4);
            customList2.Add(item6);

            correctAnswer.Add(item1);
            correctAnswer.Add(item2);
            correctAnswer.Add(item3);
            correctAnswer.Add(item4);
            correctAnswer.Add(item5);
            correctAnswer.Add(item6);
            //result = customList1.Zip(customList2);
            result = customList1.Zip(customList2);
            //assert
            Assert.AreEqual(result, correctAnswer);
        }
    }
}
