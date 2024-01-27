using FirstResponsiveWebAppDam.Models;

namespace FirstWebAppUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void PassingAgeThisYearTest()
        {
            // Arrange
            AgeModel ageModel = new AgeModel();
            ageModel.BirthYear = 2002;

            int? expected = 22;
            int? actual;

            // Act
            actual = ageModel.AgeThisYear();

            // Assert
            Assert.Equal(expected, actual);
        }

        // included this unitTest to showcase the test is working as intended
        [Fact]
        public void FailingAgeThisYearTest()
        {
            // Arrange
            AgeModel ageModel = new AgeModel();
            ageModel.BirthYear = 2002;

            int? expected = 21;
            int? actual;

            // Act
            actual = ageModel.AgeThisYear();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}