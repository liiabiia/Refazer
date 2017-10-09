using System;
using System.Linq;
public class Program {
    public static int Puzzle(int[] a) {
      return a.Where((value,index) => index%2==1).Aggregate((c,b) => b + c);;
    }
}