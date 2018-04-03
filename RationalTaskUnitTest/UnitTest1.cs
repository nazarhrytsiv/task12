using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathSuite.Core.Numeric;

namespace RationalTaskUnitTest
{
    [TestClass]
    public class Task18UnitTests
    {
        private TestContext testContext;
        public TestContext TestContext { get => testContext; set => testContext = value; }

        
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                   "|DataDirectory|\\additionTest.csv",
                   "additionTest#csv",
                   DataAccessMethod.Sequential),
                   DeploymentItem("additionTest.csv")]
        public void AddRational()
        {

            //Arrange
            int numerator1 = int.Parse(TestContext.DataRow["numerator1"].ToString());
            int denominator1 = int.Parse(TestContext.DataRow["denominator1"].ToString());
            int numerator2 = int.Parse(TestContext.DataRow["numerator2"].ToString());
            int denominator2 = int.Parse(TestContext.DataRow["denominator2"].ToString());
            int resultNumerator = int.Parse(TestContext.DataRow["resultNumerator"].ToString());
            int resultDenominator = int.Parse(TestContext.DataRow["resultDenominator"].ToString());
            Rational number1 = new Rational(numerator1, denominator1);
            Rational number2 = new Rational(numerator2, denominator2);
            Rational expected = new Rational(resultNumerator, resultDenominator);

            //Act
            Rational actual = number1 + number2;

            //Assert
            Assert.AreEqual(expected._denominator, actual._denominator);
            Assert.AreEqual(expected._numerator, actual._numerator);
        }



        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                  "|DataDirectory|\\subtractionTest.csv",
                  "subtractionTest#csv",
                  DataAccessMethod.Sequential),
                  DeploymentItem("subtractionTest.csv")]
        public void SubRational()
        {
            //Arrange
            int numerator1 = int.Parse(TestContext.DataRow["numerator1"].ToString());
            int denominator1 = int.Parse(TestContext.DataRow["denominator1"].ToString());
            int numerator2 = int.Parse(TestContext.DataRow["numerator2"].ToString());
            int denominator2 = int.Parse(TestContext.DataRow["denominator2"].ToString());
            int resultNumerator = int.Parse(TestContext.DataRow["resultNumerator"].ToString());
            int resultDenominator = int.Parse(TestContext.DataRow["resultDenominator"].ToString());
            Rational number1 = new Rational(numerator1, denominator1);
            Rational number2 = new Rational(numerator2, denominator2);
            Rational expected = new Rational(resultNumerator, resultDenominator);

            //Act
            Rational actual = number1 - number2;

            //Assert
            Assert.AreEqual(expected._denominator, actual._denominator);
            Assert.AreEqual(expected._numerator, actual._numerator);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                  "|DataDirectory|\\multiplicationTest.csv",
                  "multiplicationTest#csv",
                  DataAccessMethod.Sequential),
                  DeploymentItem("multiplicationTest.csv")]
        public void MultiplicateRational()
        {
            //Arrange
            int numerator1 = int.Parse(TestContext.DataRow["numerator1"].ToString());
            int denominator1 = int.Parse(TestContext.DataRow["denominator1"].ToString());
            int numerator2 = int.Parse(TestContext.DataRow["numerator2"].ToString());
            int denominator2 = int.Parse(TestContext.DataRow["denominator2"].ToString());
            int resultNumerator = int.Parse(TestContext.DataRow["resultNumerator"].ToString());
            int resultDenominator = int.Parse(TestContext.DataRow["resultDenominator"].ToString());
            Rational number1 = new Rational(numerator1, denominator1);
            Rational number2 = new Rational(numerator2, denominator2);
            Rational expected = new Rational(resultNumerator, resultDenominator);

            //Act
            Rational actual = number1 * number2;

            //Assert
            Assert.AreEqual(expected._denominator, actual._denominator);
            Assert.AreEqual(expected._numerator, actual._numerator);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                  "|DataDirectory|\\divideTest.csv",
                  "divideTest#csv",
                  DataAccessMethod.Sequential),
                  DeploymentItem("divideTest.csv")]
        public void divideRational()
        {
            //Arrange
            int numerator1 = int.Parse(TestContext.DataRow["numerator1"].ToString());
            int denominator1 = int.Parse(TestContext.DataRow["denominator1"].ToString());
            int numerator2 = int.Parse(TestContext.DataRow["numerator2"].ToString());
            int denominator2 = int.Parse(TestContext.DataRow["denominator2"].ToString());
            int resultNumerator = int.Parse(TestContext.DataRow["resultNumerator"].ToString());
            int resultDenominator = int.Parse(TestContext.DataRow["resultDenominator"].ToString());
            Rational number1 = new Rational(numerator1, denominator1);
            Rational number2 = new Rational(numerator2, denominator2);
            Rational expected = new Rational(resultNumerator, resultDenominator);

            //Act
            Rational actual = number1 / number2;

            //Assert
            Assert.AreEqual(expected._denominator, actual._denominator);
            Assert.AreEqual(expected._numerator, actual._numerator);
        }

    }
}
