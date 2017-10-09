using System;
using System.Linq;
public class Program {
    public static int Puzzle(int[] a) {
      return a.Skip(1).Aggregate((c,b) => b + c);
    }
}