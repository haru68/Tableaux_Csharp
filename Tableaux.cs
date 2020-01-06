using System;

class MainClass {
  public static void Main (string[] args) {
    int[] FirstArray = new int[3] { 1, 2, 3 };
    Console.WriteLine(FirstArray);
    int[] SecondArray = new int[3] { 4, 5, 6 };
    Console.WriteLine(SecondArray);

    int[][] ThirdArray = new int[3][];
        ThirdArray[1] = FirstArray;
        ThirdArray[2] = SecondArray;
        
      
    Console.WriteLine(ThirdArray);
  }
}
