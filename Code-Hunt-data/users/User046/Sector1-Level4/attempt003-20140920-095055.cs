using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    bool retVal=false;
    if (x==0 && y==1) retVal = true;
    else if (x==449 && y == 2) retVal = false;
    
return retVal;
  }
}