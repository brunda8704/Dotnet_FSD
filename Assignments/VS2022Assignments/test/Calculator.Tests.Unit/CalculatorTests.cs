using FluentAssertions;

namespace Calculator.Tests.Unit
{
    public class CalculatorTests
    {

        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(-5, 5, 0)]
        [InlineData(-15, (-5), -20)]
        public void Addition_ShouldTakeTwoIntegersWithInlineData_And_ReturnsInteger(int firstNumber, int secondNumber, int expectedResult)
        {
            var calculator = new Calculator();
            var actualResult = calculator.Addition(firstNumber, secondNumber);
            actualResult.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(5, 5, 0)]
        [InlineData(15, 5, 10)]
        [InlineData(-5, (-5), 0)]
        [InlineData(-15, (-5), -10)]
        [InlineData(5, 10, -5)]
        public void Subtraction_ShouldTakeTwoIntegersWithInlineData_And_ReturnsInteger(int firstNumber, int secondNumber, int expectedResult)
        {
            var calculator = new Calculator();
            var actualResult = calculator.Subtraction(firstNumber, secondNumber);
            actualResult.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(50, 0, 0)]
        [InlineData(-5, 5, -25)]
        public void Multiplication_ShouldTakeTwoIntegersWithInlineData_And_ReturnsInteger(int firstNumber, int secondNumber, int expectedResult)
        {
            var calculator = new Calculator();
            var actualResult = calculator.Multiplication(firstNumber, secondNumber);
            actualResult.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(5, 5, 1)]
        [InlineData(15, 5, 3)]
        [InlineData(5, 0, 0, Skip = "Skip this test")]
        public void Division_ShouldTakeTwoIntegersWithInlineData_And_ReturnsInteger(int firstNumber, int secondNumber, int expectedResult)
        {
            var calculator = new Calculator();
            var actualResult = calculator.Division(firstNumber, secondNumber);
            actualResult.Should().Be(expectedResult);
        }

    }
    
}