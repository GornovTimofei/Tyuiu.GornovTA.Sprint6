using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GornovTA.Sprint6.Task1.V1.Lib;

namespace Tyuiu.GornovTA.Sprint6.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = -11.22;
            valueWaitArray[1] = -8.65;
            valueWaitArray[2] = -4.76;
            valueWaitArray[3] = -6.47;
            valueWaitArray[4] = -2.98;
            valueWaitArray[5] = 1.00;
            valueWaitArray[6] = 1.82;
            valueWaitArray[7] = 3.55;
            valueWaitArray[8] = 6.99;
            valueWaitArray[9] = 7.74;
            valueWaitArray[10] = 9.03;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
