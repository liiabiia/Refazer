using System;

public class Program {
  public static int Puzzle(int[] a) {
    int retVal = 0;
            if (a.Length > 2)
            {
                retVal = a.Max();
            }
            else if (a.Length == 2)
                retVal = a.Max() + a.Min();

      return retVal;


  }
}