using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Практическая_работа_4_Филин_Березнев;
using Практическая_работа_4_Филин_Березнев.pages;

namespace TestingProject
{
    [TestClass]
    public class InvalidInputTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            it_page1 page = new it_page1();
            Assert.AreEqual(page.a(), 0);
            
        }
    }
}
