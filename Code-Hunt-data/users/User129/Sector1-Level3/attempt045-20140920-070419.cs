using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {

if(!x && y == z && y && z)
  return y;

else if(!x)
  return false;

else if(x)
  return x;

return false;


}
}