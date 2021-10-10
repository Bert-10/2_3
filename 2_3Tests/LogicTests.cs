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
        //Тест, когда есть вхождения всех букв
        [TestMethod()]
        public void CompareTest_1()
        {
            string s1 = "рука", s2 = "курица";
            var message = Logic.Compare(s1, s2);
            Assert.AreEqual("Да Да Да Да ", message);
        }
        //Тест, когда нет вхождения всех букв
        //Также присутсвуют повторяющиеся буквы
        [TestMethod()]
        public void CompareTest_2()
        {
            string s1 = "клопп", s2 = "лес";
            var message = Logic.Compare(s1, s2);
            Assert.AreEqual("Нет Да Нет Нет ", message);

        }
        //Тест, когда нет вхлждений вообще
        [TestMethod()]
        public void CompareTest_3()
        {
            string s1 = "огт", s2 = "рак";
            var message = Logic.Compare(s1, s2);
            Assert.AreEqual("Нет Нет Нет ", message);

        }
    }
}