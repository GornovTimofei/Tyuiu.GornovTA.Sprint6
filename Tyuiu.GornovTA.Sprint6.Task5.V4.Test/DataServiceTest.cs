using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.GornovTA.Sprint6.Task5.V4.Lib;

namespace Tyuiu.GornovTA.Sprint6.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.GornovTA.Sprint6\Tyuiu.GornovTA.Sprint6.Task5.V4\bin\Debug\InPutFileTask5V4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
