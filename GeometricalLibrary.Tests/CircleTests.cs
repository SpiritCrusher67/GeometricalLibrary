using System;
using Xunit;

namespace GeometricalLibrary.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CreateCircle_Success()
        {
            //Arrange
            var radius = 10d;

            //Act
            var circle = new Circle(radius);

            //Assert
            Assert.NotNull(circle);
            Assert.Equal(radius, circle.Radius);
        }

        [Fact]
        public void CalculateArea_Success()
        {
            //Arrange
            var circle = new Circle(10);

            //Act
            var area = circle.CalculateArea();
            area = Math.Round(area, 4);
            //Assert
            Assert.Equal(314.1593, area);
        }
    }
}
