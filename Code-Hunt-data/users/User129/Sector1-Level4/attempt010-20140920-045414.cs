using System;

public class Program {
  public static bool Puzzle(int x, int y) {

int i = x;
int j = y;

while(i <= j)
{
   i += x;
   if(i == y)
      return false;
}

if(x == 0 && y != 0 || (x == y) || ((x % 2 == 0 && y % 2 == 0) && ((y / x) % 2 != 0)))
return true;
else
return false;
    
  }
}