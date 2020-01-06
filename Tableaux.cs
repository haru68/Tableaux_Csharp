using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] FirstArray = new int[3] { 1, 2, 3 };
        Console.WriteLine("Premier tableau:");
        Console.WriteLine("[{0}]", string.Join(", ", FirstArray));

        int[] SecondArray = new int[3] { 4, 5, 6 };
        Console.WriteLine("Second tableau:");
        Console.WriteLine("[{0}]", string.Join(", ", SecondArray));

        int[] ThirdArray = new int[6] { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine("Troisième tableau:");
        Console.WriteLine("[{0}]", string.Join(", ", ThirdArray));
    }
}
