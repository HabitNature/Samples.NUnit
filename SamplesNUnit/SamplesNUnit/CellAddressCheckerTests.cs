/**
 * Description : 
 * 
 * Author      : wanghao
 * Email       : wanghao@testin.cn
 * Date        : 4/22/2021 3:41:14 PM
 */

using NUnit.Framework;
using SamplesNunit.UnderTest;

namespace SamplesNUnit
{
    [TestFixture]
    public class CellAddressCheckerTests
    {
        [TestCase("A1", ExpectedResult = true)]
        [TestCase("BC33", ExpectedResult = true)]
        [TestCase("33", ExpectedResult =false)]
        [TestCase("B", ExpectedResult = false)]
        [TestCase("...", ExpectedResult = false)]
        public bool CellAddressChecker_Check_ReturnResult(string cellAddress)
        {
            // Arange
            CellAddressChecker checker = new CellAddressChecker();

            // Act
            bool result = checker.Check(cellAddress);

            // Assert
            return result;
        }

        [TestCase("A1")]
        [TestCase("a1")]
        [TestCase("A65535")]
        [TestCase("a65535")]
        public void Check_ValidAddress_ReturnTrue(
            string cellAddress)
        {
            // Arrange
            CellAddressChecker checker = new CellAddressChecker();

            // Act 
            bool result = checker.Check(cellAddress);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Check_ValidAddress_ReturnTrueV2(
                    [Values("A", "a")] string column,
                    [Values(1, 65535)] int row)
        {
            // Arrange
            CellAddressChecker checker = new CellAddressChecker();

            // Act 
            string cellAddress = $"{column}{row}";

            bool result = checker.Check(cellAddress);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Check_ValidAddress_ReturnTrueV3(
            [Values("A", "a")] string column,
            [Random(1, 65535, 2)] int row)
        {
            // Arrange
            CellAddressChecker checker = new CellAddressChecker();

            // Act 
            string cellAddress = $"{column}{row}";

            bool result = checker.Check(cellAddress);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Check_ValidAddress_ReturnTrueV4(
            [Values("A", "a")] string column,
            [Range(1, 65535, 100)] int row)
        {
            // Arrange
            CellAddressChecker checker = new CellAddressChecker();

            // Act 
            string cellAddress = $"{column}{row}";

            bool result = checker.Check(cellAddress);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
