﻿using Tyuiu.GairabekovMR.Sprint4.Task1.V8.Lib;

namespace Tyuiu.GairabekovMR.Sprint4.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCal()
        {
            DataService ds = new DataService();
            int[] numsArray = { 8, 4, 7, 7, 3, 8, 8, 5, 8, 7, 2, 4 };
            int res = ds.Calculate(numsArray);
            int wait = 29;
            Assert.AreEqual(wait, res);
        }
    }
}