﻿using Tyuiu.chernyhim.Sprint0.Task2.V0.Lib;

namespace Tyuiu.chernyhim.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "John";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Hello..., John!", res);
        }
    }
}
