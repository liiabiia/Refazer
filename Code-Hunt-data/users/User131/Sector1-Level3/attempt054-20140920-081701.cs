using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
 if((x==true)||(y==true&&z==y)||(z==true&&y==z)||(y==true&&z==true))
 return true;
 else
 return false;
 
  
  }
}