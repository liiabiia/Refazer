using System;

public class Program {
  public static bool Puzzle(int x, int y) {
     if (y == 1 || x % y != 0) return false;
        for (int i = 2; i <= Math.Sqrt(y); i++)
        {
            if (f % i == 0) return false;
        }
        return true;
  }
}