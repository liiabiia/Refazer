using System;

public class Program {
  public static int Puzzle(int[] a) { int count=0;
    Array myArray = new int[] { 1, 2, 4 }; lock(myArray.SyncRoot) { foreach (Object item in myArray)   count++; }
    return count ;
  }
}