namespace Sorting;

/// <summary>
/// Time complexity is O(n^2) for the average and worst cases
/// Space complexity is O(1)
/// Stability: stable
/// </summary>
internal class BubbleSort<T> : ISort<T> where T : IComparable<T>
{
    public string Name => "bubble sort";

    public T[] Execute(T[] array)
    {
        ArgumentNullException.ThrowIfNull(array);

        for (var i = 1; i < array.Length; i++)
        {
            var permutation = false;
            for (var j = 0; j < array.Length - i; j++)
            {
                if (array[j].CompareTo(array[j + 1]) < 0)
                {
                    continue;
                }
                
                (array[j], array[j + 1]) = (array[j + 1], array[j]);
                permutation = true;                
            }

            if (!permutation)
            {
                break;
            }
        }

        return array;
    }  
}
