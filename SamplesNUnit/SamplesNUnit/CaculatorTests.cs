using NUnit.Framework;
using System;

namespace SamplesNUnit
{
    public class CaculatorTests
    {
        [Test]
        public void Caculator_Sum_ReturnSuccessfully()
        {
            //// Arange 
            //Caculator caculator = new Caculator();

            //// Act 
            //int sum = caculator.Sum(3, 4);

            //// Assert
            //Assert.AreEqual(7, sum);

            //StringAssert.StartsWith("ab", "abc");

            //CollectionAssert.Contains(new int[] { 1, 3, 5 }, 3);

            //FileAssert.Exists(@"c:\kms10.log");

            //DirectoryAssert.DoesNotExist(@"c:\NoExists");

            Assert.That("abcdef", Does.StartWith("ab").And.EndsWith("ef"));

            //StringAssert.StartsWith("ab", "abcdef");
            //StringAssert.EndsWith("efx", "abcdef");
        }
    }
}
