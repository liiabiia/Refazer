using System;

public class Program {
  public static bool Puzzle(int x, int y) {

if(y != 0 && x != 0)
{
  if(y % x == 0)
   return true;
  else 
   return false;
}
else if(x % 2 == 0 && y % 2 != 0)
  return true;
else if(x % 2 != 0 && y % 2 != 0) 
  return true;
else if((x == 0) || (y == 0)) 
  return true;
else 
   return false;
   
    
  }
}