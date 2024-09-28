namespace Sorting;

internal class Program
{
    private static Random rnd = new Random();

    static void Main(string[] args)
    {
        ExecuteSort(new SelectionSort<int>(), GenerateIntArray(length: 10));
    }

    static void ExecuteSort<T>(ISort<T> sort, T[] array)
    {
        Console.WriteLine($"unsorted: {ToString(array)}");
        sort.Execute(array);
        Console.WriteLine($"sorted:   {ToString(array)}");
    }  

    static int[] GenerateIntArray(int length) =>
        length switch
        {
            > 0 => Shuffle(Enumerable.Range(0, length).ToArray()),
            _ => throw new ArgumentException("wrong length", nameof(length))
        };

    static T[] Shuffle<T>(T[] array) =>
        [.. array.OrderBy(_ => rnd.Next())];

    static string ToString<T>(T[] array) =>
        string.Join(", ", array);
}
