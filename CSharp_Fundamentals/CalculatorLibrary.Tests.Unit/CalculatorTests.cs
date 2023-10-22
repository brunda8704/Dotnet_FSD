using FluentAssertions;

namespace CalculatorLibrary.Tests.Unit
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(10,10,20)]
        [InlineData(0,0,0)]
        public void Add_ShouldTakeTwoIntegersWithInlineData_And_ReturnsInteger(int firstNumber,int secondNumber,int expectedResult)
        {

            var calculator = new Calculator();
            var actualResult = calculator.Add(firstNumber,secondNumber);    
            //Assert.Equal(20, actualResult);
            actualResult.Should().Be(expectedResult);

        }

        [Theory]
        [InlineData(10,10,0)]
        public void Subtract_ShouldTakeTwoIntegersWithInlineData_And_ReturnsInteger(int firstNumber,int secondNumber,int expectedResult)
        {
            var calculator = new Calculator();
            var actualResult = calculator.Subtract(firstNumber,secondNumber);
            actualResult.Should().Be(expectedResult);
           
        }
        

    }
}