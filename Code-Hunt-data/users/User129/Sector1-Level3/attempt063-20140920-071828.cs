using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {

if(x || !x)
  return x;
 
else if((!x) && (y == z))
{
  if (y)
   return y;
   else
   return z;
}
 else
 return (y && z);
  



return false;

}
}