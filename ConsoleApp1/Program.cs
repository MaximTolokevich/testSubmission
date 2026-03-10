namespace ConsoleApp1;

public class Calculator
{
    private readonly List<string> _history = new();
    public IReadOnlyList<string> History => _history;

    public double Add(double a, double b)
    {
        double result = a + b;
        _history.Add($"{a} + {b} = {result}");
        return result;
    }

    public double Divide(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Cannot divide by zero.");
        double result = a / b;
        _history.Add($"{a} / {b} = {result}");
        return result;
    }

    public double Power(double @base, double exponent)
    {
        double result = Math.Pow(@base, exponent);
        _history.Add($"{@base} ^ {exponent} = {result}");
        return result;
    }

    public double SquareRoot(double a)
    {
        if (a < 0) throw new ArgumentOutOfRangeException(nameof(a), "Negative numbers not allowed.");
        double result = Math.Sqrt(a);
        _history.Add($"sqrt({a}) = {result}");
        return result;
    }

    public void ClearHistory() => _history.Clear();
}
