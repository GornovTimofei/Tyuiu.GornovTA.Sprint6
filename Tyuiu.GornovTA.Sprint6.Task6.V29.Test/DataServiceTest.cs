using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.GornovTA.Sprint6.Task6.V29.Lib;

namespace Tyuiu.GornovTA.Sprint6.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint\InPutFileTask6V29.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = " gMxrJi rvzAEwiXzIsLRa xakZKciG";
            Assert.AreEqual(wait, res);
        }
    }
}
