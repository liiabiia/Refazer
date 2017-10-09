using System;

public class Program {
  public static bool Puzzle(int x, int y) {
     if (f == 1 || x % f != 0) return false;
        for (int i = 2; i <= Math.Sqrt(f); i++)
        {
            if (f % i == 0) return false;
        }
        return true;
  }
}