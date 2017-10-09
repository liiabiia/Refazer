using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
if(x==false&&y==false)
    return false;
if(x==true&&y==true)
return true;
if(x==false&&y==true)
return false;
if(x==true&&y==false)
return false;
  }
}