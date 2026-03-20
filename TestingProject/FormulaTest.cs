using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Практическая_работа_4_Филин_Березнев;

namespace TestingProject
{
    /// <summary>
    /// Тестовый класс тестирующий вычисление значений в первой формуле (все значиния уже прошли фильтрацию и являются валидными)
    /// </summary>
    [TestClass]
    public class FirstFormulaTest
    {
        [TestMethod]
        public void FirstTest()
        {
            Assert.AreEqual(Formula.first(1, 1, 1), 1.2842, 0.001);
        }
        [TestMethod]
        public void SecondTest()
        {
            Assert.AreEqual(Formula.first(2, 2, 2), 1.1439, 0.001);
        }
        [TestMethod]
        public void ThirdTest()
        {
            Assert.AreEqual(Formula.first(-1, -1, -1), 2.5652, 0.001);
        }
    }
    /// <summary>
    /// Тестовый класс тестирующий вычисление значений во второй формуле (все значиния уже прошли фильтрацию и являются валидными)
    /// </summary>
    [TestClass]
    public class SecondFormulaTest
    {
        [TestMethod]
        public void ConditionFirstShx()
        {
            Assert.AreEqual(Formula.second(10, 1, 1), 104.944, 0.001);
        }
        [TestMethod]
        public void ConditionSecondShx()
        {
            Assert.AreEqual(Formula.second(-1, -1, 1), 1.0841, 0.001);
        }
        [TestMethod]
        public void ConditionThirdShx()
        {
            Assert.AreEqual(Formula.second(0, 0, 1), 0, 0.001);
        }
        [TestMethod]
        public void ConditionFirstx2()
        {
            Assert.AreEqual(Formula.second(1, -1, 2), -1, 0.001);
        }
        [TestMethod]
        public void ConditionSecondx2()
        {
            Assert.AreEqual(Formula.second(-1, 0, 2), 0, 0.001);
        }
        [TestMethod]
        public void ConditionThirdx2()
        {
            Assert.AreEqual(Formula.second(1, 1, 2), 1, 0.001);
        }
        [TestMethod]
        public void ConditionFirstEx()
        {
            Assert.AreEqual(Formula.second(10, -1, 3), -148.413, 0.001);
        }
        [TestMethod]
        public void ConditionSecondEx()
        {
            Assert.AreEqual(Formula.second(-1, 0, 3), 0, 0.001);
        }
        [TestMethod]
        public void ConditionThirdEx()
        {
            Assert.AreEqual(Formula.second(0, 1, 3), 1, 0.001);
        }
    }
    /// <summary>
    /// Тестовый класс тестирующий вычисление значений в третей формуле (все значиния уже прошли фильтрацию и являются валидными)
    /// </summary>
    [TestClass]
    public class ThirdFormulaTest
    {
        [TestMethod]
        public void FirstTest()
        {
        }
    }
}
