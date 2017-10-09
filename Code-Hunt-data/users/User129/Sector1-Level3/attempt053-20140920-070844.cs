using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {

if((!x) && (y) && (z))
{
  if(y == z)
   return y;
    
   return false;
}

else if(x)
  return x;



return false;

}
}