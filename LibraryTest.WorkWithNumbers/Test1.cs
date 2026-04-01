
using LibraryIntigersAndRealNumbers;

namespace LibraryTest.WorkWithNumber
{
    [TestClass]
    public sealed class Test1
    {
        private WorkWithNumbers _workWithNumbers=new();
        [DataTestMethod]
        [DataRow(3.6, 4)]
        [DataRow(-2.3, -2)]
        public void RoundNumber_Returns(double input, double expected)
        {
            double result = _workWithNumbers.RoundNumber(input);
            Assert.AreEqual(expected, result);
            Assert.IsInstanceOfType(result, typeof(double));
        }

        [TestMethod]
        public void RoundNumber_ThrowstException()
        {
            Assert.Throws<ArgumentException>(() => _workWithNumbers.RoundNumber(double.NaN));
        }

        [DataTestMethod]
        [DataRow(5.5, 5.5)]
        [DataRow(-7.8, 7.8)]
        public void ModuleNumber_Returns(double input, double expected)
        {
            double result = _workWithNumbers.ModuleNumber(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ModuleNumber_ReturnsZero()
        {
            double result = _workWithNumbers.ModuleNumber(0.0);
            Assert.AreEqual(0, result);
        }
        [DataTestMethod]
        [DataRow(10, 10)]
        [DataRow(-15, 15)]
        public void ModuleNumber_Int_Returns(int input, int expected)
        {
            int result = _workWithNumbers.ModuleNumber(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ModuleNumber_Int_Zero()
        {
            int result = _workWithNumbers.ModuleNumber(0);
            Assert.AreEqual(0, result);
        }
        [DataTestMethod]
        [DataRow(3.14f, 3.14f)]
        [DataRow(-6.28f, 6.28f)]
        public void ModuleNumber_Float_Returns(float input, float expected)
        {
            float result = _workWithNumbers.ModuleNumber(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ModuleNumber_Float_Zero()
        {
            float result = _workWithNumbers.ModuleNumber(0f);
            Assert.AreEqual(0f, result);
        }
        [DataTestMethod]
        [DataRow(4, true)]
        [DataRow(7, false)]
        public void CheckParity_Int_Returns(int input, bool expected)
        {
            bool result = _workWithNumbers.CheckParity(input);
            Assert.AreEqual(expected, result);
            Assert.IsInstanceOfType(result, typeof(bool));
        }

        [TestMethod]
        public void CheckParity_Int_Zero()
        {
            bool result = _workWithNumbers.CheckParity(0);
            Assert.IsTrue(result);
        }
        [DataTestMethod]
        [DataRow(8.0, true)]
        [DataRow(9.0, false)]
        public void CheckParity_Double_Returns(double input, bool expected)
        {
            bool result = _workWithNumbers.CheckParity(input);
            Assert.AreEqual(expected, result);
            Assert.IsInstanceOfType(result, typeof(bool));
        }

        [TestMethod]
        public void CheckParity_Double_Zero()
        {
            bool result = _workWithNumbers.CheckParity(0.0);
            Assert.IsTrue(result);
        }
        [DataTestMethod]
        [DataRow(12.0f, true)]
        [DataRow(13.0f, false)]
        public void CheckParity_Float_Returns(float input, bool expected)
        {
            bool result = _workWithNumbers.CheckParity(input);
            Assert.AreEqual(expected, result);
            Assert.IsInstanceOfType(result, typeof(bool));
        }

        [TestMethod]
        public void CheckParity_Float_Zero()
        {
            bool result = _workWithNumbers.CheckParity(0.0f);
            Assert.IsTrue(result);
        }
        [DataTestMethod]
        [DataRow(5, true)]
        [DataRow(6, false)]
        public void CheckNonParity_Int_Returns(int input, bool expected)
        {
            bool result = _workWithNumbers.CheckNonParity(input);
            Assert.AreEqual(expected, result);
            Assert.IsInstanceOfType(result, typeof(bool));
        }

        [TestMethod]
        public void CheckNonParity_Int_One()
        {
            bool result = _workWithNumbers.CheckNonParity(1);
            Assert.IsTrue(result);
        }
        [DataTestMethod]
        [DataRow(11.0, true)]
        [DataRow(10.0, false)]
        public void CheckNonParity_Double_Returns(double input, bool expected)
        {
            bool result = _workWithNumbers.CheckNonParity(input);
            Assert.AreEqual(expected, result);
            Assert.IsInstanceOfType(result, typeof(bool));
        }

        [TestMethod]
        public void CheckNonParity_Double_One()
        {
            bool result = _workWithNumbers.CheckNonParity(1.0);
            Assert.IsTrue(result);
        }
        [DataTestMethod]
        [DataRow(15.0f, true)]
        [DataRow(14.0f, false)]
        public void CheckNonParity_Float_Returns(float input, bool expected)
        {
            bool result = _workWithNumbers.CheckNonParity(input);
            Assert.AreEqual(expected, result);
            Assert.IsInstanceOfType(result, typeof(bool));
        }

        [TestMethod]
        public void CheckNonParity_Float_One()
        {
            bool result = _workWithNumbers.CheckNonParity(1.0f);
            Assert.IsTrue(result);
        }
        [DataTestMethod]
        [DataRow(3.14159, 2, 3.14)]
        [DataRow(2.675, 2, 2.68)]
        public void Round_WithDecimals(double number, int decimals, double expected)
        {
            double result = _workWithNumbers.Round(number, decimals);
            Assert.AreEqual(expected, result);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Round_ZeroDecimals()
        {
            double result = _workWithNumbers.Round(3.14159, 0);
            Assert.AreEqual(3, result);
            Assert.IsInstanceOfType(result, typeof(double));
        }

        [TestMethod]
        public void Round_NegativeDecimals()
        {
            Assert.Throws<ArgumentException>(() => _workWithNumbers.Round(3.14, -1));
        }
        //dsfs
        [DataTestMethod]
        [DataRow(5, 1, 10, true, true)]
        [DataRow(15, 1, 10, true, false)]
        public void IsInRange_Returns(double number, double min, double max, bool inclusive, bool expected)
        {
            bool result = _workWithNumbers.IsInRange(number, min, max, inclusive);
            Assert.AreEqual(expected, result);
            Assert.IsInstanceOfType(result, typeof(bool));
        }

        [TestMethod]
        public void IsInRange_ReturnsFalse()
        {
            bool result = _workWithNumbers.IsInRange(10, 1, 10, false);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsInRange_ThrowsArgumentExceptionMinMax()
        {
            Assert.Throws<ArgumentException>(() => _workWithNumbers.IsInRange(5, 10, 1));
        }

        [DataTestMethod]
        [DataRow(new double[] { 1, 5, 3, 9, 2 }, 9)]
        [DataRow(new double[] { -5, -2, -8, -1 }, -1)]
        public void Max_ReturnsMaximum(double[] numbers, double expected)
        {
            double result = _workWithNumbers.Max(numbers);
            Assert.AreEqual(expected, result);
            Assert.IsInstanceOfType(result, typeof(double));
        }

        [TestMethod]
        public void Max_SingleNumber()
        {
            double result = _workWithNumbers.Max(100);
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void Max_EmptyArray()
        {
            Assert.Throws<ArgumentException>(() => _workWithNumbers.Max());
        }

        [DataTestMethod]
        [DataRow(new double[] { 1, 5, 3, 9, 2 }, 1)]
        [DataRow(new double[] { -5, -2, -8, -1 }, -8)]
        public void Min_ReturnsMinimum(double[] numbers, double expected)
        {
            double result = _workWithNumbers.Min(numbers);
            Assert.AreEqual(expected, result);
            Assert.IsInstanceOfType(result, typeof(double));
        }

        [TestMethod]
        public void Min_SingleNumber()
        {
            double result = _workWithNumbers.Min(-100);
            Assert.AreEqual(-100, result);
        }

        [TestMethod]
        public void Min_EmptyArray()
        {
            Assert.Throws<ArgumentException>(() => _workWithNumbers.Min());
        }

        [DataTestMethod]
        [DataRow(new double[] { 10, 20, 30, 40 }, 25)]
        [DataRow(new double[] { -10, -20, -30 }, -20)]
        public void AvgNum_ReturnsAverage(double[] numbers, double expected)
        {
            double result = _workWithNumbers.AvgNum(numbers);
            Assert.AreEqual(expected, result);
            Assert.IsInstanceOfType(result, typeof(double));
        }

        [TestMethod]
        public void AvgNum_SingleNumber()
        {
            double result = _workWithNumbers.AvgNum(100);
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void AvgNum_EmptyArray()
        {
            Assert.Throws<ArgumentException>(() => _workWithNumbers.AvgNum());
        }

        [DataTestMethod]
        [DataRow(2, 3, 8)]
        [DataRow(5, 2, 25)]
        public void PowNumber_ReturnsPow(double number, double exponent, double expected)
        {
            double result = _workWithNumbers.PowNumber(number, exponent);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PowNumber_ReturnsZero()
        {
            double result = _workWithNumbers.PowNumber(0, 5);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void PowNumber_ZeroBase()
        {
            Assert.Throws<ArgumentException>(() => _workWithNumbers.PowNumber(0, -2));
        }
    }
}