namespace Sorting;

/// <summary>
/// Time complexity is O(n*log(n)) for the average and worst cases
/// Space complexity is O(n)
/// Stability: stable
/// </summary>
internal class MergeSort<T> : ISort<T> where T : IComparable<T>
{
    public T[] Execute(T[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
       
        return Merge(array, 0, array.Length - 1);
    }

    private T[] Merge(T[] array, int l, int h)
    {        
        if (l >= h)
        {
            return array;
        }

        var m = l + (h - l)/2;
        array = Merge(array, l, m);
        array = Merge(array, m + 1, h);
        return MergeInPlace(array, l, m, h);
    }

    private T[] MergeInPlace(T[] array, int l, int m, int h)
    {
        //TODO
        return array;
    }
}
