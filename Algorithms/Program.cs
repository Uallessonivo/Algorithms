
using Algorithms;

class Program
{
    public static void Main(string[] args)
    {
        // Binary Search
        var nums = new int[] {-1, 0, 1, 2, 3, 5, 8, 9, 15, 70};
        var binarySearch = BinarySearchSolution.Search(nums, 9);
        Console.WriteLine($"Binary Search: {binarySearch}");
    }
}