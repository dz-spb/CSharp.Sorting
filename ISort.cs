namespace Sorting;

internal interface ISort<T> where T : IComparable<T>
{
    string Name { get; }

    T[] Execute(T[] array);
}
