using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_3.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void CompareTest_1()
        {
            string s1 = "рука", s2 = "курица";
            var message = Logic.Compare(s1, s2);
            Assert.AreEqual("Да Да Да Да ", message);
        }
        [TestMethod()]
        public void CompareTest_2()
        {
            string s1 = "клоп", s2 = "лес";
            var message = Logic.Compare(s1, s2);
            Assert.AreEqual("Нет Да Нет Нет ", message);

        }
        [TestMethod()]
        public void CompareTest_3()
        {
            string s1 = "огр", s2 = "река";
            var message = Logic.Compare(s1, s2);
            Assert.AreEqual("Нет Нет Да ", message);

        }
    }
}