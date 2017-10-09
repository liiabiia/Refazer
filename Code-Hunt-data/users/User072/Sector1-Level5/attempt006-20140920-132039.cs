using System;
using System.Linq;

public class Program {
    public static int Puzzle(int[] a) {
      return a.Last();//0;//a.Aggregate((x, b) => x + b);
    }
}