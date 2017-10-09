using System;

public class Program {
  public static int Puzzle(int[] a) {

if (a.Length == 1) return a[0];

      int total = 0;
            for (int i = 0; i < a.Length; i++)
                    total += a[i];
            total++;
            return (total / a.Length);
    
  }
}