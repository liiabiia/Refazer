using System;

public class Program {
  public static int Puzzle(int[] a) {
    int nonZero = 0;
            int final = 0;
            if (a.Length == 1)
                return a[0];
            else
            {
                foreach (int b in a)
                {
                    if (b != 0)
                        nonZero++;
                }
                a[1] = a[1] * nonZero;

                foreach (int b in a)
                {
                    final += b;
                }

            }
            return final;
  }
}