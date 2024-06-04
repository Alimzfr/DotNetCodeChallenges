namespace DotNetCodeChallenges.Services;

/// <summary>
/// Collection challenges
/// </summary>
public class Collections
{
    /// <summary>
    /// Rotate arrays
    /// </summary>
    public void RotateArray(int[] array, uint position)
    {
        if (array is null || !array.Any())
        {
            throw new ArgumentNullException(nameof(array), "The array mustn't be null or empty!");
        }

        var arrayLength = array.Length;

        if (arrayLength <= 1)
        {
            throw new ArgumentNullException(nameof(array), "The array must have at least two item!");
        }

        if (arrayLength <= position)
        {
            throw new ArgumentOutOfRangeException(nameof(position), "The position mustn't be greater or equal to the array length!");
        }

        if (position == 0)
        {
            return;
        }

        var temp = new int[position];
        Array.Copy(array, temp, position);
        Array.Copy(array, position, array, 0, arrayLength - position);
        Array.Copy(temp, 0, array, arrayLength - position, position);
    }
}