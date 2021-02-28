using Binary_Search;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTest
{
    [TestClass]
    class BinarySearchTests
    {
        [TestMethod]
        public void SearchNumber_Exists_ReturnTrue()
        {
            //Arrange 
            Binary aBinary = new Binary();

            // Act
            int findNumber = aBinary.SearchNumber(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 22, 33, 44, 55, 66, 77, 88, 99 }, 19, 99);
            bool istrue;

            if (findNumber > -1)
            {
                istrue = true;
            }
            else
            {
                istrue = false;
            }

            //Assert
            Assert.IsTrue(istrue);
        }
    }
}
