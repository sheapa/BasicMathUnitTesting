using CaclulationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculationLibary.Tests
{
    public class CalculationsTests
    {
        [Theory]
        [InlineData(4, 2, 6)]
        public void AddShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Arrange
            Calculations calc = new Calculations();

            //Act
            double actual = calc.Add(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,2,2)]
        public void SubtractShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Arrange
            Calculations Calc = new Calculations();

            //Act
            double actual = Calc.Subtract(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,2,8)]
        public void MultiplyShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Arrange
            Calculations Calc = new Calculations();

            //Act
            double actual = Calc.Multiply(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,2,2)]
        public void DivideShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Arrange
            Calculations Calc = new Calculations();

            //Act
            double actual = Calc.Divid(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
