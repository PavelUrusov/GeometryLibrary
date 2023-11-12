namespace GeometryLibrary.Logic.Exceptions;

/// <summary>
///     Represents an exception related to geometric shapes.
/// </summary>
public class ShapeException : Exception
{
    /// <summary>
    ///     Initializes a new instance of the ShapeException class with a specific message and a related value.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="val">The value associated with the exception (if applicable).</param>
    public ShapeException(string message, double val)
        : base(message)
    {
        Value = val;
    }

    /// <summary>
    ///     Initializes a new instance of the ShapeException class with a specific message.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    public ShapeException(string message) : base(message)
    {
    }

    /// <summary>
    ///     Gets the value associated with the exception (if applicable).
    /// </summary>
    public double Value { get; }
}