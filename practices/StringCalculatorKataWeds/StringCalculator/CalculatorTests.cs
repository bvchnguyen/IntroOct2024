

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("3", 3)]
    public void SingleNumber(string strNum, int number)
    {
        var calculator = new Calculator();

        var result = calculator.Add(strNum);

        Assert.Equal(result, number);
    }

    [Theory]
    [InlineData("1, 2", 3)]
    public void AddWithComma(string strNum, int answer)
    {
        var calculator = new Calculator();

        var result = calculator.Add(strNum);

        Assert.Equal(answer, result);
    }

    [Theory]
    [InlineData("1, 2, 3", 6)]
    [InlineData("12, 2, 4", 18)]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]
    public void AddWithCommaDynamicLength(string strNum, int answer)
    {
        var calculator = new Calculator();

        var result = calculator.Add(strNum);

        Assert.Equal(answer, result);
    }
}
