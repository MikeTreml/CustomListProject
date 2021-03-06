﻿using System;
using System.Collections.Generic;
using System.Text;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCustomList
{
    [TestClass]
    public class ToStringTest
    {

        [TestMethod]
        public void Convert_IntListToString()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            string expected = "123";
            //act
            string result = customList.ToString();

            //assert
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void EmptyStringCheck()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Remove(1);

            string expected = "";
            //act
            string result = customList.ToString();

            //assert
            Assert.AreEqual(result, expected);
        }
    }
}
