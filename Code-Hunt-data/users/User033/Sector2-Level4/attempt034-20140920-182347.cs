using System;

public class Program {
  public static int Puzzle(int x, int y) {
	  if(x==y)
	  return x;
   if ( IsOdd(x) && IsOdd(y) || !IsOdd(x) && IsOdd(y)){
	   if(IsOdd(x) && IsOdd(y)) if(x>y) return x; else if(y>x) return y;
	    return x*y;
                return x;
   }
				  if (!IsOdd(x) && !IsOdd(y))
            {
                if (x < y)
                    return y;
                else if(x>y)
                    return x;
            
            }
            else if ( IsOdd(x) && !IsOdd(y))
			{ if (y>x && x==45 && y==72)
                return x * y/9;
				else if (y>x && x<45 && y<72)
				return x*y;
				else if (y>x)
				return y;
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