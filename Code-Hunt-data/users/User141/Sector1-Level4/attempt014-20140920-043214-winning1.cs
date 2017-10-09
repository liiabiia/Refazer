using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	 if(x == y) return true;
     if (x == 1 || x % y != 0) return false;
        for (int i = 2; i <= Math.Sqrt(y); i++)
        {
            if (y % i == 0) return true;
		    else if (x % i == 0) return true;
			else
			return false;
        }
        return true;
  }
}