using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulationLib;

namespace StringManipulationTest
{
    [TestClass] //attributes
    public class TestStringChange
    {
        StringChange strChange = new StringChange();
        [TestMethod]
        public void TestChangeToUpper()
        {
            //Arrange
            
            string expected = "FRED";
            //Act
            string actual=strChange.ChangeToUpper("fred");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestInstanceType()
        {
            string actual=strChange.ChangeToUpper("Fred");
            Assert.IsInstanceOfType(actual, typeof(string));
        }
        [TestMethod]
        public void TestReverse()
        {
            string expected = "derf";
            string actual=strChange.Reverse("fred");
            Assert.AreEqual(expected, actual);
        }
    }
}
