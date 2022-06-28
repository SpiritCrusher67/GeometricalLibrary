using System;
using Xunit;

namespace GeometricalLibrary.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CreateTriangle_Success()
        {
            //Arrange
            var (sideA, sideB, sideC) = (10d, 11d, 20d);

            //Act
            var triangle = new Triangle(sideA, sideB, sideC);

            //Assert
            Assert.NotNull(triangle);
            Assert.Equal(sideA, triangle.SideA);
            Assert.Equal(sideB, triangle.SideB);
            Assert.Equal(sideC, triangle.SideC);
        }

        [Fact]
        public void CreateTriangle_FailOnWrongSide()
        {
            //Arrange
            var (sideA, sideB, sideC) = (10d, 11d, 25d);

            //Act
            //Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void CalculateArea_Success()
        {
            //Arrange
            var triangle = new Triangle(10, 11, 20);

            //Act
            var area = triangle.CalculateArea();
            area = Math.Round(area, 4);
            //Assert
            Assert.Equal(31.9756, area);
        }

        [Fact]
        public void IsRectangular_SuccessOnIsRectangular()
        {
            //Arrange
            var triangle = new Triangle(7, 24, 25);

            //Act
            //Assert
            Assert.True(triangle.IsRectangular());
        }

        [Fact]
        public void IsRectangular_SuccessOnIsNotRectangular()
        {
            //Arrange
            var triangle = new Triangle(10, 24, 25);

            //Act
            //Assert
            Assert.False(triangle.IsRectangular());
        }
    }
}