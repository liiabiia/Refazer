using System;

public class Program {
  public static int Puzzle(int x, int y) {
   if ( IsOdd(x) && IsOdd(y) || !IsOdd(x) && IsOdd(y))
                return x;
				  if (!IsOdd(x) && !IsOdd(y))
            {
                if (x < y)
                    return y;
                else
                    return x;
            
            }
            else if ( IsOdd(x) && !IsOdd(y))
			{ if (y>x && x>44 && y<73)
                return x * y/9;
				return x*y;
			}
            return x;

  }
  
    public static bool IsOdd(int value)
        {
           if(value % 2 != 0)
               return true;
           return false;
        }
}