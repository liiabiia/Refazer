using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
   double addFactor = 0;
   bool allUnique = a.Select(b => Math.Abs(b)).Distinct().Count() == a.Length;
   if (allUnique == false) addFactor = 0.5;
   return a.Sum() < 0 ? (int)(Math.Ceiling((((double)a.Sum()) / (double)a.Length) + addFactor)) : (int)(Math.Floor((((double)a.Sum()) / (double)a.Length) + 0.5)); 
           
  }
}