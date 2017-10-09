using System;

public class Program {
  public static int Puzzle(int[] a) {

            decimal count = a.Length;
            decimal sum = a.Sum();

            return Math.Ceiling(sum/count); 
    
  }
}