using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Практическая_работа_4_Филин_Березнев;
using Практическая_работа_4_Филин_Березнев.pages;

namespace TestingProject
{
    /// <summary>
    /// Класс тестирующий проверку валидности значений введеных на 1-й странице
    /// </summary>
    [TestClass]
    public class InvalidInputTestPage1
    {
        it_page1 page = new it_page1();
        [TestMethod]
        public void FirstPageDevisionByZero()
        {
            Assert.AreEqual(page.check_valid_data("-1", "1", "0") , 1);
        }
        [TestMethod]
        public void FirstPageStringInput()
        {
            Assert.AreEqual(page.check_valid_data("0,3", "string", "20"), 2);
        }
        [TestMethod]
        public void FirstPageBlankInput()
        {
            Assert.AreEqual(page.check_valid_data(" ", "1", " "), 2);
        }
        [TestMethod]
        public void FirstPageNoInput()
        {
            Assert.AreEqual(page.check_valid_data("", "", ""), 2);
        }
        [TestMethod]
        public void FirstPageValidDataInput()
        {
            Assert.AreEqual(page.check_valid_data("1", "6", "3,4"), 0);
        }
    }
    /// <summary>
    /// Класс тестирующий проверку валидности значений введеных на 2-й странице
    /// </summary>
    [TestClass]
    public class InvalidInputTestPage2
    {
        it_page2 page = new it_page2();
        [TestMethod]
        public void SecondPageStringInput()
        {
            Assert.AreEqual(page.check_valid_data("1,3", "help", 2), 1);
        }
        [TestMethod]
        public void SecondPageBlankInput()
        {
            Assert.AreEqual(page.check_valid_data(" ", "12", 1), 1);
        }
        [TestMethod]
        public void SecondPageNoInput()
        {
            Assert.AreEqual(page.check_valid_data("12", "", 3), 1);
        }
        [TestMethod]
        public void SecondPageValidDataInput()
        {
            Assert.AreEqual(page.check_valid_data("1", "6", 1), 0);
        }
    }
    /// <summary>
    /// Класс тестирующий проверку валидности значений введеных на 3-й странице
    /// </summary>
    [TestClass]
    public class InvalidInputTestPage3
    {
        // Если в наименовании теста содержиться UP это значит что dx > 0
        // Если в наименовании теста содержиться Down это значит что dx < 0
        it_pages3 page = new it_pages3();
        [TestMethod]
        public void ThirdPageStringInput()
        {
            Assert.AreEqual(page.check_valid_data("you", "can't", "type", "string"), 1);
        }
        [TestMethod]
        public void ThirdPageBlankInput()
        {
            Assert.AreEqual(page.check_valid_data(" ", "1", "0,3", "30"), 1);
        }
        [TestMethod]
        public void ThirdPageNoInput()
        {
            Assert.AreEqual(page.check_valid_data("3", "", "13", "13"), 1);
        }
        [TestMethod]
        public void ThirdPageDxEqualZero()
        {
            Assert.AreEqual(page.check_valid_data("3", "0", "13", "17"), 2);
        }
        [TestMethod]
        public void ThirdPageInfinityCycleUp()
        {
            Assert.AreEqual(page.check_valid_data("3", "1", "17", "11"), 3);
        }
        [TestMethod]
        public void ThirdPageInfinityCycleDown()
        {
            Assert.AreEqual(page.check_valid_data("3", "-1", "13", "27"), 3);
        }
        [TestMethod]
        public void ThirdPageDxToBigUp()
        {
            Assert.AreEqual(page.check_valid_data("3", "10", "13", "20"), 4);
        }
        [TestMethod]
        public void ThirdPageDxToBigDown()
        {
            Assert.AreEqual(page.check_valid_data("3", "-10", "20", "17"), 4);
        }
        [TestMethod]
        public void ThirdPageValidDataInputUp()
        {
            Assert.AreEqual(page.check_valid_data("10", "0,2", "1", "5"), 0);
        }
        [TestMethod]
        public void ThirdPageValidDataInputDown()
        {
            Assert.AreEqual(page.check_valid_data("0", "-0,5", "10", "-10"), 0);
        }
    }
}
