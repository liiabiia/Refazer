using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {

if((!x) && (y == z) && (y && z))
  return z;

else if(x)
  return x;

else if(!x)
  return false;

return false;

}
}