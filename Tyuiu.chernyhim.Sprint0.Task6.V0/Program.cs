using Tyuiu.chernyhim.Sprint0.Task6.V0.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Sum of array elements: " + DataService.AdditionArray(numsArray));
        Console.WriteLine("Subtraction of array elements: " + DataService.SubstructionArray(numsArray));
        Console.WriteLine("Multiplication of array elements: " + DataService.MultiplicationArray(numsArray));
        Console.ReadKey();
    }
}