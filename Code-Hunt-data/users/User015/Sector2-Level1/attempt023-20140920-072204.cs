using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    if (a.Length == 1) return  a[0];
   return  a.Sum() < 0 ? (int)(Math.Floor((((double)a.Sum()) / (double)a.Length)+0.25)) +1 : (int)(Math.Floor((((double)a.Sum()) / (double)a.Length) + 0.5)); 
           
  }
}