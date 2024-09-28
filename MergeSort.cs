namespace Sorting;

/// <summary>
/// Time complexity is O(n*log(n)) for the average and worst cases
/// Space complexity is O(n)
/// Stability: stable
/// </summary>
internal class MergeSort<T> : ISort<T> where T : IComparable<T>
{
    public string Name => "merge sort";

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
        var helperArray = new T[h - l + 1];
        for (var k = l; k < h + 1; k++)
        {
            helperArray[k - l] = array[k];
        }

        var i = 0;
        var cm = m - l + 1;
        var ch = h - l + 1;
        var j = cm;

        for (var k = l; k < h + 1; k++)
        {
            if (i >= cm)
            {
                array[k] = helperArray[j];
                j += 1;
            }
            else if (j >= ch)
            {
                array[k] = helperArray[i];
                i += 1;
            }
            else if (helperArray[i].CompareTo(helperArray[j]) <= 0)
            {
                array[k] = helperArray[i];
                i += 1;
            }
            else
            {
                array[k] = helperArray[j];
                j += 1;
            }
        }

        return array;
    }
}
