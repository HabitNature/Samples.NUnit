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
    }
}
