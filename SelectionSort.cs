namespace Sorting;

/// <summary>
/// Time complexity is O(n^2) for the average and worst cases
/// Space complexity is O(1)
/// Stability: unstable
/// </summary>
internal class SelectionSort<T> : ISort<T> where T : IComparable<T>
{
    public T[] Execute(T[] array)
    {
        ArgumentNullException.ThrowIfNull(array);

        for (var i = 0; i < array.Length - 1; i++)
        {
            var m = i;
            for (var j = i + 1; j < array.Length; j++)
            {
                m = array[j].CompareTo(array[m]) < 0 ? j : m;
            }
            (array[m], array[i]) = (array[i], array[m]);
        }

        return array;
    }  
}
