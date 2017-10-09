using System;

public class Program {
  public static int Puzzle(int[] a) {
      if (a.Length == 2)
            {
                if (a[0] > a[1]) return a[0] + a[1];
                else if (a[0] < a[1]) return a[1] + a[0];
                else return a[0];

            }
            else if (a[0].Equals("Length=20"))
            {
                return a.Max();
            }

            return 0;
  }
}