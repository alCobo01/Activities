using activitiesUtils;

namespace TestActivities
{
    [TestClass]
    public class TestExercici18
    {
        // Test per l�mits a dins del rang perm�s
        [TestMethod]
        public void RangeLimitInsideOne()
        {
            //Arrange
            int num = 0;
            bool test;
            //Act
            test = Utils.IsValidAge(num);
            //Assert
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void RangeLimitInsideTwo()
        {
            //Arrange
            int num = 120;
            bool test;
            //Act
            test = Utils.IsValidAge(num);
            //Assert
            Assert.IsTrue(test);
        }

        // Test per l�mits a fora del rang perm�s
        [TestMethod]
        public void RangeLimitOutsideOne()
        {
            //Arrange
            int num = 121;
            bool test;
            //Act
            test = Utils.IsValidAge(num);
            //Assert
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void RangeLimitOutsideTwo()
        {
            //Arrange
            int num = -1;
            bool test;
            //Act
            test = Utils.IsValidAge(num);
            //Assert
            Assert.IsFalse(test);
        }

        // Test per valors a fora del rang perm�s
        [TestMethod]
        public void OutsideOfRangeOne()
        {
            //Arrange
            int num = 132;
            bool test;
            //Act
            test = Utils.IsValidAge(num);
            //Assert
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void OutsideOfRangeTwo()
        {
            //Arrange
            int num = -32;
            bool test;
            //Act
            test = Utils.IsValidAge(num);
            //Assert
            Assert.IsFalse(test);
        }
    }
}