using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int sumOfLeftLeaves = 0;

        for (int i = 1; i < arr.Length; i += 2)
        {
            sumOfLeftLeaves += arr[i];
        }

        Console.WriteLine(sumOfLeftLeaves);
    }
}