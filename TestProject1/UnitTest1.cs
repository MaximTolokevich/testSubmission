using ConsoleApp1;

namespace TestProject1;

public class CalculatorTests
{
    private readonly Calculator _calc = new();

    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        Assert.Equal(10, _calc.Add(5, 5));
    }

    [Fact]
    public void Power_ShouldReturnCorrectValue()
    {
        Assert.Equal(8, _calc.Power(2, 3));
    }

    [Fact]
    public void SquareRoot_ShouldThrow_WhenNegative()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _calc.SquareRoot(-1));
    }

    [Theory]
    [InlineData(4, 2)]
    [InlineData(25, 5)]
    public void SquareRoot_ValidData_ReturnsCorrect(double input, double expected)
    {
        Assert.Equal(expected, _calc.SquareRoot(input));
    }

    [Fact]
    public void History_ShouldTrackOperations()
    {
        _calc.ClearHistory();
        _calc.Add(2, 2);
        Assert.Single(_calc.History);
        Assert.Equal("2 + 2 = 4", _calc.History[0]);
    }
}
