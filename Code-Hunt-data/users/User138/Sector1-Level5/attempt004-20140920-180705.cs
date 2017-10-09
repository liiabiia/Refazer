using System;
using System.Linq;
public class Program {
    public static int Puzzle(int[] a) {
      return (int)a.Sum(b=>(long)b);
    }
}