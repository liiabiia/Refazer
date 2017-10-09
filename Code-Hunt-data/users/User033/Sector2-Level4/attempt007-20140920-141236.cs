using System;

public class Program {
  public static int Puzzle(int x, int y) {
   if (!IsOdd(x) && !IsOdd(y) || IsOdd(x) && IsOdd(y))
                return x;
            else if (!IsOdd(x) && IsOdd(y) || IsOdd(x) && !IsOdd(y))
                return x * y;
            return x;

  }
  
    public static bool IsOdd(int value)
        {
           if(value % 2 != 0)
               return true;
           return false;
        }
}