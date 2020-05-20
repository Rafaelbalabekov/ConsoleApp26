using ConsoleApp26;
using System;
using System.Linq;
using Xunit;

namespace UnitTestProject1
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 2, 5)]
        [InlineData(0, 2, 2)]

        public void TestSum (double a, double b, double expected)
        {
            Calculate calc = new Calculate();

            double actual = calc.Sum(a, b);

            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(4, 2, 2)]
        [InlineData(10, 2, 8)]
        public void TestMinus(double a, double b, double expected)
        {
            Calculate calc = new Calculate();

            double actual = calc.Min(a, b);

            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(3, 5, 15)]
        [InlineData(6, 1, 6)]
        [InlineData(0, 2, 0)]
        public void TestMult(double a, double b, double expected)
        {
            Calculate calc = new Calculate();

            double actual = calc.Mul(a, b);

            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(3, 2, 1.5)]
        [InlineData(8, 5, 1.6)]
        public void TestDiv(double a, double b, double expected)
        {
            Calculate calc = new Calculate();

            double actual = calc.Div(a, b);

            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(169, 13)]
        [InlineData(144, 12)]
        [InlineData(4, 2)]
        public void TestDiv2(double a, double expected)
        {
            Calculate calc = new Calculate();

            double actual = calc.Div2(a);

            Assert.Equal(expected, actual);

        }
    }
}

