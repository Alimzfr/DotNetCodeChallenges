namespace DotNetCodeChallenges.Services;

/// <summary>
/// Rotate arrays
/// </summary>
public class RotateArrays
{
    public void RotateLeft(int[] array, uint position)
    {
        var arrayLength = array.Length;

        if (array is null || arrayLength <= 1)
        {
            throw new ArgumentNullException(nameof(array), "The array mustn't be null or empty, and must have at least one item!");
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

    public void RotateRight(int[] array, uint position)
    {
        var arrayLength = array.Length;
        if (array is null || arrayLength <= 1)
        {
            throw new ArgumentNullException(nameof(array), "The array mustn't be null or empty, and must have at least one item!");
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
        Array.Copy(array, arrayLength - position, temp, 0, position);
        Array.Copy(array, 0, array, position, arrayLength - position);
        Array.Copy(temp, 0, array, 0, position);
    }
}