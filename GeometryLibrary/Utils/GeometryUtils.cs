namespace GeometryLibrary.Logic.Utils;

/// <summary>
///     Utility class for common geometry-related operations.
/// </summary>
public static class GeometryUtils
{
    /// <summary>
    ///     Checks if a given number is positive.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>True if the number is positive, false otherwise.</returns>
    public static bool IsPositiveNumber(double number)
    {
        return number > 0;
    }
}