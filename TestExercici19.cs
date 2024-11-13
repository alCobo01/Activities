using activitiesUtils;

namespace TestActivities
{
    [TestClass]
    public class TestExercici19
    {
        // Test per límits del descompte del 50%
        [TestMethod]
        public void FiftyDiscountLimitTestOne()
        {
            //Arrange
            int age = 0;
            int test;
            //Act
            test = Utils.AppliedDiscount(age);
            //Assert
            Assert.AreEqual(test, 50);
        }

        [TestMethod]
        public void FiftyDiscountLimitTestTwo()
        {
            //Arrange
            int age = 12;
            int test;
            //Act
            test = Utils.AppliedDiscount(age);
            //Assert
            Assert.AreEqual(test, 50);
        }

        // Test per límits del descompte del 25%
        [TestMethod]
        public void TwentyFiveDescountLimitTestOne()
        {
            //Arrange
            int age = 13;
            int test;
            //Act
            test = Utils.AppliedDiscount(age);
            //Assert
            Assert.AreEqual(test, 25);
        }

        [TestMethod]
        public void TwentyFiveDescountLimitTestTwo()
        {
            //Arrange
            int age = 17;
            int test;
            //Act
            test = Utils.AppliedDiscount(age);
            //Assert
            Assert.AreEqual(test, 25);
        }

        // Test per límits del descompte del 30%
        [TestMethod]
        public void ThirtyDescountLimitTestOne()
        {
            //Arrange
            int age = 65;
            int test;
            //Act
            test = Utils.AppliedDiscount(age);
            //Assert
            Assert.AreEqual(test, 30);
        }

        [TestMethod]
        public void ThirtyDescountLimitTestTwo()
        {
            //Arrange
            int age = 120;
            int test;
            //Act
            test = Utils.AppliedDiscount(age);
            //Assert
            Assert.AreEqual(test, 30);
        }

        // Test per límits sense descompte
        [TestMethod]
        public void NoDiscountTestOne()
        {
            //Arrange
            int age = 18;
            int test;
            //Act
            test = Utils.AppliedDiscount(age);
            //Assert
            Assert.AreEqual(test, 0);
        }

        [TestMethod]
        public void NoDiscountTestTwo()
        {
            //Arrange
            int age = 64;
            int test;
            //Act
            test = Utils.AppliedDiscount(age);
            //Assert
            Assert.AreEqual(test, 0);
        }
    }
}
