namespace GeometryLibrary.Logic.Exceptions;

public class ShipException : Exception
{
    public ShipException(string message, double val)
        : base(message)
    {
        Value = val;
    }

    public ShipException(string message) : base(message)
    {
    }

    public double Value { get; }
}