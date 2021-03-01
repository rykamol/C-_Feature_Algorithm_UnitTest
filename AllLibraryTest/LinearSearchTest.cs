using Linear_Search;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllLibraryTest
{
    [TestClass]
    public class LinearSearchTest
    {
        [TestMethod]
        public void LinearSearch_ItemExists_ReturnIndex()
        {
            //Arrange 
            LinearSearch aLinearSearch = new LinearSearch();


            //Act
            var index = aLinearSearch.Linear_Search(new[] { 1, 2, 3, 4, 5, 6, 7 }, 7, 2);


            //Assert
            Assert.AreEqual(index, 1);
        }
    }
}
