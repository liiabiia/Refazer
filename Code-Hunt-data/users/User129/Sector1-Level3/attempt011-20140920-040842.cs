using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {

if(x && y && z)
  return true;
else if(((x && y) || (y && z) || (x && z)) && x)
  return true;
else 
return false;
  }
}