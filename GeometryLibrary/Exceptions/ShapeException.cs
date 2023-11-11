namespace GeometryLibrary.Logic.Exceptions;

public class ShapeException : Exception
{
    public ShapeException(string message, double val)
        : base(message)
    {
        Value = val;
    }

    public ShapeException(string message) : base(message)
    {
    }

    public double Value { get; }
}