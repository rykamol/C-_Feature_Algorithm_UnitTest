using Binary_Search;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllLibraryTest
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void BinarySearch_Exists_ReturnTrue()
        {
            Binary aBinary = new Binary();


            var result = aBinary.SearchNumber(new[] { 1, 2, 3, 4, 5 }, 5, 2);
            bool isTrue = false;

            if (result > -1)
                isTrue = true;


            Assert.IsTrue(isTrue);
        }
    }
}
